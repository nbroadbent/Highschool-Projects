// .Net Libraries
using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml;
using System.Text;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Runtime.InteropServices;
using System.Linq;
using AlgoTrader;

namespace AlgoTrader
{
    /// <summary>
    /// An Algorithmic trader that uses The Questrade API
    /// </summary>
    internal class AlgoTrader
    {
        static Form1 MyForm;
        static AlgoTrader program = new AlgoTrader();

        public static bool trading = false;

        [STAThread]
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);
        /// <summary>
        /// Runs when program is first started
        /// </summary>
        private static string[] Start()
        {
            // variables
            bool tokenIsGood = true;
            string refreshToken = null;
            string[] authorizationKeyWords = { "access_token", "token_type", "expires_in", "refresh_token", "api_server" };

            // Get refresh token.
            refreshToken = Store.Retrieve();
            do
            {
                // Ask user for refresh token, if token is invalid.
                while (String.IsNullOrEmpty(refreshToken))
                {
                    refreshToken = Microsoft.VisualBasic.Interaction.InputBox("Please enter your refresh token that is linked to your account.", "Refresh Token", "refresh token");
                }

                // Use refresh token to get authorization data.
                if (!String.IsNullOrEmpty(refreshToken))
                {
                    // Redeem Refresh token.
                    string authorizedDataJson = Request.RedeemRefreshToken(refreshToken);

                    // Parse data.
                    if (authorizedDataJson != null)
                    {
                        // Write new refresh token.
                        if (tokenIsGood != false)
                            Store.RefreshToken(refreshToken);

                        return Parse.Json(null, authorizedDataJson, authorizationKeyWords, 5);
                    }
                    else
                    {
                        // Refresh token is invalid.
                        MessageBox.Show("Refresh Token error... Invalid.");
                        refreshToken = null;
                        tokenIsGood = false;
                    }
                }
                else
                {
                    // Refresh token is invalid.
                    MessageBox.Show("Refresh Token error... Invalid.");
                    refreshToken = null;
                    tokenIsGood = false;
                }
            } while (!tokenIsGood);
            return null;
        }

        /// <summary>
        /// Gets data top start program.
        /// </summary>
        /// <param name="args">No Arguments</param>
        internal static string[] GetData()
        {
            string[] authorizedData = null;
            
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output. 
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.
            //synth.Speak("Welcome to Algo Trader!");

            // Get authorization data.
            do
            {
                authorizedData = Start();
            } while (authorizedData == null);

            return authorizedData;
        }

        /// <summary>
        /// Loop through this.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="apiServer"></param>
        /// <param name="authorizedData"></param>
        /// <param name="accountNumber"></param>
        internal static string[] TradeThreadManager(string accessToken, string apiServer, string[] authorizedData, double[] settings, int accountNumber)
        {
            int goodTrades = 0;
            int totalTrades = 0;
            double profit = 0;
            double oldProfit = 0;
            string[] tradeData = new string[6];
            bool powerDown = false;
            bool startTrading = true;  

            Strategy strategy = new Strategy();

            // Create trading threads.
            Thread nflx = new Thread(() => { strategy.Trade(authorizedData, settings, "NFLX"); });
            Thread spy = new Thread(() => { strategy.Trade(authorizedData, settings, "SPY"); });

            while (true)
            {
                profit = 0;
                if (trading == true)
                {
                    if (startTrading)
                    {
                        // Trade Tickers.
                        nflx.Start();
                        spy.Start();

                        startTrading = false;
                    }

                    // Update positions for stocks being traded.
                    double[] positionsProfit = Request.Positions(accessToken, apiServer, "SPY", accountNumber);

                    // Parse position data.
                    if (positionsProfit != null)
                    {
                        oldProfit = positionsProfit[3];
                    }

                    // Track profit goal.        

                    // Update positions for stocks being traded.
                    double[] positionNflx = Request.Positions(accessToken, apiServer, "NFLX", accountNumber);
                    double[] positionSpy = Request.Positions(accessToken, apiServer, "SPY", accountNumber);

                    // Parse position data. 
                    if (positionSpy != null && positionNflx != null)
                    {
                        profit = positionNflx[3] + positionSpy[3];                  

                        if (profit != oldProfit)
                        {
                            if (profit > oldProfit)
                            {
                                goodTrades += 1;
                            }
                            totalTrades += 1;

                            Store.Probability(goodTrades, totalTrades);
                            Store.Profit(profit);
                            oldProfit = profit;
                        }

                        // Shutdown Program if profit goal reached or max loss reached.
                        if (profit >= settings[0] || profit <= (settings[1] * -1))
                        {
                            // Stop trading.
                            trading = false;

                            // Write down close time.
                            Store.EndTime(DateTime.Now, profit);

                            if (profit >= settings[0])
                                MessageBox.Show("Trading stopped: Profit goal reached.");
                            else
                                MessageBox.Show("Trading stopped: Max loss reached.");

                            // Power down computer.
                            if (powerDown)
                            {
                                SetSuspendState(true, true, true);
                            }
                            Environment.Exit(0);
                        }
                        tradeData[5] = profit.ToString();
                    }
                    // Update trade data. "symbol", "openQuantity", "averageEntryPrice", "closedPnl"
                }
                else
                {
                    // Check if trading thread is running.
                    if (spy.IsAlive)
                    {
                        // Close thread.
                        spy.Abort();
                    }
                    else if (nflx.IsAlive)
                    {
                        // Close thread.
                        nflx.Abort();
                    }
                    else
                    {
                        return tradeData;
                    }
                }
            }
        }
    }

    /// <summary>
    /// Algorithmic strategy.
    /// </summary>
    internal class Strategy
    {
        private int symbolId = 0;
        private int accountNumber = 0;
        private string apiServer = null;
        private string accessToken = null;

        // Trade.
        public void Trade(string[] authorizedData, double[] settings, string symbol)
        {
            // Initialize variables.
            double[] orderData = null;
            int quantity = 0;
            string signal = null;
            bool closed = false;

            PrepareOrder prepare = new PrepareOrder();
            AlgoTrader main = new AlgoTrader();
            accessToken = authorizedData[0];
            apiServer = authorizedData[4];

            // Get account data.
            string[] accountData = Request.AccountInfo(accessToken, apiServer);
            if (accountData != null)
            {
                accountNumber = Convert.ToInt(accountData[1]);
                string accountStatus = accountData[2];
            }
            else
            {
                // Abort thread.
                MessageBox.Show("Count not retrieve account data!");
                return;
            }

            // Search for symbol id. "symbol", "symbolId", "isTradable", "isQuotable".
            string[] searchData = Request.Search(accessToken, apiServer, symbol);

            if (searchData != null)
            {
                string searchSymbol = searchData[0];
                symbolId = Convert.ToInt(searchData[1]);
            }
            else
            {
                // Abort thread.
                MessageBox.Show("Could not retrieve symbol data!");
                return;
            }

            // Run strategy.
            while (true)
            {
                // Check for positions already open for stock.
                double[] positions = Request.Positions(accessToken, apiServer, symbol, accountNumber);
                if (positions != null)
                {
                    quantity = (int)positions[1];
                }

                // Pause after position has been closed.
                if (closed)
                {
                    Thread.Sleep(4000);
                    closed = false;
                }

                // Look for signal.
                signal = Signal(settings[3], symbol, symbolId);

                if (signal == null)
                    return;

                // Buy signal.
                if (signal == "Buy")
                {
                    // Tell form we are buying.
                    prepare.Buy(accessToken, apiServer, symbol, settings, accountNumber, symbolId);
                }
                // Sell signal.
                if (signal == "Sell")
                {
                    // Tell form we are selling.
                    prepare.Sell(accessToken, apiServer, symbol, settings, accountNumber, symbolId);
                }
            }
        }

        public string Signal(double profitTaking, string symbol, int symbolId)
        {
            int i = 10;
            int period = 2;
            int length = 11;
            int quantity = 0;
            double price = 0;
            double askPrice = 0;
            double bidPrice = 0;
            double wmaShort = 0;
            double oldWmaShort = 0;
            double wmaLong = 0;
            double oldWmaLong = 0;
            double fillPrice = 0;
            double[] stochastic = { 0, 0 };
            double[,] candleSticks;
            string[] quote;

            // Run strategy.
            while (true)
            {
                // Check for positions already open for stock. "symbol", "openQuantity", "averageEntryPrice", "closedPnl"
                double[] positions = Request.Positions(accessToken, apiServer, symbol, accountNumber);
                if (positions != null)
                {
                    quantity = (int)positions[1];
                    fillPrice = positions[2];
                }

                // Pause if position closed.
                if (quantity == 0)
                {
                    //Thread.Sleep(1000);
                }
                else
                {

                }

                // Get 5 min candlestick data for past 10 candles.     
                candleSticks = Request.candlestickData(accessToken, apiServer, symbolId, length, period);

                if (candleSticks != null)
                {
                    int empty = 0;
                    // Candlesticks elements 0-3 "low", "high", "close", "volume"
                    string[] candle = { "low", "high", "close", "volume" };

                    // Parse candlestick data. 
                    for (int h = 0; h < length; h++)
                    {
                        // Look for empty data.
                        if (candleSticks[h, 0] == 0)
                        {
                            empty += 1;
                        }

                        // Round data to two decimal places.
                        for (int j = 0; j < 4; j++)
                        {
                            candleSticks[h, j] = Math.Round(candleSticks[h, j], 2);
                        }
                    }

                    if (empty > 0)
                        Store.Empty(symbol, empty);

                    // Run if enough data.
                    if (empty == 0)
                    {
                        // Get current price.
                        quote = Request.Quote(accessToken, apiServer, symbolId);
                        if (!Double.TryParse(quote[3], out askPrice))
                            MessageBox.Show("Could not convert limit price: ask");
                        if (!Double.TryParse(quote[2], out bidPrice))
                            MessageBox.Show("Could not convert limit price: bid");
                        price = Math.Round(((askPrice + bidPrice) / 2), 2);

                        if (length > 9)
                        {
                            wmaLong = Calculate.WeightedMovingAverage(candleSticks, 10);
                            wmaShort = Calculate.WeightedMovingAverage(candleSticks, 5);
                            oldWmaLong = Calculate.WeightedMovingAverage(candleSticks, 10, 1);
                            oldWmaShort = Calculate.WeightedMovingAverage(candleSticks, 5, 1);

                           // MessageBox.Show("long: " +wmaLong);
                           // MessageBox.Show("short: " + wmaShort);
                        }

                        // Check to place trade.
                        if (quantity <= 0)
                        {
                            if (quantity < 0)
                            {
                                double[] stoch = Calculate.Stochastic(candleSticks, 10);

                                // Stochastic exit signal.
                                if (stoch[1] < 28 && stoch[0] > stoch[1])
                                {
                                    MessageBox.Show("Stochastic cover");
                                    return "Buy";
                                }
                                // Take profits.
                                if (fillPrice - (profitTaking * fillPrice) >= price)
                                {
                                    //MessageBox.Show("buy profit");
                                    //return "Buy";
                                }
                                // Limit losses.
                                if (fillPrice <= price)
                                {
                                   // return "Buy";
                                }
                            }

                            //&& oldWmaShort < oldWmaLong
                            // Buy if 5 period ma is greater than the 10 period.
                            if (wmaShort > wmaLong)
                            {
                                //MessageBox.Show("buy signal");
                                return "Buy";
                            }
                        }
                        if (quantity >= 0)
                        {
                            if (quantity > 0)
                            {
                                double[] stoch = Calculate.Stochastic(candleSticks, 10);

                                // Stochastic exit signal.
                                if (stoch[1] > 72 && stoch[0] < stoch[1])
                                {
                                    MessageBox.Show("Stochastic Sell");
                                    return "Sell";
                                }
                                // Take profits.
                                if (fillPrice + (profitTaking * fillPrice) <= price)
                                {
                                    //MessageBox.Show("sell profit" + fillPrice + (profitTaking * fillPrice));
                                    //return "Sell";
                                }
                                // Limit losses.
                                if (fillPrice >= price)
                                {
                                    //return "Sell";
                                }
                            }
                            //oldWmaShort > oldWmaLong
                            // Sell if 5 period ma is less than the 10 period.
                            if (wmaShort < wmaLong)
                            {
                                //MessageBox.Show("sell signal");
                                return "Sell";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not enough candlestick data.");
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("Could not retrieve candlestick data.");
                }
            }
        }
    }

    internal class PrepareOrder
    {
        // Confirm buy signal.
        internal double[] Buy(string accessToken, string apiServer, string symbol, double[] settings, int accountNumber, int symbolId)
        {
            if (true)
            {
                // Check for positions already open for stock.
                double[] positions = Request.Positions(accessToken, apiServer, symbol, accountNumber);
                int quantity = 0;
                if (positions != null)
                {
                    quantity = (int)positions[1];
                }

                if (quantity <= 0)
                {
                    // Check for orders already open.
                    int openOrders = Request.OpenOrders(accessToken, apiServer, symbol, accountNumber);

                    if (openOrders <= 0)
                    {
                        double tradeValue = 0;

                        // Get balance.
                        string[] balance = Request.AccountBalance(accessToken, apiServer, accountNumber);

                        // Get amount to trade.
                        if (!Double.TryParse(balance[7], out tradeValue))
                            MessageBox.Show("Please enter a number");
                        else
                            tradeValue *= settings[2];

                        // Check for buying power, unless covering short.
                        if (quantity < 0 || tradeValue > 5000)
                        {
                            return Order.Buy(accessToken, apiServer, symbol, tradeValue, settings[3], accountNumber, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Sorry, but you do not have enough money to day trade. Minimum 5000");
                        }
                    }
                }
            }
            return null;
        }

        internal double[] Sell(string accessToken, string apiServer, string symbol, double[] settings, int accountNumber, int symbolId)
        {
            if (true)
            {
                // Check for positions already open for stock.
                double[] positions = Request.Positions(accessToken, apiServer, symbol, accountNumber);
                int quantity = 0;
                if (positions != null)
                {
                    quantity = (int)positions[1];
                }

                if (quantity >= 0)
                {
                    // Check for orders already open.
                    int openOrders = Request.OpenOrders(accessToken, apiServer, symbol, accountNumber);

                    if (openOrders <= 0)
                    {
                        double tradeValue = 0;

                        // Get balance.
                        string[] balance = Request.AccountBalance(accessToken, apiServer, accountNumber);

                        // Get amount to trade.
                        if (!Double.TryParse(balance[7], out tradeValue))
                            MessageBox.Show("Please enter a number");
                        else
                            tradeValue *= settings[2];

                        // Check for buying power, unless covering long.
                        if (quantity > 0 || tradeValue > 5000)
                        {
                            return Order.Sell(accessToken, apiServer, symbol, tradeValue, settings[3], accountNumber, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Sorry, but you do not have enough money to day trade. Minimum 5000");
                        }
                    }
                }
            }
            return null;
        }
    }

    /// <summary>
    /// Buy and sell orders
    /// </summary>
    internal static class Order
    {
        /// <summary>
        /// Create order to buy.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="apiServer"></param>
        /// <param name="symbol"></param>
        /// <param name="accountId"></param>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public static double[] Buy(string accessToken, string apiServer, string symbol, double tradeValue, double profitTaking, int accountNumber, int quantity)
        {
            int symbolId = 0;
            double[] orderData = null;
            string authorization = "Bearer " + accessToken;
            string url = apiServer + "v1/accounts/" + accountNumber + "/orders";
            string action = "Buy";
            string isQuotable = null;
            string isTradable = null;
            string[] quote = null;

            // Search for ticker.
            string[] search = Request.Search(accessToken, apiServer, symbol);
            string searchSymbol = search[0];
            symbolId = Convert.ToInt(search[1]);
            isQuotable = search[2];
            isTradable = search[3];

            // Quote ticker.
            if (searchSymbol == symbol)
            {
                if (isQuotable == "True")
                {
                    quote = Request.Quote(accessToken, apiServer, symbolId);
                    double limitPrice = 0;
                    double askPrice = 0;
                    double bidPrice = 0;
                    if (!Double.TryParse(quote[3], out askPrice))
                        MessageBox.Show("Could not convert limit price: ask");
                    if (!Double.TryParse(quote[2], out bidPrice))
                        MessageBox.Show("Could not convert limit price: bid");
                    //try
                    //{
                    if (quote[1] == "False")
                    {
                        // Get buy price, stop loss, quantity... 
                        int currQuant = quantity;
                        limitPrice = Math.Round(((askPrice + bidPrice) / 2), 2);
                        orderData = BuyData(limitPrice, tradeValue, profitTaking, quantity);

                        quantity = (int)orderData[0];
                        double stopPrice = orderData[3];

                        // Nothing to trade.
                        if (quantity == 0)
                        {
                            return null;
                        }

                        // Resize array.
                        Array.Resize<double>(ref orderData, 7);

                        // Send order.
                        string[] jsonArray = { "orders[0]." };
                        string[] searchKeyWords = { "id" };
                        string buy = Request.Order(authorization, url, action, accountNumber, symbolId, quantity, limitPrice, stopPrice);
                        string[] stringOrderData = Parse.Json(jsonArray, buy, searchKeyWords, searchKeyWords.Length);

                        if (stringOrderData[0] != null)
                        {
                            int orderId = Convert.ToInt(stringOrderData[0]);
                            int time = Request.GetTime(accessToken, apiServer);
                            int current = 0;
                            bool executed = false;

                            if (!Double.TryParse(stringOrderData[0], out orderData[4]))
                                MessageBox.Show("Could not convert order id");

                            orderData[5] = limitPrice;
                            orderData[6] = currQuant;

                            while (true)
                            {
                                // Check order status.
                                executed = Status(accessToken, apiServer, accountNumber, orderId);

                                // Get time.
                                current = Request.GetTime(accessToken, apiServer);

                                // If order has not been executed after 30 seconds, cancel.
                                if (executed)
                                {
                                    // Return order data.                                    
                                    return orderData;
                                }
                                if ((current - time) > 30)
                                {
                                    // Re-check order execution.
                                    executed = Status(accessToken, apiServer, accountNumber, orderId);
                                    if (executed)
                                    {
                                        return orderData;
                                    }

                                    // Cancel order.
                                    Cancel(accessToken, apiServer, accountNumber, orderId);
                                    break;
                                }
                                double[] positions = Request.Positions(accessToken, apiServer, symbol, accountNumber);

                                if (positions != null)
                                {
                                    int filled = (int)positions[1];
                                    if (filled > currQuant)
                                    {
                                        // Return order data.
                                        return orderData;
                                    }
                                }
                            }
                            return null;
                        }
                    }
                    /*}
                    catch
                    {
                        return null;
                    }*/
                }
            }
            return null;
        }

        /// <summary>
        /// Create order to sell.
        /// </summary>
        /// <returns></returns>
        public static double[] Sell(string accessToken, string apiServer, string symbol, double tradeValue, double profitTaking, int accountNumber, int quantity)
        {
            int symbolId = 0;
            string authorization = "Bearer " + accessToken;
            string url = apiServer + "v1/accounts/" + accountNumber + "/orders/";
            string action = "Sell";
            string isQuotable = null;
            string isTradable = null;
            string[] quote = null;

            // Search for ticker.
            string[] search = Request.Search(accessToken, apiServer, symbol);
            string searchSymbol = search[0];
            symbolId = Convert.ToInt(search[1]);
            isQuotable = search[2];
            isTradable = search[3];

            // Quote ticker.
            if (searchSymbol == symbol)
            {
                if (isQuotable == "True")
                {
                    quote = Request.Quote(accessToken, apiServer, symbolId);
                    double limitPrice = 0;
                    double askPrice = 0;
                    double bidPrice = 0;

                    if (!Double.TryParse(quote[3], out askPrice))
                        MessageBox.Show("Could not convert limit price: Buy0");
                    if (!Double.TryParse(quote[2], out bidPrice))
                        MessageBox.Show("Could not convert limit price: Buy1");
                    //try
                    //{
                    if (quote[1] == "False")
                    {
                        // Get buy price, stop loss, quantity...
                        int currQuant = quantity;
                        limitPrice = Math.Round(((askPrice + bidPrice) / 2), 2);
                        double[] orderData = SellData(limitPrice, tradeValue, profitTaking, quantity);
                        quantity = (int)orderData[0];

                        double stopPrice = orderData[3];

                        if (quantity == 0)
                        {
                            return null;
                        }

                        Array.Resize<double>(ref orderData, 7);

                        // Send order.
                        string[] jsonArray = { "orders[0]." };
                        string[] searchKeyWords = { "id" };
                        string sell = Request.Order(authorization, url, action, accountNumber, symbolId, quantity, limitPrice, stopPrice);
                        string[] stringOrderData = Parse.Json(jsonArray, sell, searchKeyWords, searchKeyWords.Length);


                        if (stringOrderData[0] != null)
                        {
                            int orderId = Convert.ToInt(stringOrderData[0]);
                            int time = Request.GetTime(accessToken, apiServer);
                            int current = 0;
                            bool executed = false;

                            if (!Double.TryParse(stringOrderData[0], out orderData[4]))
                                MessageBox.Show("Could not convert order id");

                            orderData[5] = limitPrice;
                            orderData[6] = currQuant;

                            while (true)
                            {
                                // Check order.
                                executed = Status(accessToken, apiServer, accountNumber, orderId);

                                // Get time.
                                current = Request.GetTime(accessToken, apiServer);

                                // If has not been executed after 30 seconds, cancel.
                                if (executed)
                                {
                                    return orderData;
                                }
                                if ((current - time) > 30)
                                {
                                    // Re-check order execution.
                                    executed = Status(accessToken, apiServer, accountNumber, orderId);
                                    if (executed)
                                    {
                                        return orderData;
                                    }

                                    // Cancel order.
                                    // Create message that order has been cancelled.
                                    Cancel(accessToken, apiServer, accountNumber, orderId);
                                    break;
                                }
                                double[] positions = Request.Positions(accessToken, apiServer, symbol, accountNumber);

                                if (positions != null)
                                {
                                    int filled = (int)positions[1];

                                    if (filled < currQuant)
                                    {
                                        // Order has been filled.
                                        return orderData;
                                    }
                                }
                            }
                            return null;
                        }
                    }
                    /*}
                    catch
                    {
                        MessageBox.Show("Error selling " + symbol + ". Order may or may not have been sent.");
                        return null;
                    }*/
                }
            }
            return null;
        }

        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="apiServer"></param>
        /// <param name="accountNumber"></param>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public static int Cancel(string accessToken, string apiServer, int accountNumber, int orderId)
        {
            string[] keyWords = { "orderId" };
            string command = "v1/accounts/" + accountNumber + "/orders/" + orderId;

            string cancelJson = Request.Json("DELETE", command, accessToken, apiServer);
            string[] cancelOrderIdString = Parse.Json(null, cancelJson, keyWords, keyWords.Length);
            return Convert.ToInt(cancelOrderIdString[0]);
        }

        public static string[] status = new string[2];
        /// <summary>
        /// Check order status. ADD ID TO LIST WHEN BUY. RUN THROUGH LIST TO CHECK STATUS. TAKE ID OFF LIST WHEN SELL. UPDATE ACTIVITY. CLOSE THREAD.
        /// </summary>
        internal static bool Status(string accessToken, string apiServer, int accountNumber, int orderId)
        {
            string[] jsonArray = { "orders[0].", "orders[0]." };
            string[] searchKeyWords = { "state", "side" };

            string statusJson = Request.Json("GET", "v1/accounts/" + accountNumber + "/orders?ids=" + orderId, accessToken, apiServer);
            status = Parse.Json(jsonArray, statusJson, searchKeyWords, 2);

            // Check if order has been executed.
            if (status[0] != "Rejected")
            {
                // Order has not been rejected.
                // If order has been executed.
                if (status[0] == "Executed")
                {
                    return true;
                }
                // If order has been canceled.
                else if (status[0] == "Cancelled")
                {
                    return true;
                }
                // If order has failed.
                else if (status[0] == "Failed")
                {
                    return true;
                }
            }
            else
            {
                // Cancel order if it's rejected.
                orderId = Cancel(accessToken, apiServer, accountNumber, orderId);
            }
            return false;
        }

        /// <summary>
        /// Data for buy order.
        /// </summary>
        /// <param name="limitPrice"></param>
        /// <returns></returns>
        private static double[] BuyData(double limitPrice, double tradeValue, double profitTaking, int quantity)
        {
            double[] buyData = new double[4];
            try
            {
                // Calculate amount to buy, if none owned.
                if (quantity == 0)
                {
                    // Quantity.
                    buyData[0] = tradeValue / limitPrice;
                    buyData[0] = Math.Round(buyData[0]);

                    // Commission.
                    buyData[1] = ((buyData[0] / 100) >= 4.95) ? (buyData[0] / 100) : 4.95;
                }
                // Don't buy if already bought.
                else if (quantity > 0)
                {
                    buyData[0] = 0;
                }
                // Cover short.
                else
                {
                    buyData[0] = Math.Abs(quantity);

                    // Commission.
                    buyData[1] = ((buyData[0] / 100) >= 4.95) ? (buyData[0] / 100) : 4.95;
                }
                //Stop limit.
                if (profitTaking != 0)
                    buyData[3] = Math.Round(((tradeValue - (tradeValue * (profitTaking / 2))) / buyData[0]), 2);
                else
                    buyData[3] = limitPrice-(limitPrice*0.0001);

                return buyData;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// Data For sell order.
        /// </summary>
        /// <param name="limitPrice"></param>
        /// <returns></returns>
        private static double[] SellData(double limitPrice, double tradeValue, double profitTaking, int quantity)
        {
            double[] sellData = new double[4]; ;

            if (quantity == 0)
            {
                // Quantity.
                sellData[0] = tradeValue / limitPrice;
                sellData[0] = Math.Round(sellData[0]);

                // Commission.
                sellData[1] = ((sellData[0] / 100) >= 4.95) ? (sellData[0] / 100) : 4.95;
            }
            else if (quantity < 0)
            {
                sellData[0] = 0;
            }
            else
            {
                sellData[0] = quantity;
            }
            // Stop limit.
            if (profitTaking != 0)
                sellData[3] = Math.Round(((tradeValue - (tradeValue * (profitTaking/2))) / sellData[0]), 2);
            else
                sellData[3] = limitPrice - (limitPrice * 0.0001);

            return sellData;
        }
    }

    /// <summary>
    /// C
    /// </summary>
    internal static class Calculate
    {
        public static double WeightedMovingAverage(double[,] prices, int period, int old = 0)
        {
            int total = 0;
            double wma = 0;

            try
            {
                if (period <= prices.Length)
                {
                    for (int i = 0; i < period; i++)
                    {
                        total += period - i;
                    }

                    int weight = period;

                    for (int i = old; i < (period + old); i++)
                    {
                        wma += prices[i, 2] * ((double)weight / (double)total);
                        weight--;
                    }
                }
                return wma;
            }
            catch
            {
                MessageBox.Show("Could not Calculate Weighted Moving Average of period " + period);
                return 0;
            }
        }

        public static double Momentum(double[] prices, int period)
        {
            double p = prices[1] - prices[0];

            if (p < 0)
            {
                p *= -1;
                p = Math.Round(p, 3);
                return p *= -1;

            }
            else
            {
                return Math.Round(p, 3);
            }
        }

        // Fast %K: [(Close - Low) / (High - Low)] x 100
        // Fast %D: Simple moving average of Fast K(usually 3-period moving average)
        public static double[] Stochastic(double[,] prices, int period)
        {
            double[] k = new double[3];

            k[0] = Math.Round(FastK(prices, period, 2), 2);
            k[1] = Math.Round(FastK(prices, period, 1), 2);
            k[2] = Math.Round(FastK(prices, period, 0), 2);

            double d = Math.Round((k[0] + k[1] + k[2]) / 3, 2);

            double[] stochastic = new double[3];
            stochastic[0] = k[2];
            stochastic[1] = d;

            return stochastic;
        }

        public static double FastK(double[,] prices, int period, int j)
        {
            double high = 0;
            double low = 0;
            double close = 0;

            for (int i = 0; i < period; i++)
            {
                // I'm just taking the highest/lowest closing prices
                // I should be seeing if the high is higher than the highest
                // Likewise with the low.
                close = prices[0, 2];

                if (prices[i, 1] > high)
                {
                    high = prices[0, 1];
                }

                if (prices[i, 0] < low)
                {
                    low = prices[0, 0];
                }
            }
            return (((close - low) / (high - low)) * 100);
        }
    }

    /// <summary>
    /// Send and recieve data to questrade.
    /// </summary>
    internal static class Request
    {
        // Account balance.
        internal static string[] AccountBalance(string accessToken, string apiServer, int accountNumber)
        {
            // Get account balance.
            string command = "v1/accounts/" + accountNumber + "/balances";
            string[] jsonArray = { "combinedBalances[0].", "perCurrencyBalances[0].", "perCurrencyBalances[0].", "combinedBalances[0].", "combinedBalances[0].", "combinedBalances[0].",
                            "combinedBalances[1].", "perCurrencyBalances[1].", "perCurrencyBalances[1].", "combinedBalances[1].", "combinedBalances[1].", "combinedBalances[1]." };
            string[] keyWords = { "currency", "cash", "buyingPower", "maintenanceExcess", "isRealTime",
                            "currency", "cash", "buyingPower", "maintenanceExcess", "isRealTime"};

            string accountDataJson = Json("GET", command, accessToken, apiServer);
            return Parse.Json(jsonArray, accountDataJson, keyWords, keyWords.Length);
        }

        // Account Information.
        internal static string[] AccountInfo(string accessToken, string apiServer)
        {
            // Get account info.
            if (!string.IsNullOrEmpty(accessToken))
            {
                string[] jsonArray = { "accounts[0].", "accounts[0].", "accounts[0].", "userId" };
                string[] keyWords = { "type", "number", "status", "" };

                string accountDataJson = Json("GET", "V1/accounts", accessToken, apiServer);
                return Parse.Json(jsonArray, accountDataJson, keyWords, keyWords.Length);
            }
            return null;
        }

        /// <summary>
        /// Create Get candlestick data.
        /// </summary>
        /// <returns></returns>
        internal static double[,] candlestickData(string accessToken, string apiServer, int symbolId, int length, int period)
        {
            int endMinute = (int)Math.Floor((double)(DateTime.Now.Minute - (DateTime.Now.Minute % period)));
            int endHour = DateTime.Now.Hour;
            int startDay = DateTime.Now.Day;
            int startMin = DateTime.Now.Minute - (length * period);
            int startHour = DateTime.Now.Hour;
            string startTime = null;
            string endTime = null;
            string timeFrame = null;
            string candleDataJson = null;
            string[] keyWords = { "low", "high", "close", "volume" };

            // Find start hour.
            while (startMin < 0)
            {
                startMin += 60;
                startHour -= 1;

                if (startHour < 0)
                {
                    startHour += 24;
                    startDay--;
                }
            }

            // URL commands for 1st and current close prices.
            startTime = DateTime.Now.ToString("yyyy-MM-ddT" + startHour + ":" + startMin + ":00zzz");
            endTime = DateTime.Now.ToString("yyyy-MM-" + 00 + startDay + "T" + endHour + ":" + endMinute + ":00zzz");

            // Timeframe.
            switch (period)
            {
                case 1:
                    timeFrame = "-04%3A00&interval=OneMinute";
                    break;
                case 2:        
                    timeFrame = "-04%3A00&interval=TwoMinutes";
                    break;
                case 3:
                    timeFrame = "-04%3A00&interval=ThreeMinutes";
                    break;
                case 4:
                    timeFrame = "-04%3A00&interval=FourMinutes";
                    break;
                case 5:
                    timeFrame = "-04%3A00&interval=FiveMinutes";
                    break;
                case 10:
                    timeFrame = "-04%3A00&interval=TenMinutes";
                    break;
                case 15:
                    timeFrame = "-04%3A00&interval=FifteenMinutes";
                    break;
                case 20:
                    timeFrame = "-04%3A00&interval=TwentyMinutes";
                    break;
                case 30:
                    timeFrame = "-04%3A00&interval=HalfHour";
                    break;
                case 60:
                    timeFrame = "-04%3A00&interval=OneHour";
                    break;
                case 120:
                    timeFrame = "-04%3A00&interval=TwoHours";
                    break;

                default:
                    MessageBox.Show("ERROR: Please Report: invalid time frame");
                    return null;
            }

            // Request command.
            string command = "v1/markets/candles/" + symbolId + "?startTime=" + startTime + "-04%3A00&endTime=" + endTime + timeFrame;

            // Request data from server.
            if (startTime != null && endTime != null && timeFrame != null)
            {
                candleDataJson = Json("GET", command, accessToken, apiServer);
            }

            // Parse data.
            double[,] candleData = Parse.candlestickData(candleDataJson, keyWords, length);

            // Return data.
            return candleData;
        }

        // Request time.
        internal static int GetTime(string accessToken, string apiServer)
        {
            // Get time.
            while (true)
            {
                return Convert.ToInt(DateTime.Now.ToString("mss"));
            }
        }

        // Request data.
        internal static string Json(string method, string command, string accessToken, string apiServer)
        {
            string url = apiServer + command;
            string authorization = "Bearer " + accessToken;

            HttpWebResponse response = null;
            try
            {
                // Setup the Request.
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = method;
                request.Headers["Authorization"] = authorization;

                if (method == "POST")
                {
                    // Write data.
                    Stream getStream = request.GetRequestStream();
                    getStream.Close();
                }
                // Send Request & Get Response.
                response = (HttpWebResponse)request.GetResponse();

                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    // Get the Response Stream.
                    return reader.ReadLine();
                }
            }
            catch (WebException e)
            {
                // This exception will be raised if the server didn't return 200 - OK
                // Retrieve more information about the error.
                if (e.Response != null)
                {
                    using (HttpWebResponse err = (HttpWebResponse)e.Response)
                    {
                        MessageBox.Show("The server returned '{0}' with the status code '{1} ({2:d})'.",
                            err.StatusDescription + err.StatusCode + err.StatusCode);
                        return null;
                    }
                }
            }
            finally
            {
                if (response != null) { response.Close(); }
            }
            return null;
        }

        // Send Order request.
        internal static string Order(string authorization, string url, string action, int accountNumber, int symbolId, int quantity, double limitPrice, double stopPrice)
        {
            HttpWebResponse response = null;
            try
            {
                // Setup the Request.
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "text/plain; charset=UTF-8";
                request.Headers["Authorization"] = authorization;

                // Write data.
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    // Create Json to buy.
                    dynamic jsonObject = new JObject();
                    jsonObject.symbolId = symbolId;
                    jsonObject.quantity = quantity;
                    jsonObject.limitPrice = limitPrice;
                    jsonObject.orderType = "Limit";
                    jsonObject.timeInForce = "Day";
                    jsonObject.action = action;
                    jsonObject.primaryRoute = "AUTO";
                    jsonObject.secondaryRoute = "AUTO";

                    streamWriter.Write(jsonObject);
                }
                Stream postStream = request.GetRequestStream();
                postStream.Close();

                // Send Request & Get Response.
                response = (HttpWebResponse)request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    // Get the Response Stream.
                    return reader.ReadLine();
                }
            }
            catch (WebException e)
            {
                // This exception will be raised if the server didn't return 200 - OK
                // and retrieve more information about the error.
                if (e.Response != null)
                {
                    using (HttpWebResponse err = (HttpWebResponse)e.Response)
                    {
                        MessageBox.Show("The server returned '{0}' with the status code '{1} ({2:d})'.",
                            err.StatusDescription + err.StatusCode + err.StatusCode);
                    }
                }
            }
            finally
            {
                if (response != null) { response.Close(); }
            }
            return null;
        }

        internal static int OpenOrders(string accessToken, string apiServer, string symbol, int accountNumber)
        {
            Thread.Sleep(1000);
            try
            {
                string ordersJson = Json("GET", "v1/accounts/" + accountNumber + "/orders", accessToken, apiServer);
                return Parse.OpenOrders(ordersJson, symbol);
            }
            catch
            {
                return 0;
            }
        }

        internal static double[] Positions(string accessToken, string apiServer, string symbol, int accountNumber)
        {
            Thread.Sleep(1000);
            try
            {
                string positionJson = Json("GET", "v1/accounts/" + accountNumber + "/positions", accessToken, apiServer);
                return Parse.Positions(positionJson, symbol);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Quote ticker.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="apiServer"></param>
        /// <param name="symbolId"></param>
        /// <returns></returns>
        internal static string[] Quote(string accessToken, string apiServer, int symbolId)
        {
            try
            {
                string[] quoteJsonArray = { "quotes[0].", "quotes[0].", "quotes[0].", "quotes[0].", "quotes[0]." };
                string[] quoteKeyWords = { "lastTradePrice", "isHalted", "bidPrice", "askPrice", "volume" };
                string quoteJson = Request.Json("GET", "v1/markets/quotes/" + symbolId, accessToken, apiServer);
                return Parse.Json(quoteJsonArray, quoteJson, quoteKeyWords, quoteKeyWords.Length);
            }
            catch
            {
                return null;
            }
        }

        // Redeem refresh token for an access token.
        internal static string RedeemRefreshToken(string refreshToken)
        {
            string url = "https://practicelogin.questrade.com/oauth2/token?grant_type=refresh_token&refresh_token=" + refreshToken;

            HttpWebResponse response = null;
            try
            {
                // Setup the Request.
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";

                // Write data.
                Stream postStream = request.GetRequestStream();
                postStream.Close();

                // Send Request & Get Response.
                response = (HttpWebResponse)request.GetResponse();

                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    // Get the Response Stream.
                    return reader.ReadLine();
                }
            }
            catch (WebException e)
            {
                // This exception will be raised if the server didn't return 200 - OK
                // and retrieve more information about the error.
                if (e.Response != null)
                {
                    using (HttpWebResponse err = (HttpWebResponse)e.Response)
                    {
                        MessageBox.Show("The server returned '{0}' with the status code '{1} ({2:d})'.",
                            err.StatusDescription + err.StatusCode + err.StatusCode);
                    }
                }
            }
            finally
            {
                if (response != null) { response.Close(); }
            }
            return null;
        }

        /// <summary>
        /// Search for ticker.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="apiServer"></param>
        /// <param name="ticker"></param>
        /// <returns></returns>
        public static string[] Search(string accessToken, string apiServer, string ticker)
        {
            try
            {
                string[] jsonArray = { "symbols[0].", "symbols[0].", "symbols[0].", "symbols[0]." };
                string[] searchKeyWords = { "symbol", "symbolId", "isTradable", "isQuotable" };
                string quoteJson = Request.Json("GET", "v1/symbols/search?prefix=" + ticker, accessToken, apiServer);
                return Parse.Json(jsonArray, quoteJson, searchKeyWords, searchKeyWords.Length);
            }
            catch
            {
                return null;
            }
        }
    }

    /// <summary>
    /// Parse data.
    /// </summary>
    static class Parse
    {
        /// <summary>
        /// Parse historical data.
        /// </summary>
        /// <param name="json"></param>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        internal static double[,] candlestickData(string json, string[] keyWords, int length)
        {
            int startArray = 0;
            int good = 0;
            double[,] candleStickData = new double[length, 4];
            string stringData = null;
            bool failed = false;

            try
            {
                JObject jsonObject = JObject.Parse(json);

                // int length = (int)Math.Floor(((double)json.Length / 155));
                int arrLength = jsonObject["candles"].Count();

                /*
                if (length >= 10)
                    startArray = 12;
                else
                    startArray = length -1;
                */
                startArray = arrLength - 1;
                // Assign values to arrays.
                for (int k = 0; k < length; k++)
                {
                    // Assign values to array elements.
                    for (int j = 0; j < 4; j++)
                    {
                        if (startArray >= 0)
                        {
                            stringData = (String)jsonObject.SelectToken("candles[" + startArray + "]." + keyWords[j]);
                            if (stringData != null)
                            {
                                if (!Double.TryParse(stringData, out candleStickData[k, j]))
                                {
                                    failed = true;
                                }
                                else
                                {
                                    good++;
                                }
                            }
                            else
                                failed = true;
                        }
                        else if (startArray < 0 || failed == true)
                        {
                            candleStickData[k, j] = 0;
                            failed = false;
                        }
                    }
                    startArray--;
                }

                if (good > 0)
                    return candleStickData;
                else
                    return null;
            }
            catch
            {
                MessageBox.Show("returning null: Historical data parse");
                return candleStickData;
            }
        }

        /// <summary>
        /// Parses a JSON into an array.
        /// </summary>
        /// <param name="json"></param>
        /// <returns>Array</returns>
        internal static int OpenOrders(string json, string symbol)
        {
            int i = 0;
            int[] data = new int[2];
            string stringData = null;
            string posSymbol = null;
            string[] keyWords = { "symbol", "openQuantity" };

            // Retrieve and Return the Authorization info.
            JavaScriptSerializer ser = new JavaScriptSerializer();

            JObject jsonObject = JObject.Parse(json);

            // Read Json until null.
            do
            {
                for (int j = 0; j < 2; j++)
                {
                    stringData = (String)jsonObject.SelectToken("positions[" + i + "]." + keyWords[j]);
                    if (stringData != null)
                    {
                        if (j == 0)
                        {
                            posSymbol = stringData;
                        }
                        else
                        {
                            data[j] = Convert.ToInt(stringData);
                        }
                    }
                }
                if (posSymbol == symbol)
                {
                    return data[1];
                }
                i++;
            }
            while (stringData != null);
            return data[1];
        }

        /// <summary>
        /// Parses a JSON into an array.
        /// </summary>
        /// <param name="json"></param>
        /// <returns>Array</returns>
        internal static double[] Positions(string json, string symbol)
        {
            int i = 0;
            double[] data = new double[4];
            string stringData = null;
            string posSymbol = null;
            string[] keyWords = { "symbol", "openQuantity", "averageEntryPrice", "closedPnl" };

            // Retrieve and Return the Authorization info.
            JavaScriptSerializer ser = new JavaScriptSerializer();

            JObject jsonObject = JObject.Parse(json);        

            // Read Json until null.
            do
            {
                for (int j = 0; j < 4; j++)
                {
                    stringData = (String)jsonObject.SelectToken("positions[" + i + "]." + keyWords[j]);
                    if (stringData != null)
                    {
                        if (j == 0)
                        {
                            posSymbol = stringData;
                        }
                        else
                        {
                            if (!Double.TryParse(stringData, out data[j]))
                                MessageBox.Show("Could not convert data" + j);
                        }
                    }
                }
                if (posSymbol == symbol)
                {
                    return data;
                }
                i++;
            }
            while (stringData != null);
            return null;
        }

        /// <summary>
        /// Parses a JSON into an array.
        /// </summary>
        /// <param name="json"></param>
        /// <returns>Array</returns>
        internal static string[] Json(string[] jsonArray, string json, string[] keyWord, int length)
        {
            string[] data = new string[20];
            try
            {
                // Retrieve and Return the Authorization info.
                JavaScriptSerializer ser = new JavaScriptSerializer();

                if (jsonArray == null)
                {
                    for (int i = 0; i < length; i++)
                    {
                        Dictionary<string, object> x = (Dictionary<string, object>)ser.DeserializeObject(json);
                        data[i] = x[keyWord[i]].ToString();
                    }

                    // store refresh key info.
                    if (data[3] != null)
                        Store.RefreshToken(data[3]);
                }
                else
                {
                    JObject jsonObject = JObject.Parse(json);

                    for (int i = 0; i < length; i++)
                    {
                        data[i] = (string)jsonObject.SelectToken(jsonArray[i] + keyWord[i]);
                    }
                }
            }
            catch
            {

            }
            return data;
        }
    }

    internal class ParseData
    {
        public double[] balance = new double[8];

        // Update account balance.
        internal double[] Balance(string accessToken, string apiServer, int accountNumber)
        {
            // Account balance info.
            string[] accountBalance = Request.AccountBalance(accessToken, apiServer, accountNumber);

            // Canadian balance.
            if (!Double.TryParse(accountBalance[1], out balance[0]))
               MessageBox.Show("Could not convert cad balance");
            if (!Double.TryParse(accountBalance[2], out balance[1]))
                MessageBox.Show("Could not convert cad com balance");
            if (!Double.TryParse(accountBalance[3], out balance[2]))
                MessageBox.Show("Could not convert cad buying power");

            // US balance.
            if (!Double.TryParse(accountBalance[6], out balance[3]))
                MessageBox.Show("Could not convert usd balance");
            if (!Double.TryParse(accountBalance[7], out balance[4]))
                MessageBox.Show("Could not convert usd com balance");
            if (!Double.TryParse(accountBalance[8], out balance[5]))
                MessageBox.Show("Could not convert balance");

            //"currency", "cash", "buyingPower", "maintenanceExcess", "isRealTime",
            //"currency", "cash", "buyingPower", "maintenanceExcess", "isRealTime"
            return balance;
        }
    }

    static class Store
    {
        static private string xmlFilePath = "C:\\Programming\\C#\\QuestradeAPI\\CSharp\\AlgoTrader\\Practice Account\\";
        static private string debugging = "C:\\Programming\\C#\\QuestradeAPI\\CSharp\\AlgoTrader\\Practice Account\\Strategies\\Moving Averages\\Daytrade\\5-min-10,5\\Debugging\\";

        // Storage with XML file.
        internal static void RefreshToken(string refreshToken)
        {
            XmlTextWriter Xwriter = new XmlTextWriter(xmlFilePath + "Account 1 data\\data.xml", Encoding.UTF8);
            Xwriter.WriteStartElement("refresh_token");
            Xwriter.WriteString(refreshToken);
            Xwriter.WriteEndElement();
            Xwriter.Close();
        }

        // Storage with XML file.
        internal static void EndTime(DateTime time, double profit)
        {
            XmlTextWriter Xwriter = new XmlTextWriter(debugging + "time.xml", Encoding.UTF8);
            Xwriter.WriteStartElement("time");
            Xwriter.WriteString(time.ToString());
            Xwriter.WriteEndElement();
            Xwriter.WriteStartElement("profit");
            Xwriter.WriteString(profit.ToString());
            Xwriter.WriteEndElement();
            Xwriter.Close();
        }

        // Storage with XML file.
        internal static void Empty(string symbol, int empty)
        {
            int time = Convert.ToInt(DateTime.Now.ToString("HHmm"));
            string folder = DateTime.Now.ToString("yyyy - MM - dd");

            Directory.CreateDirectory(debugging + folder);

            XmlTextWriter Xwriter = new XmlTextWriter(debugging + folder + "\\" + "empty-" + time + ".xml", Encoding.UTF8);
            Xwriter.WriteStartElement("symbol");
            Xwriter.WriteString(symbol);
            Xwriter.WriteEndElement();
            Xwriter.WriteStartElement("empty");
            Xwriter.WriteString(empty.ToString());
            Xwriter.WriteEndElement();
            Xwriter.Close();
        }

        internal static void Probability(int goodTrades, int totalTrades)
        {
            int time = Convert.ToInt(DateTime.Now.ToString("HHmm"));
            string folder = DateTime.Now.ToString("yyyy - MM - dd") + "probability";

            Directory.CreateDirectory(debugging + folder);

            XmlTextWriter Xwriter = new XmlTextWriter(debugging + folder + "\\" + "probability-" + time + ".xml", Encoding.UTF8);
            Xwriter.WriteStartElement("good");
            Xwriter.WriteString(goodTrades.ToString());
            Xwriter.WriteEndElement();
            Xwriter.WriteStartElement("total");
            Xwriter.WriteString(totalTrades.ToString());
            Xwriter.WriteEndElement();
            Xwriter.Close();
        }

        // Storage with XML file.
        internal static void Profit(double profit)
        {
            int time = Convert.ToInt(DateTime.Now.ToString("HHmm"));
            string folder = DateTime.Now.ToString("yyyy - MM - dd") + "profit";

            Directory.CreateDirectory(debugging + folder);

            XmlTextWriter Xwriter = new XmlTextWriter(debugging + folder + "\\" + "profit-" + time + ".xml", Encoding.UTF8);
            Xwriter.WriteStartElement("time");
            Xwriter.WriteString(DateTime.Now.ToString());
            Xwriter.WriteEndElement();
            Xwriter.WriteStartElement("profit");
            Xwriter.WriteString(profit.ToString());
            Xwriter.WriteEndElement();
            Xwriter.Close();
        }

        // Retrive data from XML file.
        internal static string Retrieve()
        {
            XmlDocument xDoc = new XmlDocument();

            try
            {
                xDoc.Load("C:\\Programming\\C#\\QuestradeAPI\\CSharp\\AlgoTrader\\Practice Account\\Account 1 data\\data.xml");
                return xDoc.SelectSingleNode("refresh_token").InnerText;
            }
            catch
            {
                MessageBox.Show("Error retrieving refresh token");
            }
            return null;
        }

        private static string Hash(string text)
        {
            return null;
        }
    }

    /// <summary>
    /// For Conversions
    /// </summary>
    class Convert
    {
        /// <summary>
        /// Converts a string to an int
        /// </summary>
        internal static int ToInt(string str)
        {
            try
            {
                return Int32.Parse(str);
            }
            catch (FormatException e)
            {
                MessageBox.Show("Input string is not a sequence of digits.");
            }
            catch (OverflowException e)
            {
                MessageBox.Show("The number cannot fit in an Int32.");
            }
            catch
            {
                MessageBox.Show("Could not convert " + str + "to int.");
            }
            return 0;
        }
    }
}
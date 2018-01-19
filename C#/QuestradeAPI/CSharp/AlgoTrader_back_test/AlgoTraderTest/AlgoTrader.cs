// .Net Libraries
using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Xml;
using System.Text;
using System.Speech.Synthesis;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Linq;
using Newtonsoft.Json;

namespace AlgorithmicTrader
{
    /// <summary>
    /// An Algorithmic trader that uses The Questrade API
    /// </summary>
    internal class AlgoTrader
    {
        /// <summary>
        /// Runs when program is first started
        /// </summary>
        private static string[] Start()
        {
            // variables
            string refreshToken = null;
            string[] authorizationKeyWords = { "access_token", "token_type", "expires_in", "refresh_token", "api_server" };

            // get refresh token
            refreshToken = Secure.Retrieve();
            while (String.IsNullOrEmpty(refreshToken))
            {
                Console.WriteLine("Please enter a refresh token: ");
                refreshToken = Console.ReadLine();
                Console.Clear();
            }
            // use refresh token to get authorization data
            if (!String.IsNullOrEmpty(refreshToken))
            {
                // parse data
                string authorizedDataJson = Request.RedeemRefreshToken(refreshToken);
                return Parse.Json(null, authorizedDataJson, authorizationKeyWords, 5);
            }
            else
            {
                Console.WriteLine("Refresh Token error");
                return null;
            }
        }

        /// <summary>
        /// Main Method program entry point
        /// </summary>
        /// <param name="args">No Arguments</param>
        internal static void Main()
        {
            int accountNumber = 0;
            string accessToken = null;
            string apiServer = null;

            Strategy strategy = new Strategy();
            Update update = new Update();

            string[] authorizedData = Start();
            accessToken = authorizedData[0];
            apiServer = authorizedData[4];

            string[] accountData = Request.AccountInfo(accessToken, apiServer);
            accountNumber = Convert.ToInt(accountData[1]);
            string accountStatus = accountData[2];

            Thread getBalance = new Thread(() => update.Balance(accessToken, apiServer, accountNumber));

            // Canadian.
            Thread hou = new Thread(() => strategy.VolumeSpreadAnalysis(authorizedData, "HOU.TO"));
            Thread td = new Thread(() => strategy.VolumeSpreadAnalysis(authorizedData, "TD.TO"));
            Thread fm = new Thread(() => strategy.VolumeSpreadAnalysis(authorizedData, "FM.TO"));
            Thread hod = new Thread(() => strategy.VolumeSpreadAnalysis(authorizedData, "HOD.TO"));
            Thread cpg = new Thread(() => strategy.VolumeSpreadAnalysis(authorizedData, "CPG.TO"));

            // U.S.
            Thread msft = new Thread(() => strategy.VolumeSpreadAnalysis(authorizedData, "MSFT"));
            Thread tvix = new Thread(() => strategy.VolumeSpreadAnalysis(authorizedData, "TVIX"));
            Thread mu = new Thread(() => strategy.VolumeSpreadAnalysis(authorizedData, "MU"));
            Thread f = new Thread(() => strategy.VolumeSpreadAnalysis(authorizedData, "F"));
            Thread aapl = new Thread(() => strategy.VolumeSpreadAnalysis(authorizedData, "AAPL"));
            Thread tsla = new Thread(() => strategy.VolumeSpreadAnalysis(authorizedData, "TSLA"));
            Thread dis = new Thread(() => strategy.VolumeSpreadAnalysis(authorizedData, "DIS"));
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output. 
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.
            synth.Speak("Press any key to YOLO!");

            Console.WriteLine();
            Console.WriteLine("Press any key to YOLO!");
            Console.ReadKey();

            // Trade STOCKS.
            //hou.Start();
            // Thread.Sleep(1000);
            //td.Start();
            // Thread.Sleep(1000);
            //fm.Start();
            // Thread.Sleep(1000);
            //hod.Start();
            // Thread.Sleep(1000);
            //cpg.Start();
            //gm.Start();
            //msft.Start();
            //Thread.Sleep(1000);
            //tvix.Start();
            //Thread.Sleep(1000);
            //mu.Start();
            //Thread.Sleep(1000);
            //f.Start();
            Thread.Sleep(1000);
            aapl.Start();
            // tsla.Start();
            // dis.Start();   
        }
    }

    /// <summary>
    /// Algorithmic strategy.
    /// </summary>
    internal class Strategy
    {
        public int accountNumber = 0;
        public double cadBalance = 0;
        public double usdBalance = 0;
        public double cadComBalance = 0;
        public double usdComBalance = 0;
        public double cadBuyingPower = 0;
        public double usdBuyingPower = 0;
        public double cadME = 0;
        public double usdME = 0;
        public string cadCurrency = null;
        public string usdCurrency = null;
        public string cadIsReal = null;
        public string usdIsReal = null;
        public string accessToken = null;
        public string apiServer = null;

        /// <summary>
        /// Main strategy.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="apiServer"></param>
        /// <param name="accountNumber"></param>
        /// <param name="buyingPower"></param>
        /// <param name="maintenanceExcess"></param>
        public void VolumeSpreadAnalysis(string[] authorizedData, string symbol)
        {
            Signal signal = new Signal();
            double[,] candleSticks;

            accessToken = authorizedData[0];
            apiServer = authorizedData[4];

            Console.WriteLine(accessToken);
            // Get account data.
            string[] accountData = Request.AccountInfo(accessToken, apiServer);
            accountNumber = Convert.ToInt(accountData[1]);
            string accountStatus = accountData[2];

            // Run strategy.
            while (true)
            {
                // Search for symbol id. "symbol", "symbolId", "isTradable", "isQuotable"
                string[] searchData = Request.Search(accessToken, apiServer, symbol);
                string searchSymbol = searchData[0];
                int symbolId = Convert.ToInt(searchData[1]);

                // Get candlestick data for past 15 minutes.
                Thread.Sleep(500);
                Console.Clear();
                //candleSticks = Request.candlestickData(accessToken, apiServer, symbolId);
                candleSticks = Request.historicalData(accessToken, apiServer, symbolId);

                //  Candlesticks elements 0-3 "low", "high", "close", "volume"
                string[] candle = { "low", "high", "close", "volume" };

                if (candleSticks != null)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Array " + symbol + ": " + i);
                        for (int j = 0; j < 4; j++)
                        {
                            Console.WriteLine("Element: " + j);
                            Console.WriteLine(candle[j]);
                            Console.WriteLine(candleSticks[i, j]);
                        }
                    }
                }

                if (Double.IsNaN(0 / candleSticks[3, 3]))
                {
                    // Check if the last candle closed higher then the second one before it.
                    if (candleSticks[2, 2] > candleSticks[0, 2])
                    {
                        // If volume is lower than the two bars before it.
                        if (candleSticks[2, 3] < candleSticks[1, 3] && candleSticks[2, 3] < candleSticks[0, 3])
                        {
                            Console.WriteLine(symbol + " Sell signal!");
                            signal.Sell(accessToken, apiServer, symbol, accountNumber, symbolId);
                        }
                        // If volume is higher than the two bars before it.
                        else if (candleSticks[2, 3] > candleSticks[1, 3] && candleSticks[2, 3] > candleSticks[0, 3])
                        {
                            Console.WriteLine(symbol + " Buy signal!");
                            signal.Buy(accessToken, apiServer, symbol, accountNumber, symbolId);
                        }
                    }
                    // Check if the last candle closed lower than the second one before it.
                    else if (candleSticks[2, 2] < candleSticks[0, 2])
                    {
                        // if volume is lower than the two bars before it.
                        if (candleSticks[2, 3] < candleSticks[1, 3] && candleSticks[2, 3] < candleSticks[0, 3])
                        {
                            Console.WriteLine(symbol + " Buy signal!");
                            signal.Buy(accessToken, apiServer, symbol, accountNumber, symbolId);
                        }
                        // If volume is higher than the two bars before it.
                        else if (candleSticks[2, 3] > candleSticks[1, 3] && candleSticks[2, 3] > candleSticks[0, 3])
                        {
                            Console.WriteLine(symbol + " Sell signal!");
                            signal.Sell(accessToken, apiServer, symbol, accountNumber, symbolId);
                        }
                    }
                }
                //Console.ReadKey();
                Thread.Sleep(5000);
            }
        }
    }

    internal class Signal
    {
        // Confirm buy signal.
        internal void Buy(string accessToken, string apiServer, string symbol, int accountNumber, int symbolId)
        {
            int volume1 = 0;
            int volume2 = 0;
            double price1 = 0;
            double price2 = 0;
            double askPrice = 0;
            double bidPrice = 0;
            bool buy = false;

            // Get price and volume.
            string[] quote = Request.Quote(accessToken, apiServer, symbolId);
            if (!Double.TryParse(quote[3], out askPrice))
                Console.WriteLine("Could not convert limit price: Buy0");
            if (!Double.TryParse(quote[2], out bidPrice))
                Console.WriteLine("Could not convert limit price: Buy1");

            price1 = Math.Round(((askPrice + bidPrice) / 2), 2);
            volume1 = Convert.ToInt(quote[4]);

            Thread.Sleep(5000);

            // Get price and volume 5 seconds later.
            quote = Request.Quote(accessToken, apiServer, symbolId);
            if (!Double.TryParse(quote[3], out askPrice))
                Console.WriteLine("Could not convert limit price: Buy0");
            if (!Double.TryParse(quote[2], out bidPrice))
                Console.WriteLine("Could not convert limit price: Buy1");

            price2 = Math.Round(((askPrice + bidPrice) / 2), 2);
            volume2 = Convert.ToInt(quote[4]);

            // Buy if the volume goes up when the price goes up.
            if (price1 < price2 && volume1 < volume2)
            {
                buy = true;
            }
            // Buy if the price goes down and the volume goes down.
            if (price1 > price2 && volume1 > volume2)
            {
                buy = true;
            }

            
            }
        }

        internal void Sell(string accessToken, string apiServer, string symbol, int accountNumber, int symbolId)
        {
            int volume1 = 0;
            int volume2 = 0;
            double price1 = 0;
            double price2 = 0;
            double askPrice = 0;
            double bidPrice = 0;
            bool sell = false;

            // Get price and volume.
            string[] quote = Request.Quote(accessToken, apiServer, symbolId);
            if (!Double.TryParse(quote[3], out askPrice))
                Console.WriteLine("Could not convert limit price: Buy0");
            if (!Double.TryParse(quote[2], out bidPrice))
                Console.WriteLine("Could not convert limit price: Buy1");

            price1 = Math.Round(((askPrice + bidPrice) / 2), 2);
            volume1 = Convert.ToInt(quote[4]);

            Thread.Sleep(5000);

            // Get price and volume 5 seconds later.
            quote = Request.Quote(accessToken, apiServer, symbolId);
            if (!Double.TryParse(quote[3], out askPrice))
                Console.WriteLine("Could not convert limit price: Buy0");
            if (!Double.TryParse(quote[2], out bidPrice))
                Console.WriteLine("Could not convert limit price: Buy1");

            price2 = Math.Round(((askPrice + bidPrice) / 2), 2);
            volume2 = Convert.ToInt(quote[4]);

            // Sell if the price goes up when the volume goes down.
            if (price1 < price2 && volume1 > volume2)
            {
                sell = true;
            }
            // Sell if the price goes down and the volume goes up.
            if (price1 > price2 && volume1 < volume2)
            {
                sell = true;
            }

            if (sell)
            {
                // Check for positions already open for stock.
                int quantity = Request.Positions(accessToken, apiServer, symbol, accountNumber);
                Console.WriteLine("quantity: " + quantity);
                if (quantity >= 0)
                {
                    // Check for orders already open.
                    int openOrders = Request.OpenOrders(accessToken, apiServer, symbol, accountNumber);
                    Console.WriteLine("Open orders: " + openOrders);
                    //Console.ReadKey();
                    if (openOrders <= 0)
                    {
                        // Check for buying power, unless covering long.
                        if (true)
                        {
                            Thread.Sleep(2000);
                            Order.Sell(accessToken, apiServer, symbol, accountNumber, quantity);
                        }
                    }
                }
            }
        }
    }

    // Display to the console.
    internal class Display
    {
        string[] accountBalance;

        internal void DisplayController(string[] balance)
        {
            while (true)
            {
                accountBalance = balance;
                Balance(balance);
                Thread.Sleep(1000);
            }
        }

        internal void Balance(string[] accountBalance)
        {
            if (accountBalance != null)
            {
                Console.Write("Hello2: ");
                // Canadian balance.
                Console.WriteLine(accountBalance[0]);
                Console.Write("Balance: ");
                Console.WriteLine(accountBalance[1]);
                Console.Write("Buying Power: ");
                Console.WriteLine(accountBalance[3]);
                Console.Write("Combined Balance: ");
                Console.WriteLine(accountBalance[2]);
                Console.Write("Combined Buying Power: ");
                Console.WriteLine(accountBalance[3]);
                Console.Write("Maintenance Excess: ");
                Console.WriteLine(accountBalance[4]);
                Console.Write("Realtime: ");
                Console.WriteLine(accountBalance[5]);
                Console.WriteLine();
                // US balance.
                Console.WriteLine(accountBalance[6]);
                Console.Write("Balance: ");
                Console.WriteLine(accountBalance[7]);
                Console.Write("Buying Power: ");
                Console.WriteLine(accountBalance[3]);
                Console.Write("Combined Balance: ");
                Console.WriteLine(accountBalance[8]);
                Console.Write("Combined Buying Power: ");
                Console.WriteLine(accountBalance[9]);
                Console.Write("Maintenance Excess: ");
                Console.WriteLine(accountBalance[10]);
                Console.Write("Realtime: ");
                Console.WriteLine(accountBalance[11]);
            }
        }
    }

    internal class Update
    {
        public double[] balance = new double[8];
        public string[] accountBalance;
        // Update account balance.
        internal void Balance(string accessToken, string apiServer, int accountNumber)
        {
            Display display = new Display();
            Thread updateBalance = new Thread(() => display.DisplayController(accountBalance));
            updateBalance.Start();

            Console.Clear();
            while (true)
            {
                // Account balance info.
                accountBalance = Request.AccountBalance(accessToken, apiServer, accountNumber);

                // Canadian balance.
                string cadCurrency = accountBalance[0];
                if (!Double.TryParse(accountBalance[1], out balance[0]))
                    Console.WriteLine("Could not convert cad balance");
                if (!Double.TryParse(accountBalance[2], out balance[1]))
                    Console.WriteLine("Could not convert cad com balance");
                if (!Double.TryParse(accountBalance[3], out balance[2]))
                    Console.WriteLine("Could not convert cad buying power");
                if (!Double.TryParse(accountBalance[4], out balance[3]))
                    Console.WriteLine("Could not convert me");
                string cadIsReal = accountBalance[5];

                // US balance.
                string usdCurrency = accountBalance[6];
                if (!Double.TryParse(accountBalance[7], out balance[4]))
                    Console.WriteLine("Could not convert usd balance");
                if (!Double.TryParse(accountBalance[8], out balance[5]))
                    Console.WriteLine("Could not convert usd com balance");
                if (!Double.TryParse(accountBalance[9], out balance[6]))
                    Console.WriteLine("Could not convert balance");
                if (!Double.TryParse(accountBalance[10], out balance[7]))
                    Console.WriteLine("Could not convert balance");
                string usdIsReal = accountBalance[11];

                Thread.Sleep(2000);
            }
            // make thread to display and pass double[]
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
        public static double[] Buy(string accessToken, string apiServer, string symbol, int accountNumber, int quantity)
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
                    Thread.Sleep(1000);
                    quote = Request.Quote(accessToken, apiServer, symbolId);
                    double limitPrice = 0;
                    double askPrice = 0;
                    double bidPrice = 0;
                    if (!Double.TryParse(quote[3], out askPrice))
                        Console.WriteLine("Could not convert limit price: Buy0");
                    if (!Double.TryParse(quote[2], out bidPrice))
                        Console.WriteLine("Could not convert limit price: Buy1");
                    try
                    {
                        Console.Clear();
                        if (quote[1] == "False")
                        {
                            // Get buy price, stop loss, quantity... 
                            limitPrice = Math.Round(((askPrice + bidPrice) / 2), 2);
                            orderData = BuyData(limitPrice, quantity);

                            quantity = (int)orderData[0];
                            double stopPrice = orderData[3];

                            if (quantity == 0)
                            {
                                return null;
                            }

                            Array.Resize<double>(ref orderData, 8);

                            // Send order.
                            string[] jsonArray = { "orders[0]." };
                            string[] searchKeyWords = { "id" };
                            string buy = Request.Order(authorization, url, action, accountNumber, symbolId, quantity, limitPrice, stopPrice);
                            string[] stringOrderData = Parse.Json(jsonArray, buy, searchKeyWords, searchKeyWords.Length);

                            if (stringOrderData[0] != null)
                            {
                                int orderId = Convert.ToInt(stringOrderData[0]);

                                // Check order.
                                Thread getStatus = new Thread(() => Status(accessToken, apiServer, accountNumber, orderId));
                                getStatus.Start();

                                int time = Request.GetTime(accessToken, apiServer);
                                int current = 0;

                                while (getStatus.IsAlive)
                                {
                                    Thread.Sleep(1000);
                                    current = Request.GetTime(accessToken, apiServer);
                                    if ((current - time) > 30)
                                    {
                                        // Cancel order.
                                        Console.WriteLine("Cancel");
                                        Cancel(accessToken, apiServer, accountNumber, orderId);
                                        getStatus.Abort();
                                        Console.Beep();
                                        Console.Beep();
                                        Console.Beep();
                                        break;
                                    }
                                }

                                Console.Beep(500, 50);

                                if (!Double.TryParse(stringOrderData[0], out orderData[4]))
                                    Console.WriteLine("Could not convert order id");

                                orderData[5] = limitPrice;
                                orderData[6] = askPrice;
                                orderData[7] = bidPrice;
                                // Return order data.
                                return orderData;
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Could not buy " + symbol);
                        return null;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Create order to sell.
        /// </summary>
        /// <returns></returns>
        public static double[] Sell(string accessToken, string apiServer, string symbol, int accountNumber, int quantity)
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
                    try
                    {
                        Thread.Sleep(1000);
                        quote = Request.Quote(accessToken, apiServer, symbolId);
                        double limitPrice = 0;
                        double limitHolder = 0;
                        if (!Double.TryParse(quote[0], out limitPrice))
                            Console.WriteLine("Could not convert limit price: sell0");
                        if (!Double.TryParse(quote[1], out limitHolder))
                            Console.WriteLine("Could not convert limit price: sell1");

                        Console.Clear();
                        if (quote[1] == "False")
                        {
                            // Get buy price, stop loss, quantity...
                            double[] orderData = SellData(limitPrice, quantity);
                            quantity = (int)orderData[0];

                            Console.WriteLine("quantity: " + quantity);

                            if (quantity == 0)
                            {
                                return null;
                            }

                            Array.Resize<double>(ref orderData, 4);

                            limitPrice = Math.Round(((limitPrice + limitHolder) / 2), 2);
                            orderData[3] = limitPrice;
                            Thread.Sleep(2000);
                            // Send order.
                            string[] jsonArray = { "orders[0]." };
                            string[] searchKeyWords = { "id" };
                            string sell = Request.Order(authorization, url, action, accountNumber, symbolId, quantity, limitPrice, orderData[2]);
                            string[] stringOrderData = Parse.Json(jsonArray, sell, searchKeyWords, searchKeyWords.Length);


                            if (stringOrderData[0] != null)
                            {
                                int orderId = Convert.ToInt(stringOrderData[0]);

                                // Check order.
                                Thread getStatus = new Thread(() => Status(accessToken, apiServer, accountNumber, orderId));
                                getStatus.Start();

                                int time = Request.GetTime(accessToken, apiServer);
                                int current = 0;

                                while (getStatus.IsAlive)
                                {
                                    current = Request.GetTime(accessToken, apiServer);
                                    if ((current - time) > 30)
                                    {
                                        // Cancel order.
                                        Console.WriteLine("cancel Sell");
                                        Cancel(accessToken, apiServer, accountNumber, orderId);
                                        getStatus.Abort();
                                        Console.Beep();
                                        Console.Beep();
                                        Console.Beep();
                                    }
                                }
                                Console.Beep(500, 50);
                                // Return order data.
                                return orderData;
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error selling " + symbol + ". Order may or may not have been sent.");
                        return null;
                    }
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
        internal static void Status(string accessToken, string apiServer, int accountNumber, int orderId)
        {
            string[] jsonArray = { "orders[0].", "orders[0]." };
            string[] searchKeyWords = { "state", "side" };

            while (true)
            {
                string statusJson = Request.Json("GET", "v1/accounts/" + accountNumber + "/orders?ids=" + orderId, accessToken, apiServer);
                status = Parse.Json(jsonArray, statusJson, searchKeyWords, 2);

                // Check if order has been executed.
                if (status[0] != "Rejected")
                {
                    Console.WriteLine("not rejected");
                    // If order has been executed.
                    if (status[0] == "Executed")
                    {
                        Thread.CurrentThread.Abort();
                    }
                    // If order has been canceled.
                    else if (status[0] == "Canceled")
                    {
                        Thread.CurrentThread.Abort();
                    }
                    // If order has been canceled.
                    else if (status[0] == "Failed")
                    {
                        Thread.CurrentThread.Abort();
                    }
                }
                else
                {
                    // Cancel order if it's rejected.
                    orderId = Cancel(accessToken, apiServer, accountNumber, orderId);
                }
                Thread.Sleep(5000);
            }
        }

        /// <summary>
        /// Data for buy order.
        /// </summary>
        /// <param name="limitPrice"></param>
        /// <returns></returns>
        private static double[] BuyData(double limitPrice, int quantity)
        {
            double[] buyData = new double[4];
            try
            {
                Console.WriteLine("quantity" + quantity);

                // Calculate amount to buy, if none owned.
                if (quantity == 0)
                {
                    // Quantity.
                    buyData[0] = 5500 / limitPrice;
                    buyData[0] = Math.Round(buyData[0]);
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
                }

                //Console.WriteLine("quantity: " + buyData[0]);
                // Commission.
                buyData[1] = ((buyData[0] / 100) >= 4.95) ? (buyData[0] / 100) : 4.95;
                //Console.WriteLine("Commission: " + buyData[1]);
                // Gross cost, price + commission.
                buyData[2] = (buyData[0] * limitPrice) + (buyData[1] * 2);
                //Console.WriteLine("Gross Cost: " + buyData[2]);
                //Stop limit.
                buyData[3] = Math.Round(limitPrice - (limitPrice * 0.015), 2);
                Console.WriteLine("Stop limit: " + buyData[3]);

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
        private static double[] SellData(double limitPrice, int quantity)
        {
            double[] sellData = new double[3]; ;

            if (quantity == 0)
            {
                // Quantity.
                sellData[0] = 5500 / limitPrice;
                sellData[0] = Math.Round(sellData[0]);
            }
            else if (quantity > 0)
            {
                sellData[0] = quantity;
            }
            else
            {
                sellData[0] = 0;
            }

            // Gross profit.
            sellData[1] = quantity * limitPrice;
            // Stop price.
            sellData[2] = Math.Round((limitPrice + (limitPrice * 0.005)), 2);

            Console.WriteLine("quantity" + quantity);

            return sellData;
        }
    }

    /// <summary>
    /// C
    /// </summary>
    internal static class calculate
    {
        public static double WeightedMovingAverage(double[] prices)
        {
            double wma = 0;
            int num = 0;
            try
            {
                for (int i = prices.Length; i > 0; i--)
                {
                    wma = wma + prices[i - 1] * i;
                    num += i;
                }
                wma = wma / num;

                return wma;
            }
            catch
            {
                Console.WriteLine("Could not Calculate Weighted Moving Average");
                return 0;
            }
        }

        public static double Momentum(double[] prices)
        {
            double mom = prices[1] - prices[0];

            if (mom < 0)
            {
                mom *= -1;
                mom = Math.Round(mom, 5);
                return mom *= -1;

            }
            else
            {
                return Math.Round(mom, 3);
            }
        }
    }

    /// <summary>
    /// Send and recieve data to questrade.
    /// </summary>
    internal static class Request
    {
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
                        Console.WriteLine("The server returned '{0}' with the status code '{1} ({2:d})'.",
                          err.StatusDescription, err.StatusCode, err.StatusCode);
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
                    Console.WriteLine("limitPrice: " + limitPrice);
                    Console.WriteLine("stopPrice: " + stopPrice);
                    // Create Json to buy.
                    dynamic jsonObject = new JObject();
                    jsonObject.symbolId = symbolId;
                    jsonObject.quantity = quantity;

                    /*
                    if (action == "Buy")
                    {
                        jsonObject.limitPrice = limitPrice;
                        jsonObject.orderType = "Limit";
                    }
                    else
                    {
                        //jsonObject.stopPrice = stopPrice;
                        //jsonObject.limitPrice = limitPrice;
                        jsonObject.orderType = "Market";
                    }*/
                    jsonObject.stopPrice = stopPrice;
                    jsonObject.limitPrice = limitPrice;
                    jsonObject.orderType = "StopLimit";
                    jsonObject.timeInForce = "Day";
                    jsonObject.action = action;
                    jsonObject.primaryRoute = "AUTO";
                    jsonObject.secondaryRoute = "AUTO";

                    //Console.WriteLine(jsonObject);
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
                        Console.WriteLine("The server returned '{0}' with the status code '{1} ({2:d})'.",
                          err.StatusDescription, err.StatusCode, err.StatusCode);
                    }
                }
            }
            finally
            {
                if (response != null) { response.Close(); }
            }
            return null;
        }

        internal static string[] AccountInfo(string accessToken, string apiServer)
        {
            // get account info
            if (!string.IsNullOrEmpty(accessToken))
            {
                string[] jsonArray = { "accounts[0].", "accounts[0].", "accounts[0].", "userId" };
                string[] keyWords = { "type", "number", "status", "" };

                string accountDataJson = Json("GET", "V1/accounts", accessToken, apiServer);
                return Parse.Json(jsonArray, accountDataJson, keyWords, keyWords.Length);
            }
            return null;
        }

        internal static string[] AccountBalance(string accessToken, string apiServer, int accountNumber)
        {
            // get account balance
            string command = "v1/accounts/" + accountNumber + "/balances";
            string[] jsonArray = { "combinedBalances[0].", "perCurrencyBalances[0].", "combinedBalances[0].", "combinedBalances[0].", "combinedBalances[0].", "combinedBalances[0].",
                                "combinedBalances[1].", "perCurrencyBalances[1].", "combinedBalances[1].", "combinedBalances[1].", "combinedBalances[1].", "combinedBalances[1]." };
            string[] keyWords = { "currency", "cash", "cash", "buyingPower", "maintenanceExcess", "isRealTime",
                                "currency", "cash", "cash", "buyingPower", "maintenanceExcess", "isRealTime"};

            string accountDataJson = Json("GET", command, accessToken, apiServer);
            return Parse.Json(jsonArray, accountDataJson, keyWords, keyWords.Length);
        }

        internal static int GetTime(string accessToken, string apiServer)
        {
            // Get time.
            while (true)
            {
                return Convert.ToInt(DateTime.Now.ToString("mss"));
            }
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

        internal static int Positions(string accessToken, string apiServer, string symbol, int accountNumber)
        {
            Thread.Sleep(1000);
            try
            {
                string positionJson = Json("GET", "v1/accounts/" + accountNumber + "/positions", accessToken, apiServer);
                return Parse.Positions(positionJson, symbol);
            }
            catch
            {
                return 0;
            }
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

        /// <summary>
        /// Create Get candlestick data.
        /// </summary>
        /// <returns></returns>
        internal static double[,] candlestickData(string accessToken, string apiServer, int symbolId)
        {
            Thread.Sleep(100);
            string[] keyWords = { "low", "high", "close", "volume" };

            // first candle start time minutes.
            int startMin = ((int)Math.Floor(((double)(DateTime.Now.Minute - 15) / 5)) * 5);
            int startHour = DateTime.Now.Hour;

            // if hour has passed correct for start minutes being negative.
            if (startMin < 0)
            {
                startMin += 60;
                startHour -= 1;
            }

            // Most recent closed time.
            string currentStartDate = null;
            string current = null;

            int currMin = ((int)Math.Floor(((double)DateTime.Now.Minute / 5))) * 5;

            // URL commands for 1st and current close prices.
            currentStartDate = DateTime.Now.ToString("yyyy-MM-ddT" + startHour + ":" + startMin + ":00zzz");
            current = DateTime.Now.ToString("yyyy-MM-ddTHH:" + currMin + ":00zzz");

            string command = "v1/markets/candles/" + symbolId + "?startTime=" + currentStartDate + "-04%3A00&endTime=" + current + "-04%3A00&interval=FiveMinutes";

            // Request data from server.
            string candleDataJson = Json("GET", command, accessToken, apiServer);

            // Parse data.
            double[,] candleData = Parse.candlestickData(candleDataJson, keyWords);

            // Return data.
            return candleData;
        }

        /// <summary>
        /// Create Get historical data.
        /// </summary>
        /// <returns></returns>
        internal static double[,] historicalData(string accessToken, string apiServer, int symbolId)
        {
            Thread.Sleep(100);
            string[] keyWords = { "low", "high", "close", "volume" };

            string start = "2015-05-01T09%3A30";
            string end = "2015-08-19T16%3A00";

            string command = "v1/markets/candles/" + symbolId + "?startTime=" + start + "-04%3A00&endTime=" + end + "-04%3A00&interval=FiveMinutes";
            //Console.WriteLine(command);
            //Console.ReadKey();
            // Request data from server.
            string candleDataJson = Json("GET", command, accessToken, apiServer);

            // Parse data.
            double[,] candleData = Parse.candlestickData(candleDataJson, keyWords);

            // Return data.
            return candleData;
        }

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
                        Console.WriteLine("The server returned '{0}' with the status code '{1} ({2:d})'.",
                          err.StatusDescription, err.StatusCode, err.StatusCode);
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
    }

    static class Parse
    {
        /// <summary>
        /// Parses a JSON into an array.
        /// </summary>
        /// <param name="json"></param>
        /// <returns>Array</returns>
        internal static int Positions(string json, string symbol)
        {
            int i = 0;
            int[] data = new int[2];
            string stringData = null;
            string posSymbol = null;
            string[] keyWords = { "symbol", "openQuantity" };

            // Retrieve and Return the Authorization info.
            JavaScriptSerializer ser = new JavaScriptSerializer();

            JObject jsonObject = JObject.Parse(json);
            // Console.WriteLine(jsonObject);

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
            // Console.WriteLine(jsonObject);

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
        /// Parse historical data.
        /// </summary>
        /// <param name="json"></param>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        internal static double[,] candlestickData(string json, string[] keyWords)
        {
            string stringData = null;
            double[] candleStick = new double[4];
            double[,] candleStickData = new double[4, 4];
            int i = 0;

            try
            {
                JObject jsonObject = JObject.Parse(json);
                //Console.WriteLine(jsonObject);
                //Console.ReadKey();
                //Console.Clear();              

                // Assign values to arrays.
                for (int k = 0; k < 3; k++)
                {
                    // Assign values to array elements.
                    for (int j = 0; j < 4; j++)
                    {
                        stringData = (String)jsonObject.SelectToken("candles[" + k + "]." + keyWords[j]);
                        if (stringData != null)
                        {
                            if (!Double.TryParse(stringData, out candleStickData[k, j]))
                                Console.WriteLine("Could not convert limit price: phData");
                        }
                    }
                }
                return candleStickData;
            }
            catch
            {
                Console.WriteLine("returning null: Historical data parse");
                return candleStickData;
            }
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
                        //Console.WriteLine(keyWord[i] + ": " + data[i]);
                    }

                    // store refresh key info.
                    if (data[3] != null)
                        Secure.Store(data[3]);
                }
                else
                {
                    JObject jsonObject = JObject.Parse(json);
                    //Console.WriteLine(jsonObject);
                    //Console.ReadKey();
                    for (int i = 0; i < length; i++)
                    {
                        data[i] = (string)jsonObject.SelectToken(jsonArray[i] + keyWord[i]);
                        //Console.WriteLine(keyWord[i] + ": " + data[i]);
                    }
                }
            }
            catch
            {

            }
            return data;
        }
    }

    static class Secure
    {
        // Storage with XML file.
        internal static void Store(string refreshToken)
        {
            XmlTextWriter Xwriter = new XmlTextWriter("C:\\Applications\\QuestradeAPI\\CSharp\\AlgoTrader\\AlgoTraderTest\\data.xml", Encoding.UTF8);
            Xwriter.WriteStartElement("refresh_token");
            Xwriter.WriteString(refreshToken);
            Xwriter.WriteEndElement();
            Xwriter.Close();
        }

        // Retrive data from XML file.
        internal static string Retrieve()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("C:\\Applications\\QuestradeAPI\\CSharp\\AlgoTrader\\AlgoTraderTest\\data.xml");
            try
            {
                return xDoc.SelectSingleNode("refresh_token").InnerText;
            }
            catch
            {
                Console.WriteLine("Error retrieving refresh token");
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
                Console.WriteLine("Input string is not a sequence of digits.");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("The number cannot fit in an Int32.");
            }
            catch
            {
                Console.WriteLine("Could not convert " + str + "to int.");
            }
            return 0;
        }
    }
}


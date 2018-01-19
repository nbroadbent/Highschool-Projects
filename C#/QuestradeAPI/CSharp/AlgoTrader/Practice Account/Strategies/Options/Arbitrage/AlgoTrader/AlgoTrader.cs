﻿// .Net Libraries
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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Linq;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgorithmicTrader
{
    /// <summary>
    /// An Algorithmic trader that uses The Questrade API
    /// </summary>
    internal class AlgoTrader
    {
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);
        /// <summary>
        /// Runs when program is first started
        /// </summary>
        private static string[] Start()
        {
            // variables
            string refreshToken = null;
            string[] authorizationKeyWords = { "access_token", "token_type", "expires_in", "refresh_token", "api_server" };

            // get refresh token
            refreshToken = Store.Retrieve();
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
            int goodTrades = 0;
            int totalTrades = 0;
            int powerDown = 1;
            int accountNumber = 0;
            double profit = 0;
            double oldProfit = 0;
            double profitGoal = 1000;
            string apiServer = null;
            string accessToken = null;
            DateTime time = DateTime.Now;

            Display display = new Display();
            Strategy strategy = new Strategy();
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output. 
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.
            //synth.Speak("Press any key to YOLO!");

            //Console.WriteLine();
            //Console.WriteLine("Press any key to YOLO!");
            //Console.ReadKey();

            // Get authorization data.
            string[] authorizedData = Start();
            accessToken = authorizedData[0];
            apiServer = authorizedData[4];

            // Get account data.
            string[] accountData = Request.AccountInfo(accessToken, apiServer);
            accountNumber = Convert.ToInt(accountData[1]);
            string accountStatus = accountData[2];
            
            // Get account balance before trading.
            string[] balance = Request.AccountBalance(accessToken, apiServer, accountNumber);

            // Display.
            Thread displayData = new Thread(() => display.DisplayController(accessToken, apiServer, balance, accountNumber, profit, profitGoal, time));            
            // Canadian.
            Thread hou = new Thread(() => strategy.Trade(authorizedData, "HOU.TO"));
            Thread td = new Thread(() => strategy.Trade(authorizedData, "TD.TO"));
            Thread bns = new Thread(() => strategy.Trade(authorizedData, "BNS.TO"));
            Thread fm = new Thread(() => strategy.Trade(authorizedData, "FM.TO"));
            Thread hod = new Thread(() => strategy.Trade(authorizedData, "HOD.TO"));
            Thread cpg = new Thread(() => strategy.Trade(authorizedData, "CPG.TO"));
            Thread ry = new Thread(() => strategy.Trade(authorizedData, "RY.TO"));            
            // U.S.
            Thread msft = new Thread(() => strategy.Trade(authorizedData, "MSFT"));
            Thread tvix = new Thread(() => strategy.Trade(authorizedData, "TVIX"));
            Thread mu = new Thread(() => strategy.Trade(authorizedData, "MU"));
            Thread f = new Thread(() => strategy.Trade(authorizedData, "F"));
            Thread aapl = new Thread(() => strategy.Trade(authorizedData, "AAPL"));
            Thread tsla = new Thread(() => strategy.Trade(authorizedData, "TSLA"));
            Thread dis = new Thread(() => strategy.Trade(authorizedData, "DIS"));           

            // Check if computer should power down when done trading.
            do
            {
                try
                {
                    Console.WriteLine("Power down computer when over? [0] = true, [1] = false");
                    powerDown = Convert.ToInt(Console.ReadLine());
                    int intCheck = powerDown;
                }
                catch
                {
                    Console.WriteLine("Please enter an integer");
                }
            } while (powerDown != 0 && powerDown != 1);
            Console.Clear();
            
            // Trade STOCKS.
            tvix.Start();

            // Update positions for stocks being traded.
            double[] positionsProfit = Request.Positions(accessToken, apiServer, "TVIX", accountNumber);

            if (positionsProfit != null)
            {
                // Parse position data.
                oldProfit = positionsProfit[3];
            }
            

            // Continue program.             
            while (true)
            {                
                // Update positions for stocks being traded.
                double[] positions = Request.Positions(accessToken, apiServer, "TVIX", accountNumber);
                
                if (positions != null)
                {                    
                    // Parse position data.
                    profit = positions[3];                  
                    
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

                    // Run display thread once closed.
                    if (!displayData.IsAlive)
                    {
                        // Display.
                        displayData = new Thread(() => display.DisplayController(accessToken, apiServer, balance, accountNumber, profit, profitGoal, time));
                        //displayData.Start();
                    }

                    // Shutdown Program if profit goal reached.
                    if (profit > profitGoal)
                    {
                        // Abort threads.
                        tvix.Abort();
                        displayData.Abort();

                        // Write down close time.
                        Store.EndTime(DateTime.Now, profit);

                        // Power down computer.
                        if (powerDown == 0)
                        {
                            SetSuspendState(true, true, true);
                        }
                        Environment.Exit(0);
                    }

                    // Shutdown program if thread closes.
                    if (!tvix.IsAlive)
                    {                        
                        // Abort threads.
                        displayData.Abort();

                        // Write down close time.
                        Store.EndTime(DateTime.Now, profit);

                        // Power down computer.
                        if (powerDown == 0)
                        {
                            SetSuspendState(true, true, true);
                        }
                        Environment.Exit(0);
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
        public int accountNumber = 0;
        public string accessToken = null;
        public string apiServer = null;

        private string trendSignal = null;

        public void Trade(string[] authorizedData, string symbol)
        {
            int quantity = 0;
            PrepareOrder signal = new PrepareOrder();
            accessToken = authorizedData[0];
            apiServer = authorizedData[4];

            // Get account data.
            string[] accountData = Request.AccountInfo(accessToken, apiServer);
            accountNumber = Convert.ToInt(accountData[1]);
            string accountStatus = accountData[2];

            // Search for symbol id. "symbol", "symbolId", "isTradable", "isQuotable"
            string[] searchData = Request.Search(accessToken, apiServer, symbol);
            string searchSymbol = searchData[0];
            int symbolId = Convert.ToInt(searchData[1]);

            while (true)
            {
                // Check for positions already open for stock.
                double[] positions = Request.Positions(accessToken, apiServer, symbol, accountNumber);
                if (positions != null)
                {
                    quantity = (int)positions[1];
                    
                    // Pause after position has been closed.
                    if (quantity == 0)
                    {
                        Thread.Sleep(2000);
                    }
                }        

                // Look for trend.
                trendSignal = Conversion(symbol, symbolId);

                // Buy signal.
                if (trendSignal == "Buy")
                {
                    Console.WriteLine("Buying");
                    signal.Buy(accessToken, apiServer, symbol, accountNumber, symbolId);
                }
                // Sell signal.
                if (trendSignal == "Sell")
                {
                    Console.WriteLine("Selling");
                    signal.Sell(accessToken, apiServer, symbol, accountNumber, symbolId);
                }
                //Console.ReadLine();
            }
        }

        public string Conversion(string symbol, int symbolId)
        {
            int i = 10;
            int quantity = 0;
            double price = 0;
            double askPrice = 0;
            double bidPrice = 0;
            double wmaShort = 0;
            double oldWmaShort = 0;
            double wmaLong = 0;
            double fillPrice = 0;
            double stopPrice = 0;
            double profitGoal = 0;
            double percentChange = 0;
            double[] stochastic = { 0, 0 };
            double[,] chain;
                   
            // Run strategy.
            while (true)
            {
                // Check for positions already open for stock.
                double[] positions = Request.Positions(accessToken, apiServer, symbol, accountNumber);
                if (positions != null)
                {
                    quantity = (int)positions[1];
                    fillPrice = positions[2];
                }
                // Pause if position closed.
                if (quantity == 0)
                {
                    Thread.Sleep(1000);
                }   

                // Get option chain.
                Thread.Sleep(500);
                chain = Request.optionChain(accessToken, apiServer, symbolId);

                if (chain != null)
                {
                    int empty = 0;
                    // Candlesticks elements 0-3 "low", "high", "close", "volume"
                    string[] candle = { "low", "high", "close", "volume" }; 
                
                    // Get empty candlestick data. 
                    for (int h = 0; h < 10; h++)
                    {
                        if (chain[h, 0] == 0)
                        {
                            empty += 1;
                        }
                        ///*
                        //Console.WriteLine("Array " + symbolId + ": " + h);
                        for (int j = 0; j < 4; j++)
                        {

                            //Console.WriteLine("Element: " + j);
                            //Console.WriteLine(candle[j]);
                            chain[h, j] = Math.Round(chain[h, j], 2);
                            //Console.WriteLine(candleSticks[h, j]);
                        }
                        //*/
                    }
                    //Console.ReadKey();
                    if (empty > 0)
                        Store.Empty(symbol, empty);

                    if (empty == 0)
                    {
                        // Check to place trade.
                        if (quantity <= 0)
                        {
                            // Buy if 5 period ma equals 8 period.
                            if (wmaShort == wmaLong && oldWmaShort < wmaShort)
                            {
                                return "Buy";
                            }

                            // Take profits.
                            if (quantity != 0)
                            {
                                if (percentChange >= profitGoal)
                                {
                                    return "Buy";
                                }
                                else if (price >= stopPrice)
                                {
                                    return "Buy";
                                }
                                
                                /*
                                if (stochastic[0] > stochastic[1] && stochastic[1] < 25)
                                {
                                    return "Buy";
                                }
                                */
                            }
                        }
                        if (quantity >= 0)
                        {
                            // Sell if 5 period ma equals 8 period.
                            if (wmaShort == wmaLong && oldWmaShort > wmaShort)
                            {
                                return "Sell";
                            }

                            // Take profits.
                            if (quantity != 0)
                            {
                                if (percentChange >= profitGoal)
                                {
                                    return "Sell";
                                }
                                else if (price <= stopPrice)
                                {
                                    return "Sell";
                                }

                                /*
                                if (stochastic[0] < stochastic[1] && stochastic[1] > 75)
                                {
                                    return "Sell";
                                }
                                */
                            }
                        }
                        Thread.Sleep(5000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("NOT ENOUGH DATA");
                    }
                }    
            }
        }       
    }

    internal class PrepareOrder
    {
        // Confirm buy signal.
        internal double[] Buy(string accessToken, string apiServer, string symbol, int accountNumber, int symbolId)
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

                Console.WriteLine("quantity: " + quantity);
                if (quantity <= 0)
                {
                    // Check for orders already open.
                    int openOrders = Request.OpenOrders(accessToken, apiServer, symbol, accountNumber);
                    Console.WriteLine("Open orders: " + openOrders);
                    //Console.ReadKey();
                    if (openOrders <= 0)
                    {
                        // Check for buying power, unless covering short.
                        string[] balance = Request.AccountBalance(accessToken, apiServer, accountNumber);
                        if (true)
                        {
                            Thread.Sleep(2000);
                            return Order.Buy(accessToken, apiServer, symbol, accountNumber, quantity);
                        }
                        else
                        {

                        }
                    }
                }
            }
            return null;
        } 
  
        internal double[] Sell(string accessToken, string apiServer, string symbol, int accountNumber, int symbolId)
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
                            return Order.Sell(accessToken, apiServer, symbol, accountNumber, quantity);
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
        /// Create order to buy.
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
                    //try
                    //{
                        Console.Clear();
                        if (quote[1] == "False")
                        {
                            // Get buy price, stop loss, quantity... 
                            int currQuant = quantity;
                            limitPrice = Math.Round(((askPrice + bidPrice) / 2), 2);
                            orderData = BuyData(limitPrice, quantity);

                            quantity = (int)orderData[0];

                            if (quantity == 0)
                            {
                                return null;
                            }

                            Array.Resize<double>(ref orderData, 7);

                            // Send order.
                            string[] jsonArray = { "orders[0]." };
                            string[] searchKeyWords = { "id" };
                            string buy = Request.Order(authorization, url, action, accountNumber, symbolId, quantity, limitPrice);
                            string[] stringOrderData = Parse.Json(jsonArray, buy, searchKeyWords, searchKeyWords.Length);

                            if (stringOrderData[0] != null)
                            {
                                int orderId = Convert.ToInt(stringOrderData[0]);
                                int time = Request.GetTime(accessToken, apiServer);
                                int current = 0;
                                bool executed = false;

                                if (!Double.TryParse(stringOrderData[0], out orderData[4]))
                                    Console.WriteLine("Could not convert order id");

                                orderData[5] = limitPrice;
                                orderData[6] = currQuant;

                            while (true)
                            {
                                Thread.Sleep(5000);
                                // Check order status.
                                executed = Status(accessToken, apiServer, accountNumber, orderId);

                                // Get time.
                                current = Request.GetTime(accessToken, apiServer);

                                // If order has not been executed after 30 seconds, cancel.
                                if (executed)
                                {
                                    // Return order data.
                                    Console.WriteLine("Order Executed.");
                                    return orderData;
                                }
                                if ((current - time) > 30)
                                {
                                    // Re-check order execution.
                                    executed = Status(accessToken, apiServer, accountNumber, orderId);
                                    if (executed)
                                    {
                                        Console.WriteLine("Order Executed.");
                                        return orderData;
                                    }

                                    // Cancel order.
                                    Console.WriteLine("Cancel");
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
                                        Console.WriteLine("Order filled.");
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
                        Console.WriteLine("Could not buy " + symbol);
                        return null;
                    }*/                  
                }
            }
            return null;
        }

        /// Create order to sell.
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
                    Thread.Sleep(1000);
                    quote = Request.Quote(accessToken, apiServer, symbolId);
                    double limitPrice = 0;
                    double askPrice = 0;
                    double bidPrice = 0;

                    if (!Double.TryParse(quote[3], out askPrice))
                        Console.WriteLine("Could not convert limit price: Buy0");
                    if (!Double.TryParse(quote[2], out bidPrice))
                        Console.WriteLine("Could not convert limit price: Buy1");
                    //try
                    //{
                        Console.Clear();
                        if (quote[1] == "False")
                        {
                            // Get buy price, stop loss, quantity...
                            int currQuant = quantity;
                            limitPrice = Math.Round(((askPrice + bidPrice) / 2), 2);
                            double[] orderData = SellData(limitPrice, quantity);
                            quantity = (int)orderData[0];

                            Console.WriteLine("quantity: " +quantity);
                            quantity = (int)orderData[0];

                            if (quantity == 0)
                            {
                                return null;
                            }

                            Array.Resize<double>(ref orderData, 7);                           

                            // Send order.
                            string[] jsonArray = { "orders[0]." };
                            string[] searchKeyWords = { "id" };
                            string sell = Request.Order(authorization, url, action, accountNumber, symbolId, quantity, limitPrice);
                            string[] stringOrderData = Parse.Json(jsonArray, sell, searchKeyWords, searchKeyWords.Length);


                            if (stringOrderData[0] != null)
                            {
                                int orderId = Convert.ToInt(stringOrderData[0]);
                                int time = Request.GetTime(accessToken, apiServer);
                                int current = 0;
                                bool executed = false;

                                if (!Double.TryParse(stringOrderData[0], out orderData[4]))
                                    Console.WriteLine("Could not convert order id");

                                orderData[5] = limitPrice;
                                orderData[6] = currQuant;

                            while (true)
                            {
                                Thread.Sleep(5000);
                                // Check order.
                                executed = Status(accessToken, apiServer, accountNumber, orderId);

                                // Get time.
                                current = Request.GetTime(accessToken, apiServer);

                                // If has not been executed after 30 seconds, cancel.
                                if (executed)
                                {
                                    Console.WriteLine("Order Executed.");
                                    return orderData;
                                }
                                if ((current - time) > 30)
                                {
                                    // Re-check order execution.
                                    executed = Status(accessToken, apiServer, accountNumber, orderId);
                                    if (executed)
                                    {
                                        Console.WriteLine("Order Executed.");
                                        return orderData;
                                    }

                                    // Cancel order.
                                    Console.WriteLine("Order Cancelled.");
                                    Cancel(accessToken, apiServer, accountNumber, orderId);
                                    break;
                                }
                                double[] positions = Request.Positions(accessToken, apiServer, symbol, accountNumber);

                                if (positions != null)
                                {
                                    int filled = (int)positions[1];

                                    if (filled < currQuant)
                                    {
                                        Console.WriteLine("Order filled.");
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
                        Console.WriteLine("Error selling " + symbol + ". Order may or may not have been sent.");
                        return null;
                    }*/                
                }
            }
            return null;
        }

        // Create Stop order.
        public static void Stop(string accessToken, string apiServer, string symbol, string action, int accountNumber, int quantity, double stopLoss)
        {
            int symbolId = 0;
            string authorization = "Bearer " + accessToken;
            string url = apiServer + "v1/accounts/" + accountNumber + "/orders";
            string isQuotable = null;
            string isTradable = null;

            // Search for ticker.
            string[] search = Request.Search(accessToken, apiServer, symbol);
            string searchSymbol = search[0];
            symbolId = Convert.ToInt(search[1]);
            isQuotable = search[2];
            isTradable = search[3];

            if (searchSymbol == symbol)
            {               
                try
                {
                    Console.Clear();       
                           
                    // Send order.
                    string stop = Request.Order(authorization, url, action, accountNumber, symbolId, quantity, stopLoss, stopLoss);
                }
                catch
                {
                    Console.WriteLine("Could not create stop for " + symbol);
                }
            }
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
                Console.WriteLine("not rejected");
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
                    buyData[0] = 3200 / limitPrice;
                    buyData[0] = Math.Round(buyData[0]);

                    // Commission.
                    buyData[1] = ((buyData[0] / 100) >= 4.95) ? (buyData[0] / 100) : 4.95;

                    // Gross cost, price + commission.
                    buyData[2] = (buyData[0] * limitPrice) + (buyData[1] * 2);
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

                    // Gross profit.
                    buyData[2] = buyData[0] * limitPrice;
                }             
                
                //Stop limit.
                buyData[3] = Math.Round(limitPrice - (limitPrice * 0.005), 2);
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
            double[] sellData = new double[4];;

            if (quantity == 0)
            {
                // Quantity.
                sellData[0] = 3200 / limitPrice;
                sellData[0] = Math.Round(sellData[0]);

                // Commission.
                sellData[1] = ((sellData[0] / 100) >= 4.95) ? (sellData[0] / 100) : 4.95;

                // Gross cost.
                sellData[2] = quantity * limitPrice + sellData[1] * 2;
            }
            else if (quantity < 0)
            {
                sellData[0] = 0;
            }
            else
            {               
                sellData[0] = quantity;
                // Gross profit.
                sellData[2] = quantity * limitPrice;            
            }

            Console.WriteLine("Limit Sell data: " + limitPrice);
            Console.WriteLine("quantity Sell data: " + sellData[0]);

            // Stop limit.
            sellData[3] = Math.Round(limitPrice + (limitPrice * 0.005), 2);

            Console.WriteLine("stop: " + sellData[3]);

            return sellData;           
        }
    }

    /// <summary>
    /// C
    /// </summary>
    internal static class Calculate
    {
        public static double WeightedMovingAverage(double[,] prices,  int period, int old = 0)
        {
            int num = 0;
            double wma = 0;
            
            try
            {
                if (period <= prices.Length)
                {
                    int j = 1;
                    for (int i = (prices.Length / 4) - period; i < prices.Length/4; i++)
                    {
                        wma = wma + prices[i - old, 2] * j;
                        num += j;
                        /*
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("wma: " + wma);
                        Console.WriteLine("price: " + prices[i, 2]);
                        Console.WriteLine("j: " + j);
                        Console.WriteLine("i: " + i);
                        Console.WriteLine("Period: " + period);
                        Console.WriteLine("Period - i: " + (period - j));
                        Console.ReadKey();
                        */
                        j++;
                    }
                    wma = wma / num;
                }
                return wma;
            }
            catch
            {
                Console.WriteLine("Could not Calculate Weighted Moving Average of period " + period);
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

            Console.WriteLine("k[0]: " + k[0]);
            Console.WriteLine("k[1]: " + k[1]);
            Console.WriteLine("k[2]: " + k[2]);

            double d = Math.Round((k[0] + k[1] + k[2]) / 3, 2);

            Console.WriteLine("d: " + d);
            double[] stochastic = new double[3];
            stochastic[0] = k[2];
            stochastic[1] = d;

            return stochastic;
        }

        public static double FastK(double[,] prices, int period, int j)
        {
            double high = 0;
            double low = 100000;
            double close = 0;

            for (int i = (prices.Length / 4) - period; i < (prices.Length / 4); i++)
            {
                // I'm just taking the highest/lowest closing prices
                // I should be seeing if the high is higher than the highest
                // Likewise with the low.
                close = prices[i - j, 2];
                
                if (prices[i - j, 1] > high)
                {
                    high = prices[i - j, 1];
                }

                if (prices[i - j, 0] < low)
                {
                    low = prices[i - j, 0];
                }
                /*
                Console.WriteLine("close: " + close);
                Console.WriteLine("high: " + high);
                Console.WriteLine("low: " + low);
                Console.WriteLine();
                Console.WriteLine("i: " + i);
                Console.ReadKey();
                */
            }

            //Console.WriteLine("close: " + close);
            //Console.WriteLine("high: " + high);
            //Console.WriteLine("low: " + low);
            //Console.ReadKey();
            return ((close - low) / (high - low)) * 100;
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
        internal static string Order(string authorization, string url, string action, int accountNumber, int symbolId, int quantity, double limitPrice, double stopPrice = 0)
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
                    
                    if (stopPrice > 0)
                    {
                        jsonObject.stopPrice = stopPrice;
                        jsonObject.limitPrice = limitPrice;
                        jsonObject.orderType = "StopLimit";
                    }
                    else
                    {
                        jsonObject.limitPrice = limitPrice;
                        jsonObject.orderType = "Limit";
                    }
                    
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
            string[] jsonArray = { "combinedBalances[0].", "perCurrencyBalances[0].", "perCurrencyBalances[0].", "combinedBalances[0].", "combinedBalances[0].", "combinedBalances[0].",
                                "combinedBalances[1].", "perCurrencyBalances[1].", "perCurrencyBalances[1].", "combinedBalances[1].", "combinedBalances[1].", "combinedBalances[1]." };
            string[] keyWords = { "currency", "cash", "buyingPower", "maintenanceExcess", "isRealTime",
                                "currency", "cash", "buyingPower", "maintenanceExcess", "isRealTime"};

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
 
            int startMin = ((int)Math.Floor(((double)(DateTime.Now.Minute - (20*2)) / 5)) * 5);
            int startHour = DateTime.Now.Hour;
            int endMinute = DateTime.Now.Minute - (DateTime.Now.Minute % 2);
            string startTime = null;
            string endTime = null;
            string[] keyWords = { "low", "high", "close", "volume" };

            // if hour has passed correct for start minutes being negative.
            while (startMin < 0)
            {
                startMin += 60;
                startHour -= 1;
            }
        
            // URL commands for 1st and current close prices.
            startTime = DateTime.Now.ToString("yyyy-MM-ddT" + startHour + ":" + startMin + ":00zzz");
            endTime = DateTime.Now.ToString("yyyy-MM-ddTHH:" + endMinute.ToString() + ":00zzz");

            //Console.WriteLine("current: " + current);
            //Console.WriteLine("startTime: " + startTime);
            //Console.WriteLine("endTime: " + endTime);
            //Console.ReadKey();           

            // Five minute data.
            string command = "v1/markets/candles/" + symbolId + "?startTime=" + startTime + "-04%3A00&endTime=" + endTime + "-04%3A00&interval=TwoMinutes";

            // Request data from server.
            string candleDataJson = Json("GET", command, accessToken, apiServer);

            // Parse data.
            double[,] candleData = Parse.candlestickData(candleDataJson, keyWords);

            // Return data.
            return candleData;
        }

        /// <summary>
        /// Create Get candlestick data.
        /// </summary>
        /// <returns></returns>
        internal static double[,] optionChain(string accessToken, string apiServer, int symbolId)
        {
            Thread.Sleep(100);
            string[] keyWords = { "low", "high", "close", "volume" };

            // Five minute data.
            string command = "v1/symbols/" + symbolId + "/options";

            // Request data from server.
            string chain = Json("GET", command, accessToken, apiServer);

            // Parse data.
            double[,] chainData = Parse.candlestickData(chain, keyWords);

            // Return data.
            return chainData;
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
            //Console.Clear();
            //Console.WriteLine(jsonObject);
            

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
                                Console.WriteLine("Could not convert data" + j);
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
            int startArray = 0;
            double[,] candleStickData = new double[10, 4];
            string stringData = null;

            try
            {
                JObject jsonObject = JObject.Parse(json);
                //Console.WriteLine(jsonObject);
                //Console.ReadKey();
                //Console.Clear();

                int length = (int)Math.Floor(((double)json.Length / 155));

                if (length >= 10)
                    startArray = length - 9;

                // Assign values to arrays.
                for (int k = 0; k < 10; k++)
                {
                    // Assign values to array elements.
                    for (int j = 0; j < 4; j++)
                    {
                        stringData = (String)jsonObject.SelectToken("candles[" + startArray + "]." + keyWords[j]);
                        if (stringData != null)
                        {
                            if (!Double.TryParse(stringData, out candleStickData[k, j]))
                                Console.WriteLine("Could not convert limit price: phData");
                        }
                    }
                    startArray++;
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
                        Store.RefreshToken(data[3]);
                }
                else
                {
                    JObject jsonObject = JObject.Parse(json);
                    Console.WriteLine(jsonObject);
                    Console.ReadKey();
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
                Console.WriteLine("Could not convert cad balance");
            if (!Double.TryParse(accountBalance[2], out balance[1]))
                Console.WriteLine("Could not convert cad com balance");
            if (!Double.TryParse(accountBalance[3], out balance[2]))
                Console.WriteLine("Could not convert cad buying power");

            // US balance.
            if (!Double.TryParse(accountBalance[6], out balance[3]))
                Console.WriteLine("Could not convert usd balance");
            if (!Double.TryParse(accountBalance[7], out balance[4]))
                Console.WriteLine("Could not convert usd com balance");
            if (!Double.TryParse(accountBalance[8], out balance[5]))
                Console.WriteLine("Could not convert balance");

            //"currency", "cash", "buyingPower", "maintenanceExcess", "isRealTime",
            //"currency", "cash", "buyingPower", "maintenanceExcess", "isRealTime"
            return balance;
        }
    }

    // Display to the console.
    internal class Display
    {
        ParseData parse = new ParseData();

        internal void DisplayController(string accessToken, string apiServer, string[] startBalance, int accountNumber, double profit, double profitGoal, DateTime lastTradeTime)
        {
            double[] accountData = parse.Balance(accessToken, apiServer, accountNumber);

            // Display balance.
            BalanceTitle();
            Balance(startBalance, accountData);
            Console.Clear();

            // Display Profit.
            ProfitTitle();
            Profit(profit, profitGoal);
            Thread.Sleep(5000);
            Console.Clear();
        }

        private void BalanceTitle()
        {
            Console.WriteLine("Account Balance");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
        }

        private void ProfitTitle()
        {
            Console.WriteLine("Trading Profit");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
        }

        private void Balance(string[] startBalance, double[] accountBalance)
        {           
            if (accountBalance != null)
            {
                double startCad = 0;
                double startUsd = 0;

                if (startBalance != null)
                {
                    if (!Double.TryParse(startBalance[1], out startCad))
                        Console.WriteLine("Could not convert cad balance");
                    if (!Double.TryParse(startBalance[6], out startUsd))
                        Console.WriteLine("Could not convert usd balance");
                }

                Console.WriteLine("Starting CAD Cash: " + startCad);
                Console.WriteLine("Starting USD Cash: " + startUsd);
                Console.WriteLine();

                // Canadian balance.
                Console.WriteLine("CAD ");
                Console.Write("Balance: ");
                Console.WriteLine(accountBalance[0]);
                Console.Write("Buying Power: ");
                Console.WriteLine(accountBalance[1]);
                Console.Write("Maintenance Excess: ");
                Console.WriteLine(accountBalance[2]);
                Console.WriteLine();
                Console.WriteLine();

                // US balance.
                Console.WriteLine("USD ");
                Console.Write("Balance: ");
                Console.WriteLine(accountBalance[3]);
                Console.Write("Buying Power: ");
                Console.WriteLine(accountBalance[4]);
                Console.Write("Maintenance Excess: ");
                Console.WriteLine(accountBalance[5]);              
            }
            Thread.Sleep(10000);
        }

        private void Profit (double profit, double profitGoal)
        {
            Console.WriteLine("Profit: " + profit);
            Console.WriteLine("Profit Goal: " + profitGoal);
            Thread.Sleep(10000);
        }

        private void Trade (DateTime time)
        {
            Console.WriteLine("Last Trade closed: " + time);
            Console.WriteLine();
        }
    }

    static class Store
    {
        static private string xmlFilePath = "C:\\Applications\\QuestradeAPI\\CSharp\\AlgoTrader\\Practice Account\\Account 2 data";
        static private string debugging = "C:\\Applications\\QuestradeAPI\\CSharp\\AlgoTrader\\Practice Account\\Strategies\\Scalper\\Debugging\\";

        // Storage with XML file.
        internal static void RefreshToken(string refreshToken)
        {
            XmlTextWriter Xwriter = new XmlTextWriter(xmlFilePath + "\\data.xml", Encoding.UTF8);
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

        internal static void stopLoss(double fillPrice, double stopLoss)
        {
            int time = Convert.ToInt(DateTime.Now.ToString("HHmm"));
            string folder = DateTime.Now.ToString("yyyy - MM - dd") + "Stop Loss";

            Directory.CreateDirectory(debugging + folder);

            XmlTextWriter Xwriter = new XmlTextWriter(debugging + folder + "\\" + "Stop Loss-" + time + ".xml", Encoding.UTF8);
            Xwriter.WriteStartElement("fillPrice");
            Xwriter.WriteString(fillPrice.ToString());
            Xwriter.WriteEndElement();
            Xwriter.WriteStartElement("stopLoss");
            Xwriter.WriteString(stopLoss.ToString());
            Xwriter.WriteEndElement();
            Xwriter.Close();
        }

        // Retrive data from XML file.
        internal static string Retrieve()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(xmlFilePath + "\\data.xml");
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
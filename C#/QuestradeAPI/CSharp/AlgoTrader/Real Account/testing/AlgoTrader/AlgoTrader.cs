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
using System.Runtime.InteropServices;
using System.Linq;
using Newtonsoft.Json;

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
            int i = 0;
            int powerDown = 1;
            int accountNumber = 0;
            double profit = 0;
            double profitGoal = 100;
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
            Thread uwti = new Thread(() => strategy.Trade(authorizedData, "UWTI"));

            Thread[] tickers = new Thread[30];

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

            //while (true)
            //{ 
              //  if (DateTime.Now.Minute > 930)
                //{
                    // Trade STOCKS.
                    tvix.Start();
                    //hou.Start();
                    //td.Start();
                    bns.Start();
                    //fm.Start();
                    //hod.Start();
                    //cpg.Start();
                    //.Start();
                    //mu.Start();
                    //msft.Start();
                    //f.Start();
                    //aapl.Start();
                    //tsla.Start();
                    uwti.Start();
                  //  break;
               // }
           // }

            while (true)
            {
                /*
                Console.WriteLine("Enter a ticker: ");
                string symbol = Console.ReadLine();

                if (symbol != null && i < 30)
                {
                    tickers[i] = new Thread(() => strategy.Trade(authorizedData, symbol));
                    tickers[i].Start();
                    i++;
                    Console.Clear();
                }
                */
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

                    // Run display thread once closed.
                    if (!displayData.IsAlive)
                    {
                        // Display.
                        displayData = new Thread(() => display.DisplayController(accessToken, apiServer, balance, accountNumber, profit, profitGoal, time));
                        displayData.Start();
                    }

                    // Shutdown Program if profit goal reached.
                    if (profit > profitGoal)
                    {
                        // Abort threads.
                        tvix.Abort();
                        displayData.Abort();

                        // Write down close time.
                        Secure.EndTime(DateTime.Now, profit);

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
                        Secure.EndTime(DateTime.Now, profit);

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
                }

                // Pause after position has been closed.
                if (quantity == 0)
                {
                    Thread.Sleep(4000);
                }

                // Look for trend.
                trendSignal = MovingAverages(symbol, symbolId);

                // Buy signal.
                if (trendSignal == "Buy")
                {
                    //Console.WriteLine("Buying");
                    signal.Buy(accessToken, apiServer, symbol, accountNumber, symbolId);
                }
                // Sell signal.
                if (trendSignal == "Sell")
                {
                    //Console.WriteLine("Selling");
                    signal.Sell(accessToken, apiServer, symbol, accountNumber, symbolId);
                }
                //Console.ReadLine();
            }
        }

        public string MovingAverages(string symbol, int symbolId)
        {
            int i = 10;
            int quantity = 0;
            int oldPriceMove = 0;
            double rocShort = 0;
            double rocLong = 0;
            double price = 0;
            double askPrice = 0;
            double bidPrice = 0;
            double wmaShort = 0;
            double wmaLong = 0;
            double fillPrice = 0;
            double[,] candleSticks;
            string[] quote;

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

                // Get candlestick data for past 15 minutes.
                Thread.Sleep(500);
                candleSticks = Request.candlestickData(accessToken, apiServer, symbolId);

                // Get current price.
                quote = Request.Quote(accessToken, apiServer, symbolId);
                if (!Double.TryParse(quote[3], out askPrice))
                    Console.WriteLine("Could not convert limit price: ask");
                if (!Double.TryParse(quote[2], out bidPrice))
                    Console.WriteLine("Could not convert limit price: bid");
                price = Math.Round(((askPrice + bidPrice) / 2), 2);

                //  Candlesticks elements 0-3 "low", "high", "close", "volume"
                string[] candle = { "low", "high", "close", "volume" };

                if (candleSticks != null)
                {
                    int empty = 0;
                    // display candlestick data for testing. 
                    for (int h = 0; h < 10; h++)
                    {
                        if (candleSticks[h, 0] == 0)
                        {
                            empty += 1;
                        }
                        /*
                        Console.WriteLine("Array " + symbolId + ": " + h);
                        for (int j = 0; j < 4; j++)
                        {
                            
                            Console.WriteLine("Element: " + j);
                            Console.WriteLine(candle[j]);
                            Console.WriteLine(candleSticks[h, j]);
                        }        
                          */          
                    }
                    if (empty > 0)
                        Secure.Empty(symbol, empty);

                    // Adjust the wma period based on price action.
                    if (quantity != 0)
                    {
                        if (Math.Abs(price - fillPrice) > 0.1)
                        {
                            int priceMove = 0;

                            if ((int)Math.Round(Math.Abs(price - fillPrice) / 0.1, 0) > oldPriceMove)
                            {
                                priceMove = (int)Math.Round(Math.Abs(price - fillPrice) / 0.1, 2);
                                //Console.ReadKey();
                                if (priceMove > oldPriceMove)
                                {
                                    i -= priceMove;
                                    oldPriceMove = priceMove;
                                }
                            }
                            //Console.WriteLine("price move: " + priceMove);                      
                        }
                    }
                    //Console.WriteLine("i: " + i);         

                    // Calculate weighted moving averages.
                    wmaLong = Calculate.WeightedMovingAverage(candleSticks, i);
                    wmaShort = Calculate.WeightedMovingAverage(candleSticks, (int)Math.Round(i / 2.0, 0));
                    rocLong = Calculate.RateOfChange(candleSticks, i);
                    rocShort = Calculate.RateOfChange(candleSticks, (int)Math.Round(i / 2.0, 0));

                    // Check to place trade.
                    if (quantity <= 0)
                    {
                        // Take profits.
                        if (i <= 1)
                        {
                            return "Buy";
                        }

                        // Buy if 5 period ma is greater than the 10 period.
                        if (wmaShort > wmaLong)
                        {
                            return "Buy";
                        }
                    }
                    if (quantity >= 0)
                    {
                        // Take profits.
                        if (i <= 1)
                        {
                            return "Sell";
                        }

                        // Sell if 5 period ma is less than the 10 period.
                        if (wmaShort < wmaLong)
                        {
                            return "Sell";
                        }
                    }
                    
                    // Display variables for testing.
                    /*Console.WriteLine(i + " period wma: " + wmaTen);
                    Console.WriteLine((int)Math.Round(i / 2.0, 0) +" period wma: " + wmaFive);
                    Console.WriteLine("Current price: " + price);
                    Console.WriteLine("Fill price: " + fillPrice);
                    Console.WriteLine();
                    Console.WriteLine("old price move: " + oldPriceMove);                  
                    Console.WriteLine();
                    //Console.ReadKey();
                    */
                    Thread.Sleep(5000);
                }
            }
        }

        internal double RateOfChange ()
        {
            return 0;
        }
    }

    internal class PrepareOrder
    {
        // Confirm buy signal.
        internal void Buy(string accessToken, string apiServer, string symbol, int accountNumber, int symbolId)
        {
            Console.WriteLine("Buy " + symbol + "!");
            Thread.Sleep(5000);
        }

        internal void Sell(string accessToken, string apiServer, string symbol, int accountNumber, int symbolId)
        {
            Console.WriteLine("Sell " + symbol + "!");
            Thread.Sleep(5000);
        }
    }

    /// <summary>
    /// Calculate technicals.
    /// </summary>
    internal class Calculate
    {
        public static double WeightedMovingAverage(double[,] prices, int period)
        {
            int num = 0;
            double wma = 0;

            try
            {
                if (period <= prices.Length)
                {
                    int j = 0;
                    for (int i = (prices.Length / 4) - period; i < prices.Length / 4; i++)
                    {
                        wma = wma + prices[i, 2] * (period - j);
                        num += period - j;
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
                Console.WriteLine("Could not Calculate Weighted Moving Average");
                return 0;
            }
        }

        public static double RateOfChange(double[,] prices, int period)
        {
            if (period < 11 && period > -1)
            {
                int j = 10 - period;
                return (prices[9, 2] - prices[j, 2]) / prices[j, 2];
            }
            return 0;
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
            string url = "https://login.questrade.com/oauth2/token?grant_type=refresh_token&refresh_token=" + refreshToken;

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
            
            int startMin = ((int)Math.Floor(((double)(DateTime.Now.Minute - (20 * 5 + 15)) / 5)) * 5);
            int startHour = DateTime.Now.Hour;
            int endMinute = DateTime.Now.Minute - (DateTime.Now.Minute % 5);
            string endTime = null;
            string startTime = null;        
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

            // Five minute data.
            string command = "v1/markets/candles/" + symbolId + "?startTime=" + startTime + "-04%3A00&endTime=" + endTime + "-04%3A00&interval=FiveMinutes";

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
            //Console.WriteLine(jsonObject);

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

        private void Profit(double profit, double profitGoal)
        {
            Console.WriteLine("Profit: " + profit);
            Console.WriteLine("Profit Goal: " + profitGoal);
            Thread.Sleep(10000);
        }

        private void Trade(DateTime time)
        {
            Console.WriteLine("Last Trade closed: " + time);
            Console.WriteLine();
        }
    }

    static class Secure
    {
        static private string xmlFilePath = "C:\\Applications\\QuestradeAPI\\CSharp\\AlgoTrader\\Real Account\\";
        static private string debugging = "C:\\Applications\\QuestradeAPI\\CSharp\\AlgoTrader\\Real Account\\Debugging\\";

        // Storage with XML file.
        internal static void Store(string refreshToken)
        {
            XmlTextWriter Xwriter = new XmlTextWriter(xmlFilePath + "data.xml", Encoding.UTF8);
            Xwriter.WriteStartElement("refresh_token");
            Xwriter.WriteString(refreshToken);
            Xwriter.WriteEndElement();
            Xwriter.Close();
        }

        // Storage with XML file.
        internal static void EndTime(DateTime time, double profit)
        {
            XmlTextWriter Xwriter = new XmlTextWriter(xmlFilePath + "time.xml", Encoding.UTF8);
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

        // Retrive data from XML file.
        internal static string Retrieve()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("C:\\Applications\\QuestradeAPI\\CSharp\\AlgoTrader\\Real Account\\data.xml");
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
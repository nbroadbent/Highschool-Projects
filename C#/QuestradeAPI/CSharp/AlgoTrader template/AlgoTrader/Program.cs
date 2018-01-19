// .Net Libraries
using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace AlgoTrader
{
    /// <summary>
    /// An Algorithmic trader that uses The Questrade API
    /// </summary>
    static class Program
    {
        private static string refreshToken = "UCxdBcVYU3_kKgAUdGM7pJMdOgHSlkdM0";
        private static string accessToken;
        private static string tokenType;
        private static string expires;
        private static string apiServer;

        static void Main(string[] args)
        {
            string accessToken = RedeemRefreshToken();
            Console.WriteLine(accessToken);
            Console.ReadLine();
        }

        // Redeem refresh token for an access token
        private static string RedeemRefreshToken()
        {
            string url = "https://practicelogin.questrade.com/oauth2/token?grant_type=refresh_token&refresh_token=" + refreshToken;

            HttpWebResponse response = null;
            try
            {
                // Setup the Request
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";

                // Write data
                Stream postStream = request.GetRequestStream();
                postStream.Close();

                // Send Request & Get Response
                response = (HttpWebResponse)request.GetResponse();

                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    // Get the Response Stream
                    string json = reader.ReadLine();
                    //Console.WriteLine(json);

                    // Retrieve and Return the Authorization info
                    JavaScriptSerializer ser = new JavaScriptSerializer();
                    // Access token
                    Dictionary<string, object> x = (Dictionary<string, object>)ser.DeserializeObject(json);
                    accessToken = x["access_token"].ToString();
                    // Token type
                    Dictionary<string, object> y = (Dictionary<string, object>)ser.DeserializeObject(json);
                    tokenType = y["token_type"].ToString();
                            // Expiration time
                            //Dictionary<int, object> z = (Dictionary<int, object>)ser.DeserializeObject(json);
                            //expires = x["expires_in"].ToString();
                            // New Refresh token
                    Dictionary<string, object> yy = (Dictionary<string, object>)ser.DeserializeObject(json);
                    apiServer = yy["refresh_token"].ToString();
                    // Server host
                    Dictionary<string, object> xx = (Dictionary<string, object>)ser.DeserializeObject(json);
                    apiServer = xx["api_server"].ToString();


                    Console.WriteLine("acess token: " + accessToken);
                    Console.WriteLine("token type: " + tokenType);
                    //Console.WriteLine("expires: " + expires);
                    Console.WriteLine("refresh token: " + refreshToken);
                    Console.WriteLine("api server: " + apiServer);

                    Store();
                }
            }
            catch (WebException e)
            {
                // This exception will be raised if the server didn't return 200 - OK
                // Retrieve more information about the error
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

        // unsecure storage with file
        private static void Store ()
        {
            System.IO.File.WriteAllText(@"\", refreshToken);
        }

        private static void Retrieve ()
        {

        }

/*      // Store data for later use - secure
        private static void Storage()
        {
            // Data to protect. Convert a string to a byte[] using Encoding.UTF8.GetBytes().
            byte[] refresh = Encoding.UTF8.GetBytes(refreshToken.Text);
            byte[] SaltByte = Encoding.UTF8.GetBytes(Salt.Text);

            // Generate additional entropy (will be used as the Initialization vector)
            byte[] entropy = new byte[20];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(entropy);
            }

            byte[] ciphertext = ProtectedData.Protect(plaintext, entropy,
                DataProtectionScope.LocalMachine.CurrentUser);
        }
*/
    }
}

/*
request.Host = "https://api01.iq.questrade.com";
request.ContentLength = 0;
request.ContentType = "application/json; charset=utf-8";
*/

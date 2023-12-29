using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    /* A Real-Time Currency Converter using RestSharp and Newtonsoft.Json
     Uses the Exchange Rates Data API to get current conversion rate information */

    public class CurrencyConverter
    {
        // Create class dictionary
        Dictionary<string, string> symbols;

        // Create a Dictionary to get currency abbreviations; ex: USD, United States Dollar 
        public Dictionary<string, string> GetSymbols()
        {
            // If no symbols, initialize here; otherwise, return symbols
            if(symbols == null)
            {
                // TODO: Make API call
                symbols = new Dictionary<string, string>();

                // Create string to store the response retrieved by the getResponseString method
                string responseContent = getResponseString("exchangerates_data/symbols");

                // Convert JSON response into a form we can deal with
                Dictionary<string, object> responseData 
                    = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);

                // Type cast success so that if "success" = true in the JSON data, we return the "symbols" data
                if ((bool)responseData["success"])
                {
                    // Store "symbols" in a base object variable called tempSymbols
                    // Type cast responseData["symbols"] as a JObject to access helper methods
                    var tempSymbols = (JObject)responseData["symbols"];

                    // Initialize symbols variable by converting tempSymbols (JObject) to an object
                    symbols = tempSymbols.ToObject<Dictionary<string, string>>();
                }
            }
            return symbols;
        }

        // getResponseString() handles the Rest API call to Exchange Rates Data API
        private string getResponseString(string relativeURL)
        {
            var client = new RestClient("https://api.apilayer.com/");
            
            // TODO: Make a request to the exchangerates_data/symbols
            var request = new RestRequest(relativeURL, Method.Get);

            // Add API key to the request
            request.AddHeader("apikey", "xRSabxig0AqjaB28SemerL2acNfKzxRK");

            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            /* This is an example of the response returned in JSON:
             {
                  "success": true,
                  "symbols": {
                    "AED": "United Arab Emirates Dirham",
                    "AFN": "Afghan Afghani",
                    "ALL": "Albanian Lek",
                  }
                }
             */

            return response.Content; // Returns content back to the caller
        }

        public double Convert(string fromCurrency, string toCurrency, double currencyAmount)
        {
            // Create string to store the response retrieved by the getResponseString method and add the variables we're using
            string responseContent = getResponseString
                ($"exchangerates_data/convert?to={toCurrency}&from={fromCurrency}&amount={currencyAmount}");

            // Convert JSON response into a form we can deal with
            Dictionary<string, object> responseData
                = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);

            // Type cast success so that if "success" = true in the JSON data, we return the "result" data
            if ((bool)responseData["success"])
            {
                // Return "result" as responseData, type casted as double
                return (double)responseData["result"];
            }
            else
            {
                // return -1 to let us know it failed
                return -1;
            }

            /* JSON sample response:
               {
                  "date": "2018-02-22",
                  "historical": "",
                  "info": {
                    "rate": 148.972231,
                    "timestamp": 1519328414
                  },
                  "query": {
                    "amount": 25,
                    "from": "GBP",
                    "to": "JPY"
                  },
                  "result": 3724.305775,
                  "success": true
                }
             */
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.IO;


namespace UTESA_STORE.Api
{
    public class Fetch
    {
        static private WebRequest ApIRequester = null;
        public string Get(string uriString) {

            ApIRequester = WebRequest.Create(uriString);
            ApIRequester.Method = "GET";
            string responseStringTest = null;
            HttpWebResponse ResponseHandler = (HttpWebResponse)ApIRequester.GetResponse();
            using (Stream stream = ResponseHandler.GetResponseStream())
            {

                StreamReader StreamRaeder = new StreamReader(stream);
                responseStringTest = StreamRaeder.ReadToEnd();
                StreamRaeder.Close();
                Console.WriteLine(responseStringTest);
                return responseStringTest;
            }
        } 
    }
}

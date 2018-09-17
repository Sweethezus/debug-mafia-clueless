using System;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Web;
using System.Net;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace HttpClientSample
{
    static class Program
    {
        [XmlRoot(ElementName = "Document")]
        public class Document
        {
            [XmlElement(ElementName = "user")]
            public string User { get; set; }
            [XmlElement(ElementName = "password")]
            public string Password { get; set; }
        }

        static void Main()
        {
            MakeRequest();
            Console.WriteLine("Hit ENTER to exit...");
            Console.ReadLine();
        }

        static async void MakeRequest()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://clueless.azure-api.net/echo/resource");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Ocp-Apim-Subscription-Key", "e4c1961185b74874a37dbf72e8adeddb");

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"user\":\"test\"," +
                              "\"password\":\"bla\"}";

                Console.WriteLine(json);
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            XmlSerializer xs = new XmlSerializer(typeof(Document), new XmlRootAttribute("Document"));

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd().Trim('\0');
                Console.WriteLine(result);
            }

        }
    }
}
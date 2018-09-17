using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ClueLessClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [XmlRoot(ElementName = "Document")]
        public class Document
        {
            [XmlElement(ElementName = "user")]
            public string User { get; set; }
            [XmlElement(ElementName = "password")]
            public string Password { get; set; }
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(serverURL_Box.Text + "/echo/resource");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Ocp-Apim-Subscription-Key", "e4c1961185b74874a37dbf72e8adeddb");

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"user\":\"test\"," +
                              "\"password\":\"bla\"}";

                responseBox.Text = json;
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            XmlSerializer xs = new XmlSerializer(typeof(Document), new XmlRootAttribute("Document"));

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd().Trim('\0');
                responseBox.Text += result;

            }
        }
    }
}

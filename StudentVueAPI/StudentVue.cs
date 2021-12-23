using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace StudentVueAPI {
    public class StudentVue {

        private readonly string domain;
        private readonly string username;
        private readonly string password;

        private readonly HttpClient client;

        const string WEBSERVICE_HANDLE_NAME = "PXPWebServices";

        public StudentVue(string username, string password, string domain) {
            this.domain = domain;
            this.username = username;
            this.password = password;

            CookieContainer cookies = new CookieContainer();
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = cookies;

            client = new HttpClient(handler);
            var z = client.GetAsync("https://portal.sfusd.edu/Service/PXPCommunication.asmx?WSDL").Result;


        }

        public StudentInfo GetStudentInfo() {
            return null;
        }

        private async Task<T> SendRequestAsync<T>(string method, string parms) {
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, "https://portal.sfusd.edu/Service/PXPCommunication.asmx")) {
                requestMessage.Headers.Add("SOAPAction", "\"http://edupoint.com/webservices/ProcessWebServiceRequest\"");
                requestMessage.Content = new StringContent(
                    "<soap-env:Envelope xmlns:soap-env=\"http://schemas.xmlsoap.org/soap/envelope/\"><soap-env:Body><ns0:ProcessWebServiceRequest xmlns:ns0=\"http://edupoint.com/webservices/\">" +
                        $"<ns0:userID>{username}</ns0:userID>" +
                        $"<ns0:password>{password}</ns0:password>" +
                        "<ns0:skipLoginLog>true</ns0:skipLoginLog>" +
                        "<ns0:parent>false</ns0:parent>" +
                        "<ns0:webServiceHandleName>PXPWebServices</ns0:webServiceHandleName>" +
                        $"<ns0:methodName>{method}</ns0:methodName>" +
                        $"<ns0:paramStr>&lt;Parms&gt;{parms}&lt;/Parms&gt;</ns0:paramStr>" +
                    "</ns0:ProcessWebServiceRequest></soap-env:Body></soap-env:Envelope>",
                    null, "text/xml");
                var response = await client.SendAsync(requestMessage);
                var responseXml = XDocument.Parse(await response.Content.ReadAsStringAsync());
                var xml = responseXml.Descendants("ProcessWebServiceRequestResult").First().Value.Replace("&gt;", ">").Replace("&lt;", "<");

                var serializer = new XmlSerializer(typeof(T));
                using (TextReader reader = new StringReader(xml)) {
                    return (T)serializer.Deserialize(reader);
                }
            }

            throw new NotImplementedException();
        }

    }
}

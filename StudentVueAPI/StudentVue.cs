﻿using System;
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

        public StudentVue(string username, string password, string domain) {
            this.domain = domain;
            this.username = username;
            this.password = password;

            CookieContainer cookies = new();
            HttpClientHandler handler = new() {
                CookieContainer = cookies
            };

            client = new HttpClient(handler);
            _ = client.GetAsync($"https://{domain}/Service/PXPCommunication.asmx?WSDL").Result;
        }

        public async Task<StudentInfo> GetStudentInfoAsync() {
            return await SendRequestAsync<StudentInfo>("StudentInfo", "");
        }
        public async Task<Gradebook> GetGradebookAsync(int? reportPeriod = null) {
            return await SendRequestAsync<Gradebook>("Gradebook", 
                reportPeriod?.ToString() ?? $"<ReportPeriod>{reportPeriod}</ReportPeriod>");
        }
        public async Task<StudentSchoolInfoListing> GetStudentSchoolInfoListingAsync() {
            return await SendRequestAsync<StudentSchoolInfoListing>("StudentSchoolInfo", "");
        }
        public async Task<StudentClassSchedule> GetStudentClassScheduleAsync(int? termIndex = null) {
            return await SendRequestAsync<StudentClassSchedule>("StudentClassList",
                termIndex?.ToString() ?? $"<TermIndex>{termIndex}</TermIndex>");
        }

        public async Task<RCReportingPeriod> GetRCReportingPeriodAsync() {
            return await SendRequestAsync<RCReportingPeriod>("GetReportCardInitialData", "");
        }

        private bool l => username is not null;
        private async Task<T> SendRequestAsync<T>(string method, string parms) {
            if(method is not null) {

            }
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"https://{domain}/Service/PXPCommunication.asmx")) {
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
                XNamespace xmlns = "http://edupoint.com/webservices/";
                var xml = responseXml.Descendants(xmlns + "ProcessWebServiceRequestResult").First().Value.Replace("<br>", "&#xA;");

                var serializer = new XmlSerializer(typeof(T));
                using TextReader reader = new StringReader(xml);
                return (T)serializer.Deserialize(reader);
            }

            throw new NotImplementedException();
        }

    }
}

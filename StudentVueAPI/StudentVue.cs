using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace StudentVueAPI {
    public class StudentVue {

        private string domain;
        private string username;
        private string password;
        private HttpClient client;
        private CookieContainer cc = new CookieContainer();

        public async Task L() {

        }

        public StudentVue(string username, string password, string domain) {
            this.domain = domain;
            this.username = username;
            this.password = password;

            var url = $"https://{domain}/PXP2_Login_Student.aspx?regenerateSessionId=True";
            
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");

            ChromeDriver cd = new ChromeDriver(@"C:\WebDriver", options);

            cd.Navigate().GoToUrl(url);

            cd.FindElementByName("ctl00$MainContent$username").SendKeys(username);
            cd.FindElementByName("ctl00$MainContent$password").SendKeys(password);
            cd.FindElementByName("ctl00$MainContent$Submit1").Click();

            foreach (OpenQA.Selenium.Cookie c in cd.Manage().Cookies.AllCookies) {
                string name = c.Name;
                string value = c.Value;
                cc.Add(new System.Net.Cookie(name, value, c.Path, c.Domain));
            }

            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = cc;
            client = new HttpClient(handler);
            client.BaseAddress = new Uri($"https://{domain}");
            

            //Non-Selenium (Doesn't work)
            /*using (HttpClient client = new HttpClient()) {
                //client.BaseAddress = $"https://{domain}/";
                var html = client.GetStringAsync(url);
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(html.Result); 
                var navigator = htmlDoc.CreateNavigator();
                var __EVENTVALIDATION = navigator.SelectSingleNode("//input[@name=\"__EVENTVALIDATION\"]/@value").Value;
                var __VIEWSTATE = navigator.SelectSingleNode("//input[@name=\"__VIEWSTATE\"]/@value").Value;
                var s = client.PostAsync(url, new FormUrlEncodedContent(new Dictionary<string, string>()
                {
                    ["__VIEWSTATEGENERATOR"] = "E13CECB1",
                    ["__EVENTVALIDATION"] = __EVENTVALIDATION,
                    ["__VIEWSTATE"] = __VIEWSTATE,
                    ["ctl00$MainContent$username"] = username,
                    ["ctl00$MainContent$password"] = password

                }));
                Console.WriteLine(__EVENTVALIDATION);
                Console.WriteLine(__VIEWSTATE);
                Console.WriteLine((int)s.Result.StatusCode);
            }*/
        }



        public void GetGradeBook() {



        }



    }
}

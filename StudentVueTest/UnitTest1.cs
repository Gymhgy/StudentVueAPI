using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentVueAPI;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace StudentVueTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public async Task TestMethod1() {
            var configuration = new ConfigurationBuilder().AddUserSecrets<UnitTest1>().Build();

            var secrets = configuration.Providers.First();
            secrets.TryGet("username", out var username);
            secrets.TryGet("password", out var password);
            secrets.TryGet("domain", out var domain);
            Console.WriteLine((username, password, domain));
            var sv = new StudentVue(username, password, domain);
            var d = await sv.GetStudentInfoAsync();
            ;
        }
    }
}

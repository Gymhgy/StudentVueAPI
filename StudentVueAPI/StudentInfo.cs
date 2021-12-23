using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Reflection;
using StudentVueAPI.JsonConverters;

namespace StudentVueAPI {

    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]

    public class StudentInfo {

        public StudentInfo(string name, int studentNumber, string gender, int grade, string schoolName, DateTime birthdate) {
            Name = name;
            StudentNumber = studentNumber;
            Gender = gender;
            Grade = grade;
            SchoolName = schoolName;
            Birthdate = birthdate;
        }

        static StudentInfo() {
            Properties = typeof(StudentInfo).GetProperties().Select(p => {
                JsonPropertyNameAttribute[] attr = (JsonPropertyNameAttribute[])p.GetCustomAttributes<JsonPropertyNameAttribute>();
                if (attr.Length > 0) return attr[0].Name;
                else return p.Name;
            });
            Console.WriteLine(string.Join(", ", Properties));
        }
        internal static readonly IEnumerable<string> Properties;
        [JsonPropertyName("Student Name")]
        public string Name { get; }
        [JsonPropertyName("Student No")]
        public int StudentNumber { get; }
        public string Gender { get; }
        public int Grade { get; }
        [JsonPropertyName("School Name")]
        public string SchoolName { get; }
        [JsonConverter(typeof(DateTimeParseConverter))]
        [JsonPropertyName("Birth Date")]
        public DateTime Birthdate { get; }
        [JsonExtensionData]

        public readonly Dictionary<string, string> OtherData;

        internal static StudentInfo FromHtml(HtmlDocument doc) {
            //get the second one
            //change if need to get info beyond 1st table
            HtmlNode table = doc.DocumentNode.SelectSingleNode("(//table[@class='info_tbl table table-bordered'])[2]");
            var nodes = table.SelectNodes(".//td");
            var dict = new Dictionary<string, string>();
            foreach(var node in nodes) {
                var key = node.SelectSingleNode(".//span").InnerText;
                var value = node.GetDirectInnerText();
                dict.Add(key, value);
            }
            return JsonSerializer.Deserialize<StudentInfo>(JsonSerializer.Serialize(dict));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace StudentVueAPI {
    public class Gradebook {

        List<Course> Courses;

        private Gradebook() {

        }



        internal static Gradebook FromHtml(HtmlDocument doc) {
            HtmlNode table = doc.DocumentNode.SelectSingleNode("//table[@class='info_tbl table table-bordered']");
            return null;
        }
    }

    public class Course {

    }
}

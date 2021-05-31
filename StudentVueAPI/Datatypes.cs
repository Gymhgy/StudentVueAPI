using System;
using System.Collections.Generic;
using System.Text;

namespace StudentVueAPI {

    public record StudentInfo(string name, int num, string gender, int grade, string schoolName, DateTime birthdate);

    public record Teacher(string name, string email);

    public record Course(string name, Teacher teacher, string grade);

    public record Gradebook();
}
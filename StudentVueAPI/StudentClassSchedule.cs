using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace StudentVueAPI {
	[XmlRoot(ElementName = "ClassInfo")]
	public class ClassInfo {
		[XmlElement(ElementName = "AttendanceCode")]
		public string AttendanceCode { get; set; }
		[XmlAttribute(AttributeName = "Period")]
		public string Period { get; set; }
		[XmlAttribute(AttributeName = "ClassName")]
		public string ClassName { get; set; }
		[XmlAttribute(AttributeName = "ClassURL")]
		public string ClassURL { get; set; }
		[XmlAttribute(AttributeName = "StartTime")]
		public string StartTime { get; set; }
		[XmlAttribute(AttributeName = "EndTime")]
		public string EndTime { get; set; }
		[XmlAttribute(AttributeName = "TeacherName")]
		public string TeacherName { get; set; }
		[XmlAttribute(AttributeName = "TeacherURL")]
		public string TeacherURL { get; set; }
		[XmlAttribute(AttributeName = "RoomName")]
		public string RoomName { get; set; }
		[XmlAttribute(AttributeName = "TeacherEmail")]
		public string TeacherEmail { get; set; }
		[XmlAttribute(AttributeName = "EmailSubject")]
		public string EmailSubject { get; set; }
		[XmlAttribute(AttributeName = "StaffGU")]
		public string StaffGU { get; set; }
		[XmlAttribute(AttributeName = "EndDate")]
		public string EndDate { get; set; }
		[XmlAttribute(AttributeName = "StartDate")]
		public string StartDate { get; set; }
		[XmlAttribute(AttributeName = "SectionGU")]
		public string SectionGU { get; set; }
		[XmlAttribute(AttributeName = "HideClassStartEndTime")]
		public string HideClassStartEndTime { get; set; }
	}

	[XmlRoot(ElementName = "Classes")]
	public class Classes {
		[XmlElement(ElementName = "ClassInfo")]
		public List<ClassInfo> ClassInfo { get; set; }
	}

	[XmlRoot(ElementName = "SchoolInfo")]
	public class SchoolInfo {
		[XmlElement(ElementName = "Classes")]
		public Classes Classes { get; set; }
		[XmlAttribute(AttributeName = "SchoolName")]
		public string SchoolName { get; set; }
		[XmlAttribute(AttributeName = "BellSchedName")]
		public string BellSchedName { get; set; }
	}

	[XmlRoot(ElementName = "SchoolInfos")]
	public class SchoolInfos {
		[XmlElement(ElementName = "SchoolInfo")]
		public SchoolInfo SchoolInfo { get; set; }
	}

	[XmlRoot(ElementName = "TodayScheduleInfoData")]
	public class TodayScheduleInfoData {
		[XmlElement(ElementName = "SchoolInfos")]
		public SchoolInfos SchoolInfos { get; set; }
		[XmlAttribute(AttributeName = "Date")]
		public string Date { get; set; }
	}

	[XmlRoot(ElementName = "ClassListing")]
	public class ClassListing {
		[XmlElement(ElementName = "AdditionalStaffInformationXMLs")]
		public string AdditionalStaffInformationXMLs { get; set; }
		[XmlAttribute(AttributeName = "Period")]
		public string Period { get; set; }
		[XmlAttribute(AttributeName = "CourseTitle")]
		public string CourseTitle { get; set; }
		[XmlAttribute(AttributeName = "RoomName")]
		public string RoomName { get; set; }
		[XmlAttribute(AttributeName = "Teacher")]
		public string Teacher { get; set; }
		[XmlAttribute(AttributeName = "TeacherEmail")]
		public string TeacherEmail { get; set; }
		[XmlAttribute(AttributeName = "SectionGU")]
		public string SectionGU { get; set; }
		[XmlAttribute(AttributeName = "TeacherStaffGU")]
		public string TeacherStaffGU { get; set; }
	}

	[XmlRoot(ElementName = "ClassLists")]
	public class ClassLists {
		[XmlElement(ElementName = "ClassListing")]
		public List<ClassListing> ClassListing { get; set; }
	}

	[XmlRoot(ElementName = "TermDefCode")]
	public class TermDefCode {
		[XmlAttribute(AttributeName = "TermDefName")]
		public string TermDefName { get; set; }
	}

	[XmlRoot(ElementName = "TermDefCodes")]
	public class TermDefCodes {
		[XmlElement(ElementName = "TermDefCode")]
		public List<TermDefCode> TermDefCode { get; set; }
	}

	[XmlRoot(ElementName = "TermListing")]
	public class TermListing {
		[XmlElement(ElementName = "TermDefCodes")]
		public TermDefCodes TermDefCodes { get; set; }
		[XmlAttribute(AttributeName = "TermIndex")]
		public string TermIndex { get; set; }
		[XmlAttribute(AttributeName = "TermCode")]
		public string TermCode { get; set; }
		[XmlAttribute(AttributeName = "TermName")]
		public string TermName { get; set; }
		[XmlAttribute(AttributeName = "BeginDate")]
		public string BeginDate { get; set; }
		[XmlAttribute(AttributeName = "EndDate")]
		public string EndDate { get; set; }
		[XmlAttribute(AttributeName = "SchoolYearTrmCodeGU")]
		public string SchoolYearTrmCodeGU { get; set; }
	}

	[XmlRoot(ElementName = "TermLists")]
	public class TermLists {
		[XmlElement(ElementName = "TermListing")]
		public List<TermListing> TermListing { get; set; }
	}

	[XmlRoot(ElementName = "StudentClassSchedule")]
	public class StudentClassSchedule {
		[XmlElement(ElementName = "TodayScheduleInfoData")]
		public TodayScheduleInfoData TodayScheduleInfoData { get; set; }
		[XmlElement(ElementName = "ClassLists")]
		public ClassLists ClassLists { get; set; }
		[XmlElement(ElementName = "TermLists")]
		public TermLists TermLists { get; set; }
		[XmlElement(ElementName = "ConcurrentSchoolStudentClassSchedules")]
		public string ConcurrentSchoolStudentClassSchedules { get; set; }
		[XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsd { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
		[XmlAttribute(AttributeName = "TermIndex")]
		public string TermIndex { get; set; }
		[XmlAttribute(AttributeName = "TermIndexName")]
		public string TermIndexName { get; set; }
		[XmlAttribute(AttributeName = "ErrorMessage")]
		public string ErrorMessage { get; set; }
		[XmlAttribute(AttributeName = "IncludeAdditionalStaffWhenEmailingTeachers")]
		public string IncludeAdditionalStaffWhenEmailingTeachers { get; set; }
	}

}

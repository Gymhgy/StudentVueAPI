using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace StudentVueAPI {
	[XmlRoot(ElementName = "ReportPeriod")]
	public class ReportPeriod {
		[XmlAttribute(AttributeName = "Index")]
		public string Index { get; set; }
		[XmlAttribute(AttributeName = "GradePeriod")]
		public string GradePeriod { get; set; }
		[XmlAttribute(AttributeName = "StartDate")]
		public string StartDate { get; set; }
		[XmlAttribute(AttributeName = "EndDate")]
		public string EndDate { get; set; }
	}

	[XmlRoot(ElementName = "ReportingPeriods")]
	public class ReportingPeriods {
		[XmlElement(ElementName = "ReportPeriod")]
		public List<ReportPeriod> ReportPeriod { get; set; }
	}

	[XmlRoot(ElementName = "ReportingPeriod")]
	public class ReportingPeriod {
		[XmlAttribute(AttributeName = "GradePeriod")]
		public string GradePeriod { get; set; }
		[XmlAttribute(AttributeName = "StartDate")]
		public string StartDate { get; set; }
		[XmlAttribute(AttributeName = "EndDate")]
		public string EndDate { get; set; }
	}

	[XmlRoot(ElementName = "AssignmentGradeCalc")]
	public class AssignmentGradeCalc {
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "Weight")]
		public string Weight { get; set; }
		[XmlAttribute(AttributeName = "Points")]
		public string Points { get; set; }
		[XmlAttribute(AttributeName = "PointsPossible")]
		public string PointsPossible { get; set; }
		[XmlAttribute(AttributeName = "WeightedPct")]
		public string WeightedPct { get; set; }
		[XmlAttribute(AttributeName = "CalculatedMark")]
		public string CalculatedMark { get; set; }
	}

	[XmlRoot(ElementName = "GradeCalculationSummary")]
	public class GradeCalculationSummary {
		[XmlElement(ElementName = "AssignmentGradeCalc")]
		public List<AssignmentGradeCalc> AssignmentGradeCalc { get; set; }
	}

	[XmlRoot(ElementName = "Assignment")]
	public class Assignment {
		[XmlElement(ElementName = "Standards")]
		public string Standards { get; set; }
		[XmlAttribute(AttributeName = "GradebookID")]
		public string GradebookID { get; set; }
		[XmlAttribute(AttributeName = "Measure")]
		public string Measure { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "Date")]
		public string Date { get; set; }
		[XmlAttribute(AttributeName = "DueDate")]
		public string DueDate { get; set; }
		[XmlAttribute(AttributeName = "Score")]
		public string Score { get; set; }
		[XmlAttribute(AttributeName = "ScoreType")]
		public string ScoreType { get; set; }
		[XmlAttribute(AttributeName = "Points")]
		public string Points { get; set; }
		[XmlAttribute(AttributeName = "Notes")]
		public string Notes { get; set; }
		[XmlAttribute(AttributeName = "TeacherID")]
		public string TeacherID { get; set; }
		[XmlAttribute(AttributeName = "StudentID")]
		public string StudentID { get; set; }
		[XmlAttribute(AttributeName = "MeasureDescription")]
		public string MeasureDescription { get; set; }
		[XmlAttribute(AttributeName = "HasDropBox")]
		public string HasDropBox { get; set; }
		[XmlAttribute(AttributeName = "DropStartDate")]
		public string DropStartDate { get; set; }
		[XmlAttribute(AttributeName = "DropEndDate")]
		public string DropEndDate { get; set; }
		[XmlElement(ElementName = "Resources")]
		public Resources Resources { get; set; }
	}

	[XmlRoot(ElementName = "Assignments")]
	public class Assignments {
		[XmlElement(ElementName = "Assignment")]
		public List<Assignment> Assignment { get; set; }
	}

	[XmlRoot(ElementName = "Mark")]
	public class Mark {
		[XmlElement(ElementName = "StandardViews")]
		public string StandardViews { get; set; }
		[XmlElement(ElementName = "GradeCalculationSummary")]
		public GradeCalculationSummary GradeCalculationSummary { get; set; }
		[XmlElement(ElementName = "Assignments")]
		public Assignments Assignments { get; set; }
		[XmlAttribute(AttributeName = "MarkName")]
		public string MarkName { get; set; }
		[XmlAttribute(AttributeName = "CalculatedScoreString")]
		public string CalculatedScoreString { get; set; }
		[XmlAttribute(AttributeName = "CalculatedScoreRaw")]
		public string CalculatedScoreRaw { get; set; }
	}

	[XmlRoot(ElementName = "Marks")]
	public class Marks {
		[XmlElement(ElementName = "Mark")]
		public Mark Mark { get; set; }
	}

	[XmlRoot(ElementName = "Course")]
	public class Course {
		[XmlElement(ElementName = "Marks")]
		public Marks Marks { get; set; }
		[XmlAttribute(AttributeName = "UsesRichContent")]
		public string UsesRichContent { get; set; }
		[XmlAttribute(AttributeName = "Period")]
		public string Period { get; set; }
		[XmlAttribute(AttributeName = "Title")]
		public string Title { get; set; }
		[XmlAttribute(AttributeName = "Room")]
		public string Room { get; set; }
		[XmlAttribute(AttributeName = "Staff")]
		public string Staff { get; set; }
		[XmlAttribute(AttributeName = "StaffEMail")]
		public string StaffEMail { get; set; }
		[XmlAttribute(AttributeName = "StaffGU")]
		public string StaffGU { get; set; }
		[XmlAttribute(AttributeName = "HighlightPercentageCutOffForProgressBar")]
		public string HighlightPercentageCutOffForProgressBar { get; set; }
	}

	[XmlRoot(ElementName = "Resource")]
	public class Resource {
		[XmlAttribute(AttributeName = "ClassID")]
		public string ClassID { get; set; }
		[XmlAttribute(AttributeName = "FileType")]
		public string FileType { get; set; }
		[XmlAttribute(AttributeName = "GradebookID")]
		public string GradebookID { get; set; }
		[XmlAttribute(AttributeName = "ResourceDate")]
		public string ResourceDate { get; set; }
		[XmlAttribute(AttributeName = "ResourceDescription")]
		public string ResourceDescription { get; set; }
		[XmlAttribute(AttributeName = "ResourceID")]
		public string ResourceID { get; set; }
		[XmlAttribute(AttributeName = "ResourceName")]
		public string ResourceName { get; set; }
		[XmlAttribute(AttributeName = "Sequence")]
		public string Sequence { get; set; }
		[XmlAttribute(AttributeName = "TeacherID")]
		public string TeacherID { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "URL")]
		public string URL { get; set; }
		[XmlAttribute(AttributeName = "ServerFileName")]
		public string ServerFileName { get; set; }
	}

	[XmlRoot(ElementName = "Resources")]
	public class Resources {
		[XmlElement(ElementName = "Resource")]
		public List<Resource> Resource { get; set; }
	}

	[XmlRoot(ElementName = "Courses")]
	public class Courses {
		[XmlElement(ElementName = "Course")]
		public List<Course> Course { get; set; }
	}

	[XmlRoot(ElementName = "Gradebook")]
	public class Gradebook {
		[XmlElement(ElementName = "ReportingPeriods")]
		public ReportingPeriods ReportingPeriods { get; set; }
		[XmlElement(ElementName = "ReportingPeriod")]
		public ReportingPeriod ReportingPeriod { get; set; }
		[XmlElement(ElementName = "Courses")]
		public Courses Courses { get; set; }
		[XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsd { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "ErrorMessage")]
		public string ErrorMessage { get; set; }
		[XmlAttribute(AttributeName = "HideStandardGraphInd")]
		public string HideStandardGraphInd { get; set; }
		[XmlAttribute(AttributeName = "HideMarksColumnElementary")]
		public string HideMarksColumnElementary { get; set; }
		[XmlAttribute(AttributeName = "HidePointsColumnElementary")]
		public string HidePointsColumnElementary { get; set; }
		[XmlAttribute(AttributeName = "HidePercentSecondary")]
		public string HidePercentSecondary { get; set; }
		[XmlAttribute(AttributeName = "DisplayStandardsData")]
		public string DisplayStandardsData { get; set; }
		[XmlAttribute(AttributeName = "GBStandardsTabDefault")]
		public string GBStandardsTabDefault { get; set; }
	}

}

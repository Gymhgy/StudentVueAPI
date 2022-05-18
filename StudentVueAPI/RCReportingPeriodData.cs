using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace StudentVueAPI {
	[XmlRoot(ElementName = "RCReportingPeriod")]
	public class RCReportingPeriod {
		[XmlAttribute(AttributeName = "ReportingPeriodGU")]
		public string ReportingPeriodGU { get; set; }
		[XmlAttribute(AttributeName = "ReportingPeriodName")]
		public string ReportingPeriodName { get; set; }
		[XmlAttribute(AttributeName = "EndDate")]
		public string EndDate { get; set; }
		[XmlAttribute(AttributeName = "Message")]
		public string Message { get; set; }
		[XmlAttribute(AttributeName = "DocumentGU")]
		public string DocumentGU { get; set; }
	}

	[XmlRoot(ElementName = "RCReportingPeriods")]
	public class RCReportingPeriods {
		[XmlElement(ElementName = "RCReportingPeriod")]
		public List<RCReportingPeriod> RCReportingPeriod { get; set; }
	}

	[XmlRoot(ElementName = "RCReportingPeriodData")]
	public class RCReportingPeriodData {
		[XmlElement(ElementName = "RCReportingPeriods")]
		public RCReportingPeriods RCReportingPeriods { get; set; }
		[XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsd { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
	}

}

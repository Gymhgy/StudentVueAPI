using System.Xml.Serialization;
using System.Collections.Generic;
namespace StudentVueAPI {
	[XmlRoot(ElementName = "StaffList")]
	public class StaffList {
		[XmlAttribute(AttributeName = "Name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "EMail")]
		public string EMail { get; set; }
		[XmlAttribute(AttributeName = "Title")]
		public string Title { get; set; }
		[XmlAttribute(AttributeName = "Phone")]
		public string Phone { get; set; }
		[XmlAttribute(AttributeName = "Extn")]
		public string Extn { get; set; }
		[XmlAttribute(AttributeName = "StaffGU")]
		public string StaffGU { get; set; }
	}

	[XmlRoot(ElementName = "StaffLists")]
	public class StaffLists {
		[XmlElement(ElementName = "StaffList")]
		public List<StaffList> StaffList { get; set; }
	}

	[XmlRoot(ElementName = "StudentSchoolInfoListing")]
	public class StudentSchoolInfoListing {
		[XmlElement(ElementName = "StaffLists")]
		public StaffLists StaffLists { get; set; }
		[XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsd { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
		[XmlAttribute(AttributeName = "School")]
		public string School { get; set; }
		[XmlAttribute(AttributeName = "Principal")]
		public string Principal { get; set; }
		[XmlAttribute(AttributeName = "SchoolAddress")]
		public string SchoolAddress { get; set; }
		[XmlAttribute(AttributeName = "SchoolAddress2")]
		public string SchoolAddress2 { get; set; }
		[XmlAttribute(AttributeName = "SchoolCity")]
		public string SchoolCity { get; set; }
		[XmlAttribute(AttributeName = "SchoolState")]
		public string SchoolState { get; set; }
		[XmlAttribute(AttributeName = "SchoolZip")]
		public string SchoolZip { get; set; }
		[XmlAttribute(AttributeName = "Phone")]
		public string Phone { get; set; }
		[XmlAttribute(AttributeName = "Phone2")]
		public string Phone2 { get; set; }
		[XmlAttribute(AttributeName = "URL")]
		public string URL { get; set; }
		[XmlAttribute(AttributeName = "PrincipalEmail")]
		public string PrincipalEmail { get; set; }
		[XmlAttribute(AttributeName = "PrincipalGu")]
		public string PrincipalGu { get; set; }
	}

}

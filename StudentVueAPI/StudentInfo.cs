using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Reflection;

namespace StudentVueAPI {

    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class StudentInfo {

        /// <remarks/>
        public object LockerInfoRecords { get; set; }

        /// <remarks/>
        public string FormattedName { get; set; }

        /// <remarks/>
        public uint PermID { get; set; }

        /// <remarks/>
        public string Gender { get; set; }

        /// <remarks/>
        public byte Grade { get; set; }

        /// <remarks/>
        public string Address { get; set; }

        /// <remarks/>
        public object LastNameGoesBy { get; set; }

        /// <remarks/>
        public object NickName { get; set; }

        /// <remarks/>
        public string BirthDate { get; set; }

        /// <remarks/>
        public string EMail { get; set; }

        /// <remarks/>
        public string Phone { get; set; }

        /// <remarks/>
        public object HomeLanguage { get; set; }

        /// <remarks/>
        public string CurrentSchool { get; set; }

        /// <remarks/>
        public object Track { get; set; }

        /// <remarks/>
        public string HomeRoomTch { get; set; }

        /// <remarks/>
        public string HomeRoomTchEMail { get; set; }

        /// <remarks/>
        public string HomeRoomTchStaffGU { get; set; }

        /// <remarks/>
        public string OrgYearGU { get; set; }

        /// <remarks/>
        public string HomeRoom { get; set; }

        /// <remarks/>
        public string CounselorName { get; set; }

        /// <remarks/>
        public string CounselorEmail { get; set; }

        /// <remarks/>
        public string CounselorStaffGU { get; set; }

        /// <remarks/>
        public string Photo { get; set; }

        /// <remarks/>
        public StudentInfoEmergencyContacts EmergencyContacts { get; set; }

        /// <remarks/>
        public StudentInfoPhysician Physician { get; set; }

        /// <remarks/>
        public StudentInfoDentist Dentist { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem("UserDefinedGroupBox", IsNullable = false)]
        public StudentInfoUserDefinedGroupBox[] UserDefinedGroupBoxes { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public bool ShowPhysicianAndDentistInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public bool ShowStudentInfo { get; set; }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class StudentInfoEmergencyContacts {

        /// <remarks/>
        public StudentInfoEmergencyContactsEmergencyContact EmergencyContact { get; set; }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class StudentInfoEmergencyContactsEmergencyContact {  

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Relationship { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string HomePhone { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string WorkPhone { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string OtherPhone { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string MobilePhone { get; set; }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class StudentInfoPhysician {   

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Hospital { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Phone { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Extn { get; set; }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class StudentInfoDentist {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Office { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Phone { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Extn { get; set; }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class StudentInfoUserDefinedGroupBox { 

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem("UserDefinedItem", IsNullable = false)]
        public StudentInfoUserDefinedGroupBoxUserDefinedItem[] UserDefinedItems { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string GroupBoxLabel { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string GroupBoxID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string VCID { get; set; }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class StudentInfoUserDefinedGroupBoxUserDefinedItem {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string ItemLabel { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string ItemType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string SourceObject { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string SourceElement { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string VCID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Value { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Rev_Text { get; set; }
    }
}

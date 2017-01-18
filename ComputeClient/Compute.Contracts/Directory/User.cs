namespace DD.CBU.Compute.Api.Contracts.Directory
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class UsersResponseCollection
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("user")]
        public UserType[] user;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageNumber;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageNumberSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageCount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageCountSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int totalCount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalCountSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageSize;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageSizeSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("user", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class UserType
    {

        /// <remarks/>
        public string userName;

        /// <remarks/>
        public string fullName;

        /// <remarks/>
        public string firstName;

        /// <remarks/>
        public string lastName;

        /// <remarks/>
        public string emailAddress;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("role")]
        public string[] role;

        /// <remarks/>
        public PhoneType phone;

        /// <remarks/>
        public string department;

        /// <remarks/>
        public string customDefined1;

        /// <remarks/>
        public string customDefined2;

        /// <remarks/>
        public UserTypeOrganization organization;

        /// <remarks/>
        public string state;

        /// <remarks/>
        public System.DateTime createTime;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createTimeSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class UserTypeOrganization
    {

        /// <remarks/>
        public string name;

        /// <remarks/>
        public string homeGeoName;

        /// <remarks/>
        public string homeGeoApiHost;

        /// <remarks/>
        public string homeGeoId;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class PhoneType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string countryCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string number;
    }
}

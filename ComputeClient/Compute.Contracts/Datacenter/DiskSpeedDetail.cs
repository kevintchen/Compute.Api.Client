using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DD.CBU.Compute.Api.Contracts.Datacenter
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class VariableIopLimitsType
    {

        /// <remarks/>
        public int minDiskIops;

        /// <remarks/>
        public int maxDiskIops;

        /// <remarks/>
        public int minIopsPerGb;

        /// <remarks/>
        public int maxIopsPerGb;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class DiskSpeedDetail : IDiskSpeedDetail
    {
        /// <remarks/>
        [XmlElement("displayName")]
        public string DisplayName { get; }

        /// <remarks/>
        [XmlElement("abbreviation")]
        public string Abbreviation { get; }

        /// <remarks/>
        [XmlElement("description")]
        public string Description { get; }

        /// <remarks/>
        [XmlElement("unavailableReason")]
        public string UnavailableReason { get; }

        /// <remarks/>
        [XmlElement("variableIopLimits")]
        public VariableIopLimitsType VariableIopLimits { get; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public string Id { get; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default")]
        public bool IsDefault { get; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("available")]
        public bool IsAvailable { get; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("variableIops")]
        public bool IsVariableIops { get; }
    }
}

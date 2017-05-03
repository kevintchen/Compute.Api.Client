using System.Linq;
using DD.CBU.Compute.Api.Contracts.Network20;

namespace DD.CBU.Compute.Api.Contracts.Image20
{
    public partial class HistoricalImageExportIdeControllerType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ImageIdeDeviceType[] device => Items?.OfType<ImageIdeDeviceType>().ToArray();

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ImageIdeDiskType[] disk => Items?.OfType<ImageIdeDiskType>().ToArray();
    }

    public partial class HistoricalImageExportSataControllerType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public HistoricalImageExportSataDeviceType[] device => Items?.OfType<HistoricalImageExportSataDeviceType>().ToArray();

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public HistoricalImageExportSataDiskType[] disk => Items?.OfType<HistoricalImageExportSataDiskType>().ToArray();
    }
}

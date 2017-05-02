using DD.CBU.Compute.Api.Contracts.Network20;

namespace DD.CBU.Compute.Api.Contracts.Image20
{
    public partial class HistoricalImageExportIdeControllerType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public HistoricalImageExportIdeDeviceType[] device
        {
            get { return Items as HistoricalImageExportIdeDeviceType[]; }
            set
            {
                if (value != null || Items is HistoricalImageExportIdeDeviceType[])
                    Items = value as HistoricalImageExportIdeDeviceType[];
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public HistoricalImageExportIdeDiskType[] disk
        {
            get { return Items as HistoricalImageExportIdeDiskType[]; }
            set
            {
                if (value != null || Items is HistoricalImageExportIdeDiskType[])
                    Items = value as HistoricalImageExportIdeDiskType[];
            }
        }
    }

    public partial class HistoricalImageExportSataControllerType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public HistoricalImageExportSataDeviceType[] device
        {
            get { return Items as HistoricalImageExportSataDeviceType[]; }
            set
            {
                if (value != null || Items is HistoricalImageExportSataDeviceType[])
                    Items = value as HistoricalImageExportSataDeviceType[];
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public HistoricalImageExportSataDiskType[] disk
        {
            get { return Items as HistoricalImageExportSataDiskType[]; }
            set
            {
                if (value != null || Items is HistoricalImageExportSataDiskType[])
                    Items = value as HistoricalImageExportSataDiskType[];
            }
        }
    }
}

using System.Linq;
using DD.CBU.Compute.Api.Contracts.Network20;

namespace DD.CBU.Compute.Api.Contracts.Image20
{
    public partial class HistoricalImageExportIdeControllerType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public HistoricalImageExportIdeDeviceType[] device
        {
            get
            {
                return Items != null && Items.Any(x => x.GetType() == typeof(HistoricalImageExportIdeDeviceType))
                    ? (Items.Where(x => x.GetType() == typeof(HistoricalImageExportIdeDeviceType)).ToArray()) as
                        HistoricalImageExportIdeDeviceType[]
                    : null;

            }
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
            get
            {
                return Items != null && Items.Any(x => x.GetType() == typeof(HistoricalImageExportIdeDiskType))
                    ? (Items.Where(x => x.GetType() == typeof(HistoricalImageExportIdeDiskType)).ToArray()) as
                        HistoricalImageExportIdeDiskType[]
                    : null;

            }
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
            get
            {
                return Items != null && Items.Any(x => x.GetType() == typeof(HistoricalImageExportSataDeviceType))
                    ? (Items.Where(x => x.GetType() == typeof(HistoricalImageExportSataDeviceType)).ToArray()) as
                        HistoricalImageExportSataDeviceType[]
                    : null;

            }
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
            get
            {
                return Items != null && Items.Any(x => x.GetType() == typeof(HistoricalImageExportSataDiskType))
                    ? (Items.Where(x => x.GetType() == typeof(HistoricalImageExportSataDiskType)).ToArray()) as
                        HistoricalImageExportSataDiskType[]
                    : null;

            }
            set
            {
                if (value != null || Items is HistoricalImageExportSataDiskType[])
                    Items = value as HistoricalImageExportSataDiskType[];
            }
        }
    }
}

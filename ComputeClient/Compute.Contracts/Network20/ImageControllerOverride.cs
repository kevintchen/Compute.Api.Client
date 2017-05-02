using System.Linq;

namespace DD.CBU.Compute.Api.Contracts.Network20
{

    public partial class ImageSataControllerType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ImageSataDeviceType[] device
        {
            get
            {
                return Items != null && Items.Any(x => x.GetType() == typeof(ImageSataDeviceType))
                    ? (Items.Where(x => x.GetType() == typeof(ImageSataDeviceType)).ToArray()) as
                        ImageSataDeviceType[]
                    : null;

            }
            set
            {
                if (value != null || Items is ImageSataDeviceType[])
                    Items = value as ImageSataDeviceType[];
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ImageSataDiskType[] disk
        {
            get
            {
                return Items != null && Items.Any(x => x.GetType() == typeof(ImageSataDiskType))
                    ? (Items.Where(x => x.GetType() == typeof(ImageSataDiskType)).ToArray()) as
                        ImageSataDiskType[]
                    : null;

            }
            set
            {
                if (value != null || Items is ImageSataDiskType[])
                    Items = value as ImageSataDiskType[];
            }
        }
    }

    public partial class ImageIdeControllerType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ImageIdeDeviceType[] device
        {
            get
            {
                return Items != null && Items.Any(x => x.GetType() == typeof(ImageIdeDeviceType))
                    ? (Items.Where(x => x.GetType() == typeof(ImageIdeDeviceType)).ToArray()) as
                        ImageIdeDeviceType[]
                    : null;

            }
            set
            {
                if (value != null || Items is ImageIdeDeviceType[])
                    Items = value as ImageIdeDeviceType[];
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ImageIdeDiskType[] disk
        {
            get
            {
                return Items != null && Items.Any(x => x.GetType() == typeof(ImageIdeDiskType))
                    ? (Items.Where(x => x.GetType() == typeof(ImageIdeDiskType)).ToArray()) as
                        ImageIdeDiskType[]
                    : null;

            }
            set
            {
                if (value != null || Items is ImageIdeDiskType[])
                    Items = value as ImageIdeDiskType[];
            }
        }
    }
}
namespace DD.CBU.Compute.Api.Contracts.Network20
{

    public partial class ImageSataControllerType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ImageSataDeviceType[] device
        {
            get { return Items as ImageSataDeviceType[]; }
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
            get { return Items as ImageSataDiskType[]; }
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
            get { return Items as ImageIdeDeviceType[]; }
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
            get { return Items as ImageIdeDiskType[]; }
            set
            {
                if (value != null || Items is ImageIdeDiskType[])
                    Items = value as ImageIdeDiskType[];
            }
        }
    }
}
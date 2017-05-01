namespace DD.CBU.Compute.Api.Contracts.Network20
{

    public partial class ServerSataControllerType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ServerSataDeviceType[] device
        {
            get { return Items as ServerSataDeviceType[]; }
            set
            {
                if (value != null || Items is ServerSataDeviceType[])
                    Items = value as ServerSataDeviceType[];
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ServerSataDiskType[] disk
        {
            get { return Items as ServerSataDiskType[]; }
            set
            {
                if (value != null || Items is ServerSataDiskType[])
                    Items = value as ServerSataDiskType[];
            }
        }
    }

    public partial class ServerIdeControllerType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ServerIdeDeviceType[] device
        {
            get { return Items as ServerIdeDeviceType[]; }
            set
            {
                if (value != null || Items is ServerIdeDeviceType[])
                    Items = value as ServerIdeDeviceType[];
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ServerIdeDiskType[] disk
        {
            get { return Items as ServerIdeDiskType[]; }
            set
            {
                if (value != null || Items is ServerIdeDiskType[])
                    Items = value as ServerIdeDiskType[];
            }
        }
    }
}
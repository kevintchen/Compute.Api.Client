using System.Collections.Generic;
using System.Linq;

namespace DD.CBU.Compute.Api.Contracts.Network20
{

    public partial class ServerSataControllerType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ServerSataDeviceType[] device
        {
            get
            {
                return Items != null && Items.Any(x => x.GetType() == typeof (ServerSataDeviceType))
                    ? (Items.Where(x => x.GetType() == typeof (ServerSataDeviceType)).ToArray()) as
                        ServerSataDeviceType[]
                    : null;

            }
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
            get
            {
                return Items != null && Items.Any(x => x.GetType() == typeof(ServerSataDiskType))
                    ? (Items.Where(x => x.GetType() == typeof(ServerSataDiskType)).ToArray()) as
                        ServerSataDiskType[]
                    : null;

            }
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
            get
            {
                return Items != null && Items.Any(x => x.GetType() == typeof(ServerIdeDeviceType))
                    ? (Items.Where(x => x.GetType() == typeof(ServerIdeDeviceType)).ToArray()) as
                        ServerIdeDeviceType[]
                    : null;

            }
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
            get
            {
                return Items != null && Items.Any(x => x.GetType() == typeof(ServerIdeDiskType))
                    ? (Items.Where(x => x.GetType() == typeof(ServerIdeDiskType)).ToArray()) as
                        ServerIdeDiskType[]
                    : null;

            }
            set
            {
                if (value != null || Items is ServerIdeDiskType[])
                    Items = value as ServerIdeDiskType[];
            }
        }
    }
}
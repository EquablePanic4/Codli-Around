using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Around.Modele
{
    class NetworkInterfaceModel
    {
        public string InterfaceName { private set; get; }
        public string IpAddress { private set; get; }

        public NetworkInterfaceModel(string IPAddress, string Interface)
        {
            InterfaceName = Interface;
            IpAddress = IPAddress;
        }
    }
}

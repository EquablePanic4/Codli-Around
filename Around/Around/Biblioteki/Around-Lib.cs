using Around.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Around.Biblioteki
{
    static class Around_Lib
    {
        public static string GenerateNewConnectionKey(string ip)
        {
            //Teraz konwertujemy nasz adres ip do tablicy integerów
            var segmentsStr = ip.Split('.');
            var segmentsInt = new int[4];

            var Conte = 0;
            while (Conte < 4)
            {
                segmentsInt[Conte] = int.Parse(segmentsStr[Conte]);
                Conte++;
            }

            //Teraz musimy przekonwertować naszą tablicę na wartości hexadecymalne
            Conte = 0;
            while (Conte < 4)
            {
                segmentsStr[Conte] = segmentsInt[Conte].ToString("X");

                //I teraz musimy sprawdzić czy nasza wartość ma aby na pewno dwa znaki
                if (segmentsStr[Conte].Length == 1)
                    segmentsStr[Conte] = "0" + segmentsStr[Conte];

                Conte++;
            }

            //I teraz tworzymy finalną wartość
            var ipKey = segmentsStr[0] + segmentsStr[1] + "-" + segmentsStr[2] + segmentsStr[3];
            return ipKey;
        }

        public static string GetIpByConnectionKey(string conKey)
        {
            //Od razu tworzymy czteroelementową tablicę integerów
            var integers = new int[4];

            //I teraz aby zoptymalizować działanie programu, własnoręcznie przypiszemy wszystkie wartości
            integers[0] = int.Parse(conKey[0].ToString() + conKey[1].ToString(), System.Globalization.NumberStyles.HexNumber);
            integers[1] = int.Parse(conKey[2].ToString() + conKey[3].ToString(), System.Globalization.NumberStyles.HexNumber);
            integers[2] = int.Parse(conKey[5].ToString() + conKey[6].ToString(), System.Globalization.NumberStyles.HexNumber);
            integers[3] = int.Parse(conKey[7].ToString() + conKey[8].ToString(), System.Globalization.NumberStyles.HexNumber);

            //I teraz również ręcznie zwrócimy tę wartość
            return (integers[0] + "." + integers[1] + "." + integers[2] + "." + integers[3]);
        }

        public static List<NetworkInterfaceModel> GetLocalIPAddress()
        {
            //Jeżeli mamy w komputerze tylko jeden adapter sieciowy, nie będzie większych problemów
            var host = Dns.GetHostEntry(Dns.GetHostName());
            if (host.AddressList.Count() <= 1)
            {
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        var lista = new List<NetworkInterfaceModel>();
                        lista.Add(new NetworkInterfaceModel(ip.ToString(), "only one"));
                        return lista;
                    }
                }
                throw new Exception("No network adapters with an IPv4 address in the system!");
            }

            else
            {
                //Ale jeżeli mamy kilka... :/
                var lista = new List<NetworkInterfaceModel>();
                foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                    {
                        foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                lista.Add(new NetworkInterfaceModel(ip.Address.ToString(), ni.Name));
                            }
                        }
                    }
                }

                return lista;
            }
        }

        public static bool IsIpCorrect(string AdresIP)
        {
            //Dzielimy Adres IP na cztery segmenty
            var arr = AdresIP.Split('.');

            //Jeżeli tablica ma więcej lub mniej niż 4 pozycje, adres IP jest błędny - odrzucamy
            if (arr.Length != 4)
                return false;

            //I teraz próbujemy przekształcić to na tablicę integerów
            var IntIpArr = new int[4];
            var Conte = 0;

            while (Conte < 4)
            {
                bool parseOk = int.TryParse(arr[Conte], out IntIpArr[Conte]);
                if (parseOk == false)
                    return false;

                Conte++;
            }

            //Jako że nie mamy maski sieci, możemy jedynie zweryfikować czy każdy segment mieści się w przedziale <0; 255>
            foreach (var e in IntIpArr)
                if (e < 0 || e > 255)
                    return false;

            //Jeżeli doszliśmy do tego miejsca, adres IP jest maksymalnie poprawny, szkoda czasu na weryfikację skrajnych przypadków z maską
            return true;
        }
    }
}

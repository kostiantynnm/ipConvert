using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ip
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an IP address in decimal (tamplate *.*.*.*)    ");
            string ipAddress = Console.ReadLine();
            string binaryIP = Convert_dp_to_binario(ipAddress);
            Console.WriteLine(binaryIP);
            Console.ReadLine();
        }
        static int[] SplitIP(string ipString)
        {
            string[] ip = ipString.Split('.');
            int[] result = new int[ip.Length];
            for (int i = 0; i < ip.Length; i++)
            {
                if (int.TryParse(ip[i], out int parsedValue))
                {
                    result[i] = parsedValue;
                }
                else
                {
                    Console.WriteLine("error");
                    
                }
            }
            return result;
        }
        static string Convert_dp_to_binario(string ip)
        {
            int[] octets = SplitIP(ip);
            //Console.WriteLine(octets.Length);
            if (octets.Length != 4)
            {
                return "Ip address entered wrong";
            }
            for (int i = 0; i < octets.Length; i++)
            {
                int octet = Convert.ToInt32(octets[i]);
                
                string binary = "";
                while (octet > 0)
                {
                    int remainder = octet % 2;
                    binary = remainder + binary;
                    octet /= 2;
                }

                while (binary.Length < 8)
                {
                    binary = "0" + binary;
                }
                octets[i] = binary;
                //Console.WriteLine(octets[i]);
            }
            string binaryIP = string.Join(".", octets); ;

            return binaryIP;
        }
        /*static string DecimalToBinary(int decimalNumber)
        {
            string binary = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binary = remainder + binary;
                decimalNumber /= 2;
            }

            while (binary.Length < 8)
            {
                binary = "0" + binary;
            }
            return binary;
        }*/
    }
}
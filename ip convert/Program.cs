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
            int[] OctetsIP = ipStringToOctats(ipAddress);
            int[] dp = new int[] { 192, 168, 10, 5 };
            Convert_dp_to_binario(dp);
            Console.ReadLine();
        }

        static int[] ipStringToOctats(string ip)
        {
            string[] oct = ip.Split('.');
            int[] octets = Array.ConvertAll(oct, int.Parse);
            return octets;
        }
        static void Convert_dp_to_binario(int[] dp)
        {

            
        }

        
        

    }
}
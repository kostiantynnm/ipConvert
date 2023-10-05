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
            int[] ip = SplitIP(Console.ReadLine());
            //Console.WriteLine(ConvertDpToIntero(ip));
            //ConvertDpToBinario(ip);
            //Console.ReadLine();
        }

        static bool[] ConvertDpToBinario(int[] dp)
        {
            bool [] binario = new bool[32];
            int x = 31;
            for(int i = 0; i < dp.Length; i++)
            {
                for(int j = 0; j < 8; j++, x--)
                {
                    binario[x] = dp[i] % 2 == 1;
                    dp[i] /= 2;
                    Console.WriteLine(binario[x]);
                }
            }

            return binario;
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
        
        static Int64 ConvertBinarioToIntero(bool[] bn)
        {
            Int64 result = 0;
            for(int i = 31; i >= 0; i--)
            {
                if (bn[i])
                {
                    result += (Int64)Math.Pow(2, i);
                }
            }

            return result;
        }

        
        static Int64 ConvertDpToIntero(int[] dp)
        {
            Int64 dec = 0;
            double j = 3;
            for (int i = 0; i < dp.Length; i++)
            {
                dec += dp[i] * (Int64)Math.Pow(256, j--);
            }
            return dec;
        }
        
        
    }
}
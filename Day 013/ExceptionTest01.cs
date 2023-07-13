using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for(int i =0; i<10; i++)
            {
                arr[i] = i;
                
            }
            try
            {
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("예외가 발생하여 프로그램을 종료합니다.");
                Environment.Exit(0);
            }

        }
    }
}

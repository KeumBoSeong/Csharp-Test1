using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTest04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mat m1 = Mat.Ones(3, 5, MatType.CV_8UC1);
            Mat m2 = Mat.Zeros(3, 5, MatType.CV_8UC1);
            Mat m3 = Mat.Eye(3, 3, MatType.CV_8UC1);

            Console.WriteLine("m1 : \n" + m1.Dump());

            Console.WriteLine("m2 : \n" + m1.Dump());

            Console.WriteLine("m3 : \n" + m1.Dump());

            m1.Dispose();
            m2.Dispose();
            m3.Dispose();
        }
    }
}

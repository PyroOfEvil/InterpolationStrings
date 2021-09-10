
using System.Globalization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            var pi = Math.PI;
            
            Console.WriteLine(DateTime.Now.ToString("MMMM dd, yyyy"));
            
            Console.WriteLine(DateTime.Now.ToString("yyyy.MM.dd"));
            
            Console.WriteLine("Day " + DateTime.Now.ToString("dd") + " of " + DateTime.Now.ToString("MMMM, yyyy"));
            
            Console.WriteLine("Year: " + DateTime.Now.ToString("yyyy,") + " Month: " + DateTime.Now.ToString("MM") + " Day:" + DateTime.Now.ToString("dd"));
            
            Console.WriteLine(String.Format("{0, 13}", date.DayOfWeek));
            
            Console.WriteLine("{0} {1}", String.Format("{0, 5}", DateTime.Now.ToString("HH:mm")), String.Format("{0, 13}", date.DayOfWeek));
           
            Console.WriteLine("h:{0}, m:{1}, s:{2}", DateTime.Now.ToString("HH"), DateTime.Now.ToString("mm"), DateTime.Now.ToString("ss"));
            
            Console.WriteLine("{0}.{1}.{2}.{3}.{4}.{5}", DateTime.Now.ToString("yyyy"), date.Month, DateTime.Now.ToString("dd"), 
            DateTime.Now.ToString("HH"), DateTime.Now.ToString("mm"), DateTime.Now.ToString("ss"));

            Console.WriteLine(String.Format("{0:C}", pi));

            Console.WriteLine("          " + "{0}", String.Format("{0:F3}", pi));
            
           //I think all the alignments are right I cant quite figure out how to right allign the last one for 10 spaces I eyeballed all the other ones
           //I added a few spaces since when I put 10 it looked less then 10 
        }
    }
}

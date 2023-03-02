using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String applicaton = initProp();
            Console.WriteLine(applicaton);

        }

        public static string initProp()
        {
            var Properties = new IProperties(@"D:\Venkat-Freelancing-Project\Csharp-Framework\Selenium-Framework\GlobalSettings.config");
            String uname = Properties.Get("ProjectName");
            return uname;
        }
    }
}

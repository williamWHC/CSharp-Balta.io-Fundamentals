using System;

namespace DataExempleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // DateTime date = new DateTime(2022, 04, 09, 18, 25, 07);
            // Console.WriteLine(date.Year);
            // Console.WriteLine(date.Month);
            // Console.WriteLine(date.Day);
            // Console.WriteLine(date.Hour);
            // Console.WriteLine(date.Minute);
            // Console.WriteLine(date.Second);
            // Console.WriteLine(date.DayOfWeek);
            // Console.WriteLine((int)date.DayOfWeek);

            DateTime data = DateTime.Now;
            //Formatar a data para string
            // string formating = String.Format($"{data:dd/MM/yyyy hh:mm:ss ff z}");
            string formating = String.Format($"{data:ff}");
            Console.WriteLine(formating);

        }
    }
}

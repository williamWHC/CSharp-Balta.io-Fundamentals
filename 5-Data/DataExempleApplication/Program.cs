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
            //Formatar o tipo DatTime para manipular string
            // string formating = String.Format($"{data:dd/MM/yyyy hh:mm:ss ff z}");
            // string formating = String.Format($"{data:t}");       //Shorts Date time Output => 19:30
            // string formating = String.Format($"{data:d}");       // retorna a data sem os digitos zeros
            // string formating = String.Format("{0:T}", data);     // Retorna o tempo longo e duração longa Output => 19:34:58
            // string formating = String.Format("{0:D}", data);     // Retorna dia da semana e data completa Output => sábado, 9 de abril de 2022
            // string formating = String.Format("{0:f}", data);     // sábado, 9 de abril de 2022 20:57
            // string formating = String.Format("{0:g}", data);     // Converte em data e hora Output => 09/04/2022 21:02
            // string formating = String.Format("{0:y}", data);     // Pega Mês e Ano Output => abril de 2022
            // string formating = String.Format("{0:r}", data);     // Output => Sat, 09 Apr 2022 21:05:44 GMT
            // string formating = String.Format("{0:R}", data);     // Output => Sat, 09 Apr 2022 21:06:19 GMT
            // string formating = String.Format("{0:s}", data);     // Output => 2022-04-09T21:07:36
            string formating = String.Format("{0:u}", data);        // Output => 2022-04-09 21:08:44Z
            Console.WriteLine(formating);

        }
    }
}

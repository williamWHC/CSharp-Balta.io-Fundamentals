using System;
using System.Threading;

namespace Stopwatch
{
    class Programdad
    {
        static void Main(string[] args)
        {
            Menu();
        }

        #region Metodo preStart com mensagem de preparação
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }
        #endregion

        #region Metodo do menu
        static void Menu()
        {

            string data;
            char type;
            int time;
            int multiplier;

            Console.Clear();
            Console.WriteLine("S =0 Segundos");
            Console.WriteLine("M = Minutos");
            Console.WriteLine("0 = Sair");
            Console.Write("Qual Opção Deseja Escolher: ");

            data = Console.ReadLine().ToLower().Trim();
            type = char.Parse(data.Substring(data.Length - 1, 1));
            time = short.Parse(data.Substring(0, data.Length - 1));
            multiplier = 1;

            //Verifica se for em minutos
            if (type == 'm')
                multiplier = 60;

            //Verifica se for para sair
            if (time == 0 || data == "0s" || data == "0m")
                System.Environment.Exit(0);

            Start(time * multiplier);
        }
        #endregion

        #region Metodo que inicia o contador
        static void Start(int time)
        {
            Console.Clear();

            short currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }
        #endregion
    }
}

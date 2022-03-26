using System;

namespace NewApplicationCalculation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha a opção: ");
            Console.WriteLine("Opção 1 - Adição");
            Console.WriteLine("Opção 2 - Subtração");
            Console.WriteLine("Opção 3 - Multiplicação");
            Console.WriteLine("Opção 4 - Divisão");
            Console.WriteLine("Opção 0 - Sair");
            Console.WriteLine("-------------------------");
            Console.Write("Selecione a opção: ");

            ushort selectNunber = ushort.Parse(Console.ReadLine());


            switch (selectNunber)
            {
                case 1:
                    MenuSoma(1); break;
                case 2:
                    MenuSoma(2); break;
                case 3:
                    MenuSoma(3); break;
                case 4:
                    MenuSoma(4); break;
                case 0: System.Environment.Exit(0); break;
                default:
                    Console.WriteLine("Opção invalida");
                    ResetMenu(); break;

            }

        }

        static void MenuSoma(ushort selectNunber)
        {
            Console.Write("Digite o primeiro valor: ");
            float firstNunber = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float secondNunber = float.Parse(Console.ReadLine());

            switch (selectNunber)
            {
                case 1: Adicao(firstNunber, secondNunber); break;
                case 2: Subtracao(firstNunber, secondNunber); break;
                case 3: Multiplicacao(firstNunber, secondNunber); break;
                case 4: Divisao(firstNunber, secondNunber); break;
                default: Menu(); break;
            }


        }

        #region METODO ADIÇÃO

        static void Adicao(float firstNunber, float secondNunber)
        {
            Console.WriteLine($"{firstNunber} + {secondNunber} = {firstNunber + secondNunber}");
            ResetMenu();
        }
        #endregion

        #region METODO SUBTRAÇÃO
        static void Subtracao(float firstNunber, float secondNunber)
        {
            Console.WriteLine($"{firstNunber} - {secondNunber} = {firstNunber - secondNunber}");
            ResetMenu();
        }
        #endregion

        #region METODO MULTIPLICAÇÃO
        static void Multiplicacao(float firstNunber, float secondNunber)
        {
            Console.WriteLine($"{firstNunber} * {secondNunber} = {firstNunber * secondNunber}");
            ResetMenu();
        }
        #endregion

        #region METODO DIVISÃO
        static void Divisao(float firstNunber, float secondNunber)
        {
            Console.WriteLine($"{firstNunber} / {secondNunber} = {firstNunber / secondNunber}");
            ResetMenu();

        }
        #endregion
        static void ResetMenu()
        {
            Console.ReadKey();
            Menu();
        }
    }
}

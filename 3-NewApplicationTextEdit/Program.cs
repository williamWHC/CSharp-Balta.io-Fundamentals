using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        #region Menu do programa
        static void Menu()
        {
            short option;

            Console.Clear();
            Console.WriteLine("0 - Fechar");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar um novo arquivo");
            Console.Write("Digite a opção para a ação: ");
            option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: OpenFile(); break;
                case 2: CreatNewFile(); break;
                default: Menu(); break;
            }

        }
        #endregion
        static void OpenFile()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string rootPath = Console.ReadLine();

            using (var file = new StreamReader(rootPath))
            {

                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine();
            Console.ReadLine();
            Menu();
        }
        static void CreatNewFile()
        {
            Console.WriteLine("Digite o text para editar - (ESC - para sair)");
            Console.WriteLine("-------------------");
            string text = "";

            //faça isso enquanto não for apertado oscape
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            {
                SaveFile(text);
            }
        }

        #region Metodo que salva os dado no arquivo
        static void SaveFile(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho deseja salvar o arquivo?");
            string path = Console.ReadLine();

            //Abrir um arquivo / modificar e fechar.
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo salvo com sucesso, no caminho {path}");
            Console.ReadLine();
            Menu();

        }
        #endregion
    }
}
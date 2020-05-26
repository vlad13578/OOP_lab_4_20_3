using System;
using System.IO;

namespace OOP_lab_4_20_3
{
    class Input
    {
        public static void Key()
        {
            Work.Parse(Read(), false);

            Console.WriteLine("Додавання записiв: C");
            Console.WriteLine("Редагування записiв: E");
            Console.WriteLine("Знищення записiв: D");
            Console.WriteLine("Виведення записiв: Enter");
            Console.WriteLine("Пошук записiв: F");
            Console.WriteLine("Сортування записiв: K");
            Console.WriteLine("Вихiд: Esc");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.C:
                    Console.WriteLine();
                    Work.Add();
                    break;

                case ConsoleKey.E:
                    Console.WriteLine();
                    Work.Edit();
                    break;

                case ConsoleKey.D:
                    Console.WriteLine();
                    Work.Remove();
                    break;

                case ConsoleKey.Enter:
                    Console.WriteLine();
                    Output.Write(Program.teacher);
                    Key();
                    break;

                case ConsoleKey.F:
                    Console.WriteLine();
                    Work.Find();
                    break;

                case ConsoleKey.K:
                    Console.WriteLine();
                    Work.Sort();
                    break;

                case ConsoleKey.Escape:
                    return;
            }
        }
        public static string[] Read()
        {
            StreamReader fromFile = new StreamReader("teachers.txt");

            return fromFile.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

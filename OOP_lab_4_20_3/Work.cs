using System;
using System.IO;

namespace OOP_lab_4_20_3
{
    class Work
    {
        public static void Add()
        {
            Console.WriteLine("Введiть данi");

            string str = Console.ReadLine();

            string[] elements = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Parse(elements, true);

            Input.Key();
        }

        public static void Remove()
        {
            Console.Write("Кафедра: ");

            string chair = Console.ReadLine();

            bool[] write = new bool[Program.teacher.Length];

            for (int i = 0; i < Program.teacher.Length; ++i)
            {
                if (Program.teacher[i] != null)
                {
                    if (Program.teacher[i].Chair == chair)
                    {
                        Console.WriteLine("{0,-15} {1, -15} {2, -15} {3, -20} {4,-20} {5,-15} {6,-15} ", Program.teacher[i].Number, Program.teacher[i].LastName, Program.teacher[i].Name, Program.teacher[i].Surname, Program.teacher[i].Chair, Program.teacher[i].Sex, Program.teacher[i].Degree);

                        Console.WriteLine("Видалити? (Y/N)");

                        var key = Console.ReadKey().Key;

                        if (key == ConsoleKey.Y)
                        {
                            Program.delete[i] = true;
                        }
                        else
                        {
                            Program.delete[i] = false;
                        }
                    }
                }
            }
        }

        public static void Edit()
        {
            Console.Write("Кафедра: ");

            string chair = Console.ReadLine();

            bool[] write = new bool[Program.teacher.Length];

            for (int i = 0; i < Program.teacher.Length; ++i)
            {
                if (Program.teacher[i] != null)
                {
                    if (Program.teacher[i].Chair == chair)
                    {
                        Console.WriteLine("{0,-15} {1, -15} {2, -15} {3, -20} {4,-20} {5,-15} {6,-15} ", Program.teacher[i].Number, Program.teacher[i].LastName, Program.teacher[i].Name, Program.teacher[i].Surname, Program.teacher[i].Chair, Program.teacher[i].Sex, Program.teacher[i].Degree);

                        Console.WriteLine("Введiть нову iнформацiю");

                        string str = Console.ReadLine();

                        string[] elements = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                        Program.teacher[i] = new Teacher(int.Parse(elements[0]), elements[1], elements[2], elements[3], elements[4], elements[5], elements[6]);
                    }
                }
            }
            Input.Key();
        }

        public static void Find()
        {
            Console.Write("Кафедра: ");

            string chair = Console.ReadLine();

            bool[] write = new bool[Program.teacher.Length];

            for (int i = 0; i < Program.teacher.Length; ++i)
            {
                if (Program.teacher[i] != null)
                {
                    if (Program.teacher[i].Chair == chair)
                    {
                        write[i] = true;
                    }
                    else
                    {
                        write[i] = false;
                    }
                }

            }

            Output.Write(Program.teacher, write);

            Input.Key();
        }
        public static void Sort()
        {
            string[] array = { "Жарська", "Завада", "Коханок", "Косюра", "Кордуба", "Береза", "Мальок", "Ковалюк", "Шедний", "Пакалюк" };
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < array.Length - 1; ++i)
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        string buf = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = buf;
                        flag = true;
                    }
            }
            foreach (string s in array)
                Console.WriteLine("{0} ", s);
            Console.ReadKey();
        }
        private static void Save(Teacher s)
        {
            StreamWriter save = new StreamWriter("teachers.txt", true);

            save.WriteLine(s.Number);
            save.WriteLine(s.LastName);
            save.WriteLine(s.Name);
            save.WriteLine(s.Surname);
            save.WriteLine(s.Chair);
            save.WriteLine(s.Sex);
            save.WriteLine(s.Degree);

            save.Close();
        }

        public static void Parse(string[] elements, bool save)
        {
            int counter = 0;

            while (Program.teacher[counter] != null)
            {
                ++counter;
            }

            for (int i = 0; i < elements.Length; i += 7)
            {
                Program.teacher[counter + i / 7] = new Teacher(int.Parse(elements[i]), elements[i + 1], elements[i + 2], elements[i + 3], elements[i + 4], elements[i + 5], elements[i + 6]);
                if (save)
                {
                    Save(Program.teacher[counter + i / 7]);
                }
            }
        }
    }
}

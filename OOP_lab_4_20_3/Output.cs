using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_4_20_3
{
    class Output
    {
        public static void Write(Teacher[] s)
        {
            Console.WriteLine("{0,-15} {1, -15} {2, -15} {3, -20} {4,-20} {5,-15} {6,-15} ", "Номер", "Прiзвище", "Iм'я", "По батьковi", "Кафедра", "Стать", "Найковий ступiнь");

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] != null)
                {
                    Console.WriteLine("{0,-15} {1, -15} {2, -15} {3, -20} {4,-20} {5,-15} {6,-15} ", Program.teacher[i].Number, Program.teacher[i].LastName, Program.teacher[i].Name, Program.teacher[i].Surname, Program.teacher[i].Chair, Program.teacher[i].Sex, Program.teacher[i].Degree);
                }
            }
        }

        public static void Write(Teacher[] s, bool[] write)
        {
            Console.WriteLine("{0,-15} {1, -15} {2, -15} {3, -20} {4,-20} {5,-15} {6,-15} ", "Номер", "Прiзвище", "Iм'я", "По батьковi", "Кафедра", "Стать", "Найковий ступiнь");

            for (int i = 0; i < s.Length; ++i)
            {
                if ((write[i]) && (!Program.delete[i]))
                {
                    Console.WriteLine("{0,-15} {1, -15} {2, -15} {3, -20} {4,-20} {5,-15} {6,-15} ", Program.teacher[i].Number, Program.teacher[i].LastName, Program.teacher[i].Name, Program.teacher[i].Surname, Program.teacher[i].Chair, Program.teacher[i].Sex, Program.teacher[i].Degree);
                }
            }
        }
    }
}

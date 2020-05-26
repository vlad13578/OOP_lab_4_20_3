using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_4_20_3
{
    class Teacher
    {
        private int _number;
        private string _lastname;
        private string _name;
        private string _surname;
        private string _chair;
        private string _sex;
        private string _degree;

        public int Number
        {
            get => _number;
            set => _number = value;
        }
        public string LastName
        {
            get => _lastname;
            set => _lastname = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }
        public string Chair
        {
            get => _chair;
            set => _chair = value;
        }
        public string Sex
        {
            get => _sex;
            set => _sex = value;
        }
        public string Degree
        {
            get => _degree;
            set => _degree = value;
        }
        public Teacher()
        {
            Number = 0;
            LastName = "Не вказано";
            Name = "Не вказано";
            Surname = "Не вказано";
            Chair = "Не вказано";
            Sex = "Не вказано";
            Degree = "Не вказано";
        }

        public Teacher(int number)
        {
            Number = number;
            LastName = "Не вказано";
            Name = "Не вказано";
            Surname = "Не вказано";
            Chair = "Не вказано";
            Sex = "Не вказано";
            Degree = "Не вказано";
        }

        public Teacher(int number, string lastname)
        {
            Number = number;
            LastName = lastname;
            Name = "Не вказано";
            Surname = "Не вказано";
            Chair = "Не вказано";
            Sex = "Не вказано";
            Degree = "Не вказано";
        }

        public Teacher(int number, string lastname, string name)
        {
            Number = number;
            LastName = lastname;
            Name = name;
            Surname = "Не вказано";
            Chair = "Не вказано";
            Sex = "Не вказано";
            Degree = "Не вказано";
        }

        public Teacher(int number, string lastname, string name, string surname)
        {
            Number = number;
            LastName = lastname;
            Name = name;
            Surname = surname;
            Chair = "Не вказано";
            Sex = "Не вказано";
            Degree = "Не вказано";
        }

        public Teacher(int number, string lastname, string name, string surname, string chair)
        {
            Number = number;
            LastName = lastname;
            Name = name;
            Surname = surname;
            Chair = chair;
            Sex = "Не вказано";
            Degree = "Не вказано";
        }
        public Teacher(int number, string lastname, string name, string surname, string chair, string sex)
        {
            Number = number;
            LastName = lastname;
            Name = name;
            Surname = surname;
            Chair = chair;
            Sex = sex;
            Degree = "Не вказано";
        }
        public Teacher(int number, string lastname, string name, string surname, string chair, string sex, string degree)
        {
            Number = number;
            LastName = lastname;
            Name = name;
            Surname = surname;
            Chair = chair;
            Sex = sex;
            Degree = degree;
        }
    }
}

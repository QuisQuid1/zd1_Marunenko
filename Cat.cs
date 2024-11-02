using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1_Marunenko
{
    class Cat
    {
        private string name; // скрытое поле
        private double weight;
        public Cat(string CatName, double CatWeight)
        {
            Name = CatName;
            Weight = CatWeight;
            
        }
        public void Meow()
        {
            Console.WriteLine(name + " meows");
        }
        public string Name // свойство, реализуем инкапсуляцию!
        {
            // получение значения - просто возврат name
            get
            {
                return name;
            }
            // установка значения - используем проверку
            set
            {
                bool OnlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }
        public double Weight
        {
            get 
            {
                return weight;
            }
            set
            {
                // делаем проверку, что вес не может быть нулевым или отрицательным
                if (value <= 0)
                {
                    Console.WriteLine("Вес не может быть нулевым или отрицательным");
                }
                else
                {
                    weight = value;
                }
            }
        }
        public void Info(string name, double weight)
        {
            //делаем вывод инормации
            Console.WriteLine($"Имя кота {name}, вес кота {weight} кг");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1_Marunenko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите имя кота: ");
                string name = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Введите вес кота: ");
                double weight = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Cat cat = new Cat(name, weight);//создаем объект класса
                if (cat.Name == name && cat.Weight == weight)
                {
                    cat.Meow();
                    cat.Info(name, weight);
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Что то введено неверно");
            }
        }
    }
}

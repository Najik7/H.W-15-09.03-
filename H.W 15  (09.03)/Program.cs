using System;
using System.Collections.Generic;
using System.Linq;

namespace H.W_15___09._03_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> people = new Dictionary<int, string>(3);
            //same as
            var people = new Dictionary<int, string>();

            //Добавляем:
            people.Add(1, "Alijon");
            people.Add(2, "Malik");
            people.Add(3, "Khamza");


            //Выводим на консоль:
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            
            //same as:
            people = new Dictionary<int, string>()
            {
                {1, "Anvar" },
                {2, "Akram" },
                {3, "Almal" },
            };


            //Удаление:
            people.Remove(1);

            foreach (KeyValuePair<int, string> item in people)
            {
                Console.WriteLine($"Пара ключей: {item.Key};  Пара значений: {item.Value}");
            }
            Console.WriteLine();

            //
            string name = people[2];
            Console.WriteLine(name);

            var key = people.Keys;
            foreach (var item in key)
            {
                Console.WriteLine(key);
            }


            //Запрашиваем количество элементов в Dictionary
            Console.WriteLine($"\n{people.Count}");



        }
    }
}

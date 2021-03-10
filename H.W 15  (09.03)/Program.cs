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




            //List
            Console.WriteLine("\nList\n");
            //Создаем List:

            List<int> numbersList = new List<int>() { 5, 4, 3, 2, 1 };

            //Добавляем элемент:
            numbersList.Add(0);

            //Добавляем массив int-ов в List:
            int[] intArray = { 1, 2, 3, 4, 5 };
            numbersList.AddRange(intArray);

            //Удалаем элемент:
            if (numbersList.Remove(1))//Удалит первую попавшую единицу
            {
                Console.WriteLine("Удаление прошло успешно");
            }
            else
            {
                Console.WriteLine("Данное число отсутвует");
            }

            //Удаляем по индексу:
            numbersList.RemoveAt(0);


            //Минимальный и Максимальный элемент List-a:
            int min = numbersList.Min();
            int max = numbersList.Max();
            Console.WriteLine($"\nMin = {min}, Max = {max}\n");


            //Выводим на консоль:
            for (int i = 0; i < numbersList.Count; i++)
            {
                Console.Write($"{numbersList[i]} ");
            }
            Console.WriteLine();

            foreach (var item in numbersList)
            {
                Console.Write($"{item} ");
            }

        }
    }
}

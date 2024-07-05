using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CompareCollections.Collections
{
    public static class WorkingWithCollections
    {
        public static void FillingCollection(List<int> list, ArrayList arrayList, LinkedList<int> linkedList, Random random, Stopwatch sw)
        {
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                list.Add(random.Next());
            }
            sw.Stop();
            Console.WriteLine($"Время для запонения List {sw.Elapsed}");

            sw.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                arrayList.Add(random.Next());
            }
            sw.Stop();
            Console.WriteLine($"Время для запонения ArrayList {sw.Elapsed}");

            sw.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                linkedList.AddLast(random.Next());
            }
            sw.Stop();
            Console.WriteLine($"Время для запонения LinkedList {sw.Elapsed}");
        }

        public static void SearchElement(List<int> list, ArrayList arrayList, LinkedList<int> linkedList, Random random, Stopwatch sw, int searchIndex)
        {
            sw.Restart();
            Console.WriteLine($"Элемент 496753 в List = {list[searchIndex]}");
            sw.Stop();
            Console.WriteLine($"Время поиска элемента в List {sw.Elapsed}");

            sw.Restart();
            Console.WriteLine($"Элемент 496753 в ArrayList = {arrayList[searchIndex]}");
            sw.Stop();
            Console.WriteLine($"Время поиска элемента в ArrayList {sw.Elapsed}");

            sw.Restart();
            Console.WriteLine($"Элемент 496753 в LinkedList = {linkedList.ElementAt(searchIndex)}");
            sw.Stop();
            Console.WriteLine($"Время поиска элемента в LinkedList {sw.Elapsed}");
        }

        public static void DivisionCollectionByIndex (List<int> list, ArrayList arrayList, LinkedList<int> linkedList, Random random, Stopwatch sw, int divisionIndex)
        {
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                if (list[i] % divisionIndex == 0)
                    Console.WriteLine(list[i]);
            }
            sw.Stop();
            Console.WriteLine($"Время для поиска элементов делимых на {divisionIndex} без остатка в List {sw.Elapsed}");

            sw.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                if (Convert.ToInt32(arrayList[i]) % divisionIndex == 0)
                    Console.WriteLine(arrayList[i]);
            }
            sw.Stop();
            Console.WriteLine($"Время для поиска элементов делимых на {divisionIndex} без остатка в ArrayList {sw.Elapsed}");

            sw.Restart();
            for (int i = 0; i < 100000; i++)
            {
                if (linkedList.ElementAt(i) % divisionIndex == 0)
                    Console.WriteLine(linkedList.ElementAt(i));
            }
            sw.Stop();
            Console.WriteLine($"Время для поиска элементов делимых на {divisionIndex} без остатка в LinkedList {sw.Elapsed}");
        }
    }
}
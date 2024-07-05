using CompareCollections.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCollections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Stopwatch sw = new Stopwatch();
            int searchIndex = 496753;
            int divisionIndex = 777;

            List<int> list = new List<int>();
            ArrayList arrayList = new ArrayList();
            LinkedList<int> linkedList = new LinkedList<int>();

            WorkingWithCollections.FillingCollection(list, arrayList, linkedList, rnd, sw);
            WorkingWithCollections.SearchElement(list, arrayList, linkedList, rnd, sw, searchIndex);
            WorkingWithCollections.DivisionCollectionByIndex(list, arrayList, linkedList, rnd, sw, divisionIndex);


            Console.WriteLine("Для выхода нажмите Enter");
            while (Console.ReadKey().Key != ConsoleKey.Enter);
            
            
        }
    }
}
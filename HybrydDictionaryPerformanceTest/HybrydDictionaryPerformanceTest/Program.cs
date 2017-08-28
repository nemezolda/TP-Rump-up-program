using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;

namespace HybridDictionaryPerformanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch;
            for (int i = 1; i <= 51; i++)
            {
                stopWatch = Stopwatch.StartNew();
                var hybridDictionary = GetHybridDictionary(i);
                ProcessHybridDictionary(hybridDictionary);
                stopWatch.Stop();
                PrintResult(i, stopWatch);

                //stopWatch = Stopwatch.StartNew();
                //var hastTable = GetHashTable(10);
                //ProcessHashTable(hastTable);
                //stopWatch.Stop();
                //PrintResult(stopWatch);

                //stopWatch = Stopwatch.StartNew();
                //hybridDictionary = GetHybridDictionary(100000);
                //ProcessHybridDictionary(hybridDictionary);
                //stopWatch.Stop();
                //PrintResult(stopWatch);

                //stopWatch = Stopwatch.StartNew();
                //hastTable = GetHashTable(100000);
                //ProcessHashTable(hastTable);
                //stopWatch.Stop();
                //PrintResult(stopWatch);

               // Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static HybridDictionary GetHybridDictionary(int size)
        {
            HybridDictionary hybridDict = new HybridDictionary();
            for (int i = 0; i <= size; i++)
            {
                hybridDict.Add(i, Path.GetRandomFileName());
            }

            return hybridDict;
        }

        private static Hashtable GetHashTable(int size)
        {
            Hashtable hastTable = new Hashtable();
            for (int i = 0; i <= size; i++)
            {
                hastTable.Add(i, Path.GetRandomFileName());
            }

            return hastTable;
        }

        private static void ProcessHybridDictionary(HybridDictionary collection)
        {
            string stringResult;
            for(int i = 0; i< collection.Count; i++)
            {
                stringResult = collection[i].ToString();
            }
        }

        private static void ProcessHashTable(Hashtable collection)
        {
            string stringResult;
            for (int i = 0; i < collection.Count; i++)
            {
                stringResult = collection[i].ToString();
            }
        }

        private static void PrintResult(int length, Stopwatch stopWatch)
        {
            Console.WriteLine($"i={length}:{stopWatch.Elapsed}");
        }
    }
}

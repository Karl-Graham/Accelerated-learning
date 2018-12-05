using System;
using System.Collections.Generic;
using System.Linq;

namespace Module11
{
    class Program
    {
        static void Main(string[] args)
        {

            MeanaValueAnSum();

            
        }

        private static void MeanaValueAnSum()
        {
            var list = new List<decimal> {1, 3, 5, 8, 11, 13,18};
            decimal sumValue = countSum(list);
            decimal meanValueLinq = countMeanValueWithLinq(list);
            var stringList = new List<string>();

            List<decimal> higherThanFive = listHigherThenFive(list);
            List<string> starlist = StarifyList(list);
            Console.WriteLine(sumValue/list.Count());
            Console.WriteLine(meanValueLinq);
            Console.WriteLine(sumValue);
            Console.WriteLine(list.Sum());
            PrintHigherThenFive(higherThanFive);
            Console.WriteLine(String.Join(", " ,list.FindAll(x => x > 5)));
            Console.WriteLine(String.Join(" ", starlist));            
            Console.WriteLine(String.Join(" ", list.Select(s => "*" + s + "*")));
        }

        private static List<string> StarifyList(List<decimal> list)
        {
            var starList = new List<string>();
            foreach (var item in list)
            {
                string a = item.ToString();
                starList.Add("*" + a + "*");
            }
            return starList;
            
        }

        private static void PrintHigherThenFive(List<decimal> higherThanFive)
        {
            int c = 0;
            foreach (var item in higherThanFive)
            {
                Console.Write(item);
                c++;
                if (c < higherThanFive.Count())
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        private static List<decimal> listHigherThenFive(List<decimal> list)
        {
            var list5 = new List<decimal>();

            foreach (var item in list)
            {
                if (item > 5)
                list5.Add(item);
            }
            return list5;
        }

        private static decimal countMeanValueWithLinq(List<decimal> list)
        {
            decimal result = list.Average();
            return result;
        }

        private static decimal countSum(List<decimal> list)
        {
            decimal totalValue = 0;
            foreach (int item in list)
            {
                totalValue += item;
            }
            return totalValue;


        }
    }
}

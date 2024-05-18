using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _19_LinqSamples03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Distinct排除重複，如果有兩個以上相同的資料，只會取一個
            var listDistinct = new List<string> 
            { 
                "台北", "台北", "洛杉磯", "紐約", "紐約", "台北" 
            };
            var result = listDistinct.Distinct();
            Console.WriteLine("Distinct");
            foreach (var item in result)
            {
                
                Console.WriteLine(item);
            }
            //Skip跳過幾筆、Take取得幾筆
            var listSkipTake = new List<string> { "A", "B", "C", "D", "E", "F", "F" };
            var resultOfSkip = listSkipTake.Skip(3);
            Console.WriteLine("Skip(3) 的結果 ");
            Display(resultOfSkip);

            var resultOfTake = listSkipTake.Take(3); 
            Console.WriteLine("Take(3) 的結果 "); 
            Display(resultOfTake);

            var resultOfSkipTake = listSkipTake.Skip(2).Take(2); 
            Console.WriteLine("Skip(2).Take(2) 的結果 "); 
            Display(resultOfSkipTake);

            //
            var list = CreateList();
            var result1 = list.Where((x) => x.Age > 40).ToList();
            var result2 = list.Where((x) => x.Age > 40).ToArray();
            // 使用 Name 當群組分類的索引鍵，而值資料仍然是 MyData
            var result3 = list.Where((x) => x.Age > 40).ToDictionary((x) => x.Name);

            foreach (var item in result3)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"{item.Value.Name}-- {item.Value.Age}");
            }
            Console.WriteLine("--------------");
            // 使用 Name 當群組分類的索引鍵，而且用 Age 當值資料
            var result4 = list.ToDictionary((x) => x.Name, (y) => y.Age);
            foreach (var item in result4)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            Console.WriteLine("--------");

            //GroupBy–QueryExpression
            Console.WriteLine("GroupBy–QueryExpression");
            var listCity = CreateListCity();
            var resultCity = 
                from o in listCity
                group o by o.City into gp
                select gp;
            foreach (var item in resultCity)
            {
                Console.WriteLine($"住在 : {item.Key}");
                foreach (var p in item)
                {
                    Console.WriteLine(p.Name);
                }
                Console.WriteLine("--------");
            }
        }
        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData() { Name = "Bill" , Age = 47 },
                new MyData() { Name = "John" , Age = 37 },
                new MyData() { Name = "Tom" , Age = 48 },
                new MyData() { Name = "David", Age = 36},
            };
        }
        static void Display(IEnumerable<string> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }
        static List<MyDataCity> CreateListCity()
        {
            return new List<MyDataCity>()
            {
                new MyDataCity() { Name = "Bill" , City = "台北" }, 
                new MyDataCity() { Name = "John" , City = "台北" }, 
                new MyDataCity() { Name = "Tom" , City = "高雄" }, 
                new MyDataCity() { Name = "David", City = "台南" }, 
                new MyDataCity() { Name = "Jeff" , City = "台南" },
            };
        }

    }
}

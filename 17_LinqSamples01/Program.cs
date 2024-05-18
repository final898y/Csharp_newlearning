using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _17_LinqSamples01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MyData> list = CreateList();
            //Query Expression
            IEnumerable<MyData> people = 
                from data in list 
                where data.Name == "Bill" 
                select data;
            // Method Expression
            /*
            var list = CreateList();
            var people = list.Where((x) => x.Name == "Bill");
            //。若要包含 Select 語法
            var people = list.Where((x) => x.Name == "Bill").Select((x) => x);
             */
            //顯示結果
            foreach (MyData person in people)
            {
                Console.WriteLine($"{person.Name} 是 {person.Age} 歲");
            }


            var listFirst = CreateList();
            // 這裡的 person1 是單個物件, 也就是 MyData person1
            var person1 = list.FirstOrDefault((x) => x.Age < 37);
            Console.WriteLine($"小於 37 歲的人第一個被找到的是 : {person1.Name}");
            // 因為找不到, 就會跳出例外
            //var person2 = list.First((x) => x.Age < 30);
            //Console.WriteLine($"小於 30 歲的人第一個被找到的是 : {person2.Name}");

            var listLast = CreateList();
            var person3 = list.LastOrDefault((x) => x.Age > 35);
            Console.WriteLine($"大於 35 歲的人最後一個被找到的是 : {person3.Name}");
            // 因為找不到, 就會跳出例外
            //var person4 = list.Last((x) => x.Age > 50);
            //Console.WriteLine($"大於 50 歲的人最後一個被找到的是 : {person4.Name}");

            var listSingle = CreateList();
            var person5 = list.SingleOrDefault((x) => x.Name == "Tom");
            Console.WriteLine($"找到唯一的 : {person5.Name}- {person5.Age}");
            // 因為找不到唯一 (裡面有兩個 Bill) 就會跳出例外
            //var person6 = list.Single((x) => x.Name == "Bill");
            //Console.WriteLine($"找到唯一的 : {person6.Name}- {person6.Age}");

            var personNull = list.FirstOrDefault((x) => x.Name == "李小龍");
            if (personNull == null)
            {
                //如果是 null 則另行處理
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到 : {personNull.Name}- {personNull.Age}");
            }

            int index = 1;
            var personIndex = list.ElementAtOrDefault(index);
            if (personIndex == null)
            {
                Console.WriteLine("查無此人"); 
            }
            else
            {
                Console.WriteLine($"找到索引為 : {index} 的人是 {personIndex.Name}- {personIndex.Age}");
            }

            string nameAny = "David";
            bool result = list.Any((x) => x.Name == nameAny);
            if(result) 
            {
                Console.WriteLine($"找到了 : {nameAny}");
            }
            else
            {
                Console.WriteLine($"找不到 : {nameAny}");
            }

            string nameAll = "Bill";
            bool isAllBill = list.All((x) => x.Name == nameAll);
            if(isAllBill)
            {
                Console.WriteLine($"全都是 {nameAll}");
            }
            else
            {
                Console.WriteLine($"有些人不叫 {nameAll}");
            }
            bool isAllOverForty = list.All((x) => x.Age >= 40);
            if (isAllOverForty)
            {
                Console.WriteLine("大家都超過 40 歲");
            }
            else
            {
                Console.WriteLine("有人不到 40 歲");
            }

        }
        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData { Name = "Bill", Age = 47 },
                new MyData { Name = "John", Age = 37 },
                new MyData { Name = "Tom", Age = 48 },
                new MyData { Name = "David", Age = 36 },
                new MyData { Name = "Bill", Age = 35 },
            };
        }
    }
}

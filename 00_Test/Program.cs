 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _00_Test
{
    

    internal class Program
    {
        static void Main(string[] args)
        {

            // Path to the JSON file
            string filePath = "E:\\MVS\\source\\repos\\Csharp_newlearning\\00_Test\\jsconfig1.json";

            try
            {
                // Read the JSON file content
                string jsonString = File.ReadAllText(filePath);

                // Deserialize the JSON string into a Person object
                Person person = JsonSerializer.Deserialize<Person>(jsonString);

                // Output the deserialized object
                Console.WriteLine($"Name: {person.Name}");
                Console.WriteLine($"Age: {person.Age}");
                Console.WriteLine($"Email: {person.Email}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }



            string a = @"""aaa""";
            Console.WriteLine(a);
            Console.ReadLine();
            /*
            int[] nums__ = new int[3] {1,2,1};
            int[] GetConcatenation(int[] nums)
            {
                
                int[] ans = new int[nums.Length * 2];
                for(int i=0; i< nums.Length*2;i++)
                {
                    if (i < nums.Length)
                    {
                    ans[i] = nums[i];
                    }
                    else
                    {
                    ans[i] = nums[i - nums.Length];
                    }
                }
                return ans;

            }
            int[] anss = GetConcatenation(nums__);
            foreach(int n in anss)
            {
                Console.Write($"{n} ");
            }
            Console.ReadLine();
            
            List<Data> _data = new List<Data>();
            Data newData = new Data
            {
                Id = 10,
                Name = "alan",
                Description = "abcdef",
                Type = "fish"
            };

            
            // 將新的 Data 對象添加到 _data 列表中
            _data.Add(newData);
            Console.WriteLine(_data[0].Id);
            foreach (var data in _data)
            {
                Console.WriteLine($"Id: {data.Id}, Name: {data.Name}, Description: {data.Description}, Type: {data.Type}");
            }
            Console.ReadLine();



            /*
            int Add(int a, int b)
            {
                int sum1 = a + b;
                return sum1;
            }
            Console.WriteLine("請輸入數值1:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入數值2：");
            int y = Convert.ToInt32(Console.ReadLine());
            int total = Add(x, y);
            Console.WriteLine($"{x}+{y}={total}");
            */



            /*
            string s = "hello";
            byte[] asciiBytes = System.Text.Encoding.ASCII.GetBytes(s);
            int sum = 0;
            for (int i = 0; i < s.Length-1; i++)
            {
                
                    sum += Math.Abs(asciiBytes[i] - asciiBytes[i + 1]);
              

                
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            */
        }
    }
}

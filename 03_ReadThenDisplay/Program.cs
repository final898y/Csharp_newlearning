// See https://aka.ms/new-console-template for more information

/*
C# 基礎課程 01
*/

/*
int x = 1;
if (x > 10)
{
    Console.WriteLine("x大於10");
}
else
{
    if (x < 10)
    {
        Console.WriteLine("x小於10");
    }
    else
    {
        Console.WriteLine("X等於10");
    }
}


int y = 10;
if (y > 10)
{
    Console.WriteLine("Y大於10");
}
else if(y < 10)
{ 
    Console.WriteLine("y小於10");
}
else
{ 
    Console.WriteLine("x等於10");
}
*/

int condition = 10;
int value;
Console.WriteLine("請輸入一個數字 :");
string input = Console.ReadLine();
value = int.Parse(input);
if (value > condition)
{ 
    Console.WriteLine("輸入的值大於" + condition);
}
else if(value < condition)
{ 
    Console.WriteLine($"輸入的值小於 {condition}");
}
else
{
    Console.WriteLine($"輸入的值等於 {condition}");   
}
// See https://aka.ms/new-console-template for more information

int x = 1;
switch (x)
{
    case 1:
        Console.WriteLine("x是1");
        break;
    case 2:
        Console.WriteLine("x是2");
        break;
    default:
        Console.WriteLine("x在條件之外");
        break;
}
//Console.ReadLine();
/*
int value;
Console.WriteLine("請輸入一個數字 :");
string input = Console.ReadLine();
value = int.Parse(input);
switch (value)
{ 
    case 1:
        Console.WriteLine("數字是1");
        break;
    case 2:
        Console.WriteLine("數字是 2");
        break;
    case 28:
        Console.WriteLine("中");
        break;
    default:
        Console.WriteLine("數字不在條件內");
        break;
}
*/
int test = 10;
if (test >=5  & test<=8)
{
    Console.WriteLine("ok");
}
else
{
    Console.WriteLine("no");
}


int value;
Console.WriteLine("請輸入一個數字 :\n(範圍是1到100)");
string input = Console.ReadLine();
value = int.Parse(input);
switch (value)
{
    case < 1:

    case > 100: 
        Console.WriteLine("數字不在條件內");
        break;
    default:
        Console.WriteLine($"數字是 {value}");
        break;
}


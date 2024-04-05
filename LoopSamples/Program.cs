// See https://aka.ms/new-console-template for more information

int result1 = 0;
for (int i=0; i<11; i++)
{
    result1 = result1 + i;
    //result += i
}
Console.WriteLine($"for加總結果 : {result1}");


int result2 = 0;
int x = 0;
while (x < 11)
{
    result2 = result2 + x;
    x++;
    //x = x + 1;
}
Console.WriteLine($"while加總結果 : {result2}");
Console.ReadLine();
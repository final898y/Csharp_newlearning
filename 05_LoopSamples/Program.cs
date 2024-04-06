// See https://aka.ms/new-console-template for more information

int result1 = 0;
for (int i=0; i<11; i++)
{
    result1 = result1 + i;
    //result += i
}
Console.WriteLine($"for加總結果 : {result1}");


int result2 = 0;
int xwhile= 1;
while (xwhile < 11)
{
    result2 = result2 + xwhile;
    xwhile++;
    //x = x + 1;
}
Console.WriteLine($"while加總結果 : {result2}");


int result3 = 0;
int xdo = 0;
do
{
    result3 = result3 + xdo;
    xdo = xdo + 1;
}
while (xdo < 11);
Console.WriteLine($"do加總結果 : {result3}");

//foreach 陳述式是用來逐一查看集合，以取得所需的資訊，但是不能用來加入或移除來源集合的項目，以避免無法預期的副作用。
int[] array = new int[] {0,1,2,3,4,5 };
foreach (int i in array)
{
    Console.WriteLine(i);
}
Console.ReadLine();
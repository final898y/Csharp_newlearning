// See https://aka.ms/new-console-template for more information

int i1 = 5;
int i2 = 3;
double d = 9.8;
string s1 = "The";
string s2 = "End";
Console.WriteLine(i1 + i2);
Console.WriteLine(i1 + d);
Console.WriteLine(s1 + s2);
Console.WriteLine(s1 + i1);
Console.WriteLine(d + s2);

int x1 = 10;
string y1 = "abc";

int x2 = 10;
string y2 = "abc";

if(x1==x2&& y1==y2)
{
    Console.WriteLine("都正確");
}
else
{
    Console.WriteLine("至少有一個不正確");
}

if(x1==x2 || y1==y2)
{
    Console.WriteLine("至少有一個正確");
}
else
{
    Console.WriteLine("兩個都不正確");
}
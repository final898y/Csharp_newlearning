// See https://aka.ms/new-console-template for more information

/*
C# 基礎課程 01
*/


//break 陳述式會終止它所在之最靠近的封閉式迴圈或 switch 陳述式。
using System.Reflection.Metadata.Ecma335;

int condition1 = 15;
for (int i1 = 0; i1 < 3; i1++)
{
    Console.WriteLine($"i1 = {i1}");
    for (int j1 = 11; j1 < 20; j1++)
    {
        if (j1 == condition1)
        {
            break;
        }
        Console.WriteLine($"j1 = {j1}");
    }
}
Console.WriteLine($"--------");


//條件符合的時候，continue 會直接進到下一輪迴圈，而忽略後面的程式碼。
int condition2 = 15;
for (int i2 = 0; i2 < 3;i2++)
{
    Console.WriteLine($"i2 = {i2}");
    for (int j2 = 11;j2 < 20; j2++)
    {
        if(j2 == condition2)
        {
            continue;
        }
        Console.WriteLine($"j2 = {j2}");
    }
}
Console.WriteLine($"--------");

//以下看不懂先跳過
static int ReturnInt()
{
    Console.WriteLine("進入 ReturnInt");
    // 回傳值要與宣告的型別相同
    return 1;
}
static void ReturnVoid()
{
    Console.WriteLine("進入 ReturnVoid");
    // 沒有回傳值時, return 若在整個方法的最後一行可以省略
    return;
}

static int ReturnTryInt(int i )
{
    try
    {
        Console.WriteLine("進入 try");
        if (i<10)
        {
            throw new Exception("故意發生例外");
        }
        return 99;
    }
    catch (Exception ex) 
    {
        Console.WriteLine("進入catch");
        Console.WriteLine(ex.ToString());
        return 88;
    }
    finally
    { Console.WriteLine("進入finally"); }

}
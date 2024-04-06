// See https://aka.ms/new-console-template for more information

/*
C# 基礎課程 01
*/


//break 陳述式會終止它所在之最靠近的封閉式迴圈或 switch 陳述式。
int condition = 15;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"i = {i}");
    for (int j = 11; j < 20; j++)
    {
        if (j == condition)
        {
            break;
        }
        Console.WriteLine($"j = {j}");
    }
}
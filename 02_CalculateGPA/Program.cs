// See https://aka.ms/new-console-template for more information

//學生的姓名、課程名稱
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

//學分時數
int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

//字母等級數值對等值 A = 4 個成績點 B = 3 個成績點
int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

//總學分
int totalCreditHours = 0;
totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

//總積點
int totalGradePoints = 0;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

//GPA
decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;
//儲存 GPA 前置位數的變數
int leadingDigit = (int)gradePointAverage;
//儲存小數點之後前兩位數的變數
int firstDigit = (int)(gradePointAverage * 10) % 10;
int secondDigit = (int)(gradePointAverage * 100) % 10;


Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");
Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");

//格式化主控台輸出
Console.WriteLine("\n\n");
Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");

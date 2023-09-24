//Задача 10.
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Задача 13.
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Задача 15.
//Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным.

//Answer to task № 10.
//int MiddleDigit(int dig)
//{
//   int n = dig / 10 % 10;
//    return n;
//}
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Input three digit number");
//    int num = Convert.ToInt32(Console.ReadLine());
//    int res = MiddleDigit(num);
//    Console.WriteLine(res);
//}
//-----------------------------------------------------------------------------------------------------

//Answer to task № 13.
//int ThirdDigit(int inp = 0)
//{
//    int n = inp % 10;
//    return n;
//}
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Input number");
//    int num = Convert.ToInt32(Console.ReadLine());
//    int r = ThirdDigit(num);
//    if (num > 100 && num < 1000)
//        Console.WriteLine(r);
//    else Console.WriteLine("Error, there is no third digit");
//}
//-----------------------------------------------------------------------------------------------------

//Answer to task № 15.
//string DayOfWeek(string d = "1")
//{
//    if (d == "1") return "Monday";
//    if (d == "2") return "Tuesday";
//    if (d == "3") return "Wednesday";
//    if (d == "4") return "Thursday";
//    if (d == "5") return "Friday";
//    if (d == "6") return "Saturday";
//    if (d == "7") return "Sunday";
//    else return "Error";
//}
//Console.WriteLine("Введите цифру от 1 до 7");
//string num = Console.ReadLine();
//string g = DayOfWeek(num);
//if (g == "Saturday" || g == "Sunday")
//    Console.WriteLine(g + " weekend");
//else Console.WriteLine("Work day");
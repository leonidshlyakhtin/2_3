// Леонид Шляхтин 12 вариант 22 исп 2\1


using ConsoleApp18;
using System.Data;
using PairClasses;
using System;
using System.Numerics;
using _3;

Money money1_1 = new Money(100, 50);
Money money1_2 = new Money(50, 80);

Console.WriteLine(money1_1);
Console.WriteLine(money1_2);

IPair result = money1_1.Add(money1_2);
Console.WriteLine(result);

result = money1_1.Sub(money1_2);
Console.WriteLine(result);

result = money1_1.Mult(1.5);
Console.WriteLine(result);

result = money1_1.Div(3);
Console.WriteLine(result);

bool comparisonResult = money1_1.CompareTo(money1_2);
Console.WriteLine(comparisonResult);


Money2 money2_1 = new Money2(1, 2, 3, 4, 5, 6, 7, 8, 9, 2, 1, 3);
Console.WriteLine(money2_1);

Money2 money2_2 = new Money2(0, 0, 1, 2, 3, 4, 5, 0, 2, 9, 1, 9);
Console.WriteLine(money2_2);

IPair money3 = money2_1.Add(money2_2);
Console.WriteLine(money3);

bool res = money3.CompareTo(money2_2);
Console.WriteLine(res);

double res2 = money2_1.Division(money2_2);
Console.WriteLine(res2);

double res3 = money2_1.Div(2);
Console.WriteLine(res3);

Money2 money4 = (Money2)money2_1.Sub(money2_2);
Console.WriteLine(money4);

Money2 money5 = (Money2)money2_1.Mult(3);
Console.WriteLine(money5);

    


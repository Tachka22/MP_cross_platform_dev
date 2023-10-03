int z1 = 5;
var z2 = 5;

var x1 = ("Hello", 5, 3.14);
(string, int, double) x1b = ("Hello", 5, 3.14);
Console.WriteLine(x1.Item1);
Console.WriteLine(x1.Item2);
Console.WriteLine(x1.Item3);
Console.WriteLine();

(int min, int max) x2 = (2, 4);
Console.WriteLine(x2.min);
Console.WriteLine(x2.max);
Console.WriteLine();

var (min, max) = (2, 4);
Console.WriteLine(x2.min);
Console.WriteLine(x2.min);
Console.WriteLine();

var x4 = (min: 2, max: 4);
Console.WriteLine(x2.min);
Console.WriteLine(x2.min);
Console.WriteLine();

var x5 = GetX5();
//(int, int) getx5()
//{
//    return (1, 2);
//}
(int, int) GetX5() => (1,2);
(int min, int max) GetX6() => (1,2);
(int min, int max) GetX7(int v, (int a, int b) ab) => (v + ab.a, v + ab.b);

using System.Diagnostics;

var arr = Enumerable.Range(0, 10).ToArray();
Console.WriteLine(string.Join(" ",arr));

var myQuary =
    from v in arr.AsParallel()
    where v > 5 && v < 8
    select $"_{v}_";
Console.WriteLine(string.Join(" ", myQuary));

Stopwatch stopWatch = new();
stopWatch.Start();
var arrNames = new string[] { "Юра", "Миша", "Сергей", "аксим", "Игорь" };
var myQuary2 =
    from v in arrNames
    where v.ToUpper().StartsWith("M")
    orderby v
    select v;
stopWatch.Stop();
TimeSpan ts = stopWatch.Elapsed;

string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
Console.WriteLine("RunTime " + elapsedTime);

Console.WriteLine(string.Join(" ", myQuary2));
//------------------------------------------------------
var arr2 = new string[] { "Москва", "Сочи", "Самара", "Тула", "Ялта", "Севастополь" };
var a1 = arr2.Where(v => v.StartsWith("С") && v.Length > 4).OrderBy(v => v).ToArray();
Console.WriteLine(string.Join(" ", a1));

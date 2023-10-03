//Словарь (Dictionary)
//Ключ (уникальный) - значение

Dictionary<int, string> x = new();
x.Add(10, "Калуга");
x.Add(75, "Москва");
x.Add(25, "Тула");
Console.WriteLine(x[75]);
x[75] = "Воронеж";
x[99] = "Курск";

foreach (var i in x)
    Console.WriteLine(i);
foreach (var i in x)
    Console.WriteLine($"key= {i.Key}, value= {i.Value}");


using System.Collections;
//Обычная очередь
Queue queue = new();
queue.Enqueue(3);
queue.Enqueue(1500);
queue.Enqueue("Hello");
queue.Enqueue(3.14);
Console.WriteLine($"Смотрим --> {queue.Peek()}");
while(queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}
//Обобщенная очерель
Queue<int> numbers = new Queue<int>();
numbers.Enqueue(1);
numbers.Enqueue(223);
numbers.Enqueue(35);
Console.WriteLine($"Сумма= {numbers.Sum()}");
while (numbers.Count > 0)
{
    Console.WriteLine(numbers.Dequeue());
}
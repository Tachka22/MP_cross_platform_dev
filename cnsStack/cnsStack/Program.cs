using System.Collections;

Stack stack = new();
stack.Push("hello");
stack.Push(3.14);
stack.Push(3);
Console.WriteLine($"Смотрим --> {stack.Peek()}");
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

Stack<int> stack2 = new();
stack2.Push(1);
stack2.Push(2);
stack2.Push(3);
stack2.Push(4);
Console.WriteLine($"Смотрим --> {stack2.Peek()}");
Console.WriteLine(stack2.Pop());
Console.WriteLine(stack2.Pop());

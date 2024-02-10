


var list = new Stack<int>();
list.Push(1);
System.Console.WriteLine(list.Pop());
System.Console.WriteLine(list.Peek());
foreach (var item in list)
{
    System.Console.WriteLine(item);
}
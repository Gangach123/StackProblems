using System;
namespace Stack_Problems
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcpme to Stack Problems");
            Stackcs stacks = new Stackcs();
            

            Node node1 = new Node(70);
            Node node2 = new Node(30);
            Node node3 = new Node(56);

            stacks.Push(node1);
            stacks.Push(node2);
            stacks.Push(node3);

            stacks.Display();
        }
    }
}

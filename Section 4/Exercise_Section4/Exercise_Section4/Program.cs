﻿namespace Exercise_Section4
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());


        }
    }
}

﻿namespace AbstractClasses
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            System.Console.WriteLine("Copy shape.");
        }

        public void Select()
        {
            System.Console.WriteLine("Select Shape.");
        }
    }
}

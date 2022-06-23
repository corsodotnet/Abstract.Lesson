using System;

namespace Constructor.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Auto panda = new Auto("white");
            Auto punto = new Auto("Red");
            Auto audiA3 = new Auto("Pink");
            Auto Ferrari = new Auto("black");

            Console.WriteLine(" panda Color: " + panda._color);
            Console.WriteLine(" punto Color: " + punto._color);
            Console.WriteLine(" audiA3 Color: " + audiA3._color);
            Console.WriteLine(" Ferrari Color: " + Ferrari._color);
        }
    }
    public class Auto
    {
        public string _color;

        public Auto(string Color)
        {
            this._color = Color;
        }

    }
}

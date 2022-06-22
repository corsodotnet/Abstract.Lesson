using System;

namespace Abstract.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangolo triangolo = new Triangolo();
            Rettangolo rettangolo = new Rettangolo();

            FiguraGeometrica figuraGeometrica = new Triangolo();
           // DimmiAreaFiguraGeometrica(figuraGeometrica);

             figuraGeometrica = rettangolo;
             DimmiAreaFiguraGeometrica(figuraGeometrica);
        }

        public static void DimmiAreaFiguraGeometrica(FiguraGeometrica figuraGeometrica)
        {
            figuraGeometrica.GetPerimentro();
        }
    }
}

using System;
namespace Abstract.Lesson.Abstract.Lesson
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Triangolo triangolo = new Triangolo();
            var rettangolo = new Rettangolo();
            var cubo = new Cubo();
            IFiguraGeometrica3D figuraGeometrica3D;
            FiguraGeometrica figuraGeometrica;
            // DimmiAreaFiguraGeometrica(figuraGeometrica);
            figuraGeometrica3D = cubo;
            figuraGeometrica = cubo;
            DimmiAreaFiguraGeometrica(figuraGeometrica);
        }

        public static void DimmiAreaFiguraGeometrica(FiguraGeometrica figuraGeometrica)
        {
            figuraGeometrica.GetPerimentro();

            for (int i = 0; i < 10; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine($"Sono finalemente {i}");
                        break;
                    case 2:
                        Console.WriteLine($"Sono finalemente {i} ");
                        break;
                    default:
                        Console.WriteLine($"Sorry no cases found for {i}");
                        break; 

                }
            }
        }
    }
}
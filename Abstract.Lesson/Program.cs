
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
        }
    }
}
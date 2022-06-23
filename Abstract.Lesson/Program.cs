using System;
namespace Abstract.Lesson.Abstract.Lesson
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Triangolo triangolo = new Triangolo();
            var rettangolo = new Rettangolo();            
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
    public interface IOrganization
    {

    }
    public interface IONU : IOrganization
    {
        public void  Oms(); 
        public void  Unicef();
        public void  Fmi();
        public void  Fao();

    }
    public interface IEU : IOrganization
    {
        public void Bce();
    }
    public interface INATO : IOrganization
    {
        public int EncreaseMilitarExpense();
    } 

    public class Country : INATO
    {
        public int EncreaseMilitarExpense()
        {
            return 0; 
        }
    }
}
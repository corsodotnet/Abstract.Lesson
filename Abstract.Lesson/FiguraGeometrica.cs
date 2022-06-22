using System;

namespace Abstract.Lesson.Abstract.Lesson
{
    public abstract class FiguraGeometrica // 1 -  Di essere un contratto!
    {
        // 2 -  Un Oggetto normale [ memebri, funzioni implementate]
        private int _perimetro;
        public abstract int CalcArea();  // -> Contratto
        public virtual int GetPerimentro() // Servizio in Piu, oggetti figli possono "override" il metodo della classe padre 
        {
            Console.WriteLine("FiguraGeometrica -  io calcolo il perimetro");
            return 500;
        }
    }
    public interface IFiguraGeometrica3D
    {
        public int Volume { get; set; }
        public int CalcVolume();
    }

    // 1 -  Può essere solo un contratto!

    public class Cubo : FiguraGeometrica, IFiguraGeometrica3D
    {
        public int Volume
        {
            get
            {
                return 10000;
            }
            set
            {

            }
        }
        public override int CalcArea()
        {
            return 0;
        }
        public int CalcVolume()
        {
            return 0;
        }
    }

    // Classe -> Estensione 
    // Interface ->  Implementazione 

    public class Rettangolo : FiguraGeometrica
    {
        private int _base = 10;
        private int _altezza = 40;

        public int Base
        {
            get
            {
                return _base * 2;
            }
        } // -> Funzione 


        public override int CalcArea()
        {
            Console.WriteLine("Area del Rettangolo:  ");
            Console.WriteLine(_base * _altezza);
            return _base * _altezza;
        }
        public override int GetPerimentro()
        {
            Console.WriteLine("Rettangolo -  io calcolo il perimetro");
            return 10000;
        }
    }
    public class Triangolo : FiguraGeometrica
    {
        private int _base = 10;
        private int _altezza = 40;
        public override int CalcArea()
        {
            Console.WriteLine("Area del Triangolo:  ");
            Console.WriteLine(_base * _altezza / 2d);
            return (int)Math.Round(_base * _altezza / 2d);
        }
    }
}
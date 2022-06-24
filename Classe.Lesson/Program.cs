﻿using System;

namespace Classe.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Square quadra = new Square(20);
            Retangle Reta = new Retangle(40, 20);
            
            Console.WriteLine("Lato Quad." + quadra.Lato); 


            Console.WriteLine("Altezza Ret." + Reta.Altezza);
            Console.WriteLine("Base Ret." + Reta.Base);


        }
    }

    public class Auto
    {
        // Membri
         string _name;
         string _targa;
         int _nRuote;
         int _cilindrata = 3000; 
         

        // Property
        public string Name { get { return _name; } }


        // constructor
        public Auto(string NomeAuto)
        {
            _name = NomeAuto;
            
        }

        // Functions  
    }


    public class Paese 
    {
        public string _name;
        public Paese(string Nome)
        {
            _name = Nome;
        }
    }

    public abstract class FiguraGeometrica
    {
        protected int _perimentro;

        /// Constructor 
        
    }
    public class Circle : FiguraGeometrica
    {   
        /// Definire il constructor
        /// dati Const 
        /// Dati variabili
    }
   
    public class Retangle : FiguraGeometrica
    {  
        // Protected -> accesso da classi Child 
        // Private -> solo dalla classe stessa
        // Public -> dall'esterno 

       protected int _base;
       protected int _altezza;
      
        public int Base { get { return _base; } }
        public int Altezza { get { return _altezza; } }
        public Retangle(int Base, int Altezza) 
        {
            _base = Base;
            _altezza = Altezza;
             
        }
    }
    public class Square : Retangle
    {
        
        public int Lato { get { return _altezza;  } }
        public Square(int Lato) : base(Lato, Lato) // 20, 20
        {
           
        }
    }
}

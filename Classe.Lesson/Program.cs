using System;

namespace Classe.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Auto auto1 = new Auto("BMW");
            Console.WriteLine(auto1.Name);

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
}

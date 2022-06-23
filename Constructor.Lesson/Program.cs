using System;

namespace Constructor.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contiente contiente = new Contiente(1000,"Europa"); 
            // contiente.IncrementaSpesaMilitare(1000);

            //Console.WriteLine(" Totale Spesa militare: "+
            //    contiente.TotaleSpesaMilitare);

            //    contiente.TotaleSpesaMilitare = 3000;

            //Console.WriteLine(" Totale Spesa militare: " +
            //   contiente.TotaleSpesaMilitare); 

            Person bruno = new Person("Bruno", "Ferreira");
            Console.WriteLine(bruno.GetFullName());
        }
    }

    public abstract class AreaGeografica
    {
         protected int _nPositivi; 
         int _nAbitanti;
         int _area; 
         int _geoPosition;
        public AreaGeografica(int NPositivi)
        {
            _nPositivi = NPositivi;
        }

    }
    public class Contiente : AreaGeografica, INATO
    { 
        string _name;
        int _spesaEsercito;
        int _spesaArmamenti;
        int _totSpesa;

        public int TotaleSpesaMilitare 
        {
            get
            {
                return _totSpesa =  _spesaEsercito +  _spesaArmamenti;
            }
            set
            {
                var ingresso = value; // 3000
                _spesaArmamenti = ingresso / 2;
                _spesaEsercito = ingresso / 2;
                _totSpesa = _spesaArmamenti + _spesaEsercito;
            }

        }
        public Contiente(int NPositivi, string Name) :base(NPositivi)
        {   
            this._name = Name;
           // Console.WriteLine("AreaGeografica._nPositivi : " + base._nPositivi);
        }
        public void  IncrementaSpesaMilitare(int budget)
        {
            _spesaEsercito = budget / 2;
            _spesaArmamenti = budget / 2;
            Console.WriteLine($"Spesa armamenti: {_spesaArmamenti} ");
            Console.WriteLine($"Spesa Esercito: {_spesaEsercito} ");            
        }
    }
    public interface INATO
    {   
        public int TotaleSpesaMilitare { get; }
        public void IncrementaSpesaMilitare(int budget);
    }



    class Person
    {
        string _name;
        string _surename; 

        public string FullName
        {
            get
            {
                return $"Fullname: {_name} { _surename}"; // interpolazione
            }
        }
        public string GetFullName()
        {
            return $"Fullname: {_name} { _surename}"; // interpolazione

        }

        public Person(string Name , string Surname)
        {
            _surename = Surname;    
            _name = Name;   
        }

        
    }


}

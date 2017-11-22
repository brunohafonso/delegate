using System;

namespace projeto_delegate
{
    class Program
    {

        public delegate void Cortador(string queijo);

        static void Main(string[] args)
        {
            Cortador vera = new Cortador(DataAbreviada);
            vera("OLá, eu sou um delegate");
            Cortador filha = new Cortador(DataCompleta);
            filha("Bruno");  
        }

        static void DataAbreviada(string texto)
        {
            System.Console.WriteLine("{0}, hoje é {1}", texto, DateTime.Now.ToShortDateString());
        }

        static void DataCompleta(string nome)
        {
            System.Console.WriteLine("Olá {0}, hoje é {1}", nome, DateTime.Now.ToLongDateString()); 
        }
    }
}

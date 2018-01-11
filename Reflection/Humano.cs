using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Humano
    {

        private string TipoSanguineo { get; set; }
        public int Idade { get; set; }
        public int Altura { get; set; }
        public Double Peso { get; set; }
        public string Nome { get; set; }




        public void Piscar()
        {
            Console.WriteLine("Piscar os olhos agora.");
        }
        public void Respirar()
        {
            Console.WriteLine("Repirar 1...2...3");
        }
        public void PensarAlgo(string pensamentos, DateTime quando)
        {
            Console.WriteLine("Estou pensando em : " + pensamentos + " pensei nisso agora : " + quando.ToShortTimeString());
        }

        public void SentirFome()
        {
            Console.WriteLine("Estou ficando com fome. Hora do Lanche.");
        }
        private void CantarNoBanheiro()
        {
            Console.WriteLine("Bla ... Bla ... Bla ...");
        }

    }
}

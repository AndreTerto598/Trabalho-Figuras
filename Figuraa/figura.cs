using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuraa
{
        public class Figura
    {
        protected double _area;
        protected double _perimetro;
        protected string _nome;
        public List<Figura> nome = new List<Figura>();
       
         
        
        public double Area
        {

            get { return this._area; }
        }

        public double Perimetro
        {

            get { return this._perimetro; }
        }
        public string Nome
        {

            get { return this._nome; }
        }
        public void Catalogo()
        {
            string nomec1 = "Circulo 1";
            Circulo circulo1 = new Circulo(2,nomec1);

            nome.Add(circulo1);

            Circulo circulo2 = new Circulo(6, nomec1);

            nome.Add(circulo2);

            Retangulo retangulo1 = new Retangulo(4, 6, "Retangulo 1");


            nome.Add(retangulo1);

            Retangulo retangulo2 = new Retangulo(8, 10, "Retangulo 2");
            nome.Add(retangulo2);

        }
        public void Apresentar()
        {
            int numero = 1;
            foreach (var figura in nome)
            {
                
                Console.WriteLine("Figura "+numero);
                Console.WriteLine("Area: "+figura.Area);
                Console.WriteLine("Perímetro: " + figura.Perimetro);
                numero++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuraa
{
    public class Circulo : Figura
    {
        private double _raio;
        private string _nome;

        public string Nome
        {
            get
            {
                return this._nome;
            }

            set
            {
                this._nome = value;
            }
        }
        public double Raio 
        {
            
            get
            {
                return this._raio;
            }

            
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Raio inválido");
                }
                else
                {
                    this._raio = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public Circulo(double raio,string nome)
        {
            this.Nome = nome;
            this.Raio = raio;
        }
        private void AtualizarArea()
        {
            this._area = Math.PI * this._raio * this._raio;
        }
        private void AtualizarPerimetro()
        {
            this._perimetro = 2 * Math.PI * this._raio;
        }
    }
}


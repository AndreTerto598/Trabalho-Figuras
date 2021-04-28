using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuraa
{
    public class Retangulo : Figura
    {
        private double _base;
        private string _nome;
        private double _altura;

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
        public double Base
        {

            get
            {
                return this._base;
            }


            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Base inválida");
                }
                else
                {
                    this._base = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public double Altura
        {

            get
            {
                return this._altura;
            }


            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Altura inválida");
                }
                else
                {
                    this._altura = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public Retangulo(double basse,double altura,string nome)
        {
            this.Nome = nome;
            this.Altura = altura;
            this.Base = basse;
        }
        private void AtualizarArea()
        {
            this._area =  this._altura * this._base;
        }
        private void AtualizarPerimetro()
        {
            this._perimetro = 2 * this._base + 2* this._altura;
        }
    }
}

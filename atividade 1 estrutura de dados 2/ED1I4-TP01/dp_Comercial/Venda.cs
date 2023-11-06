using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dp_Comercial
{
    internal class Venda
    {
        private int quantidade;
        private double valor;

        public Venda(int qntd = 0, double valor = 0)
        {
            this.quantidade = qntd;
            this.valor = valor;
        }

        public int Qntd {
            get => this.quantidade;
            
        }

        public double Valor
        {
            get => this.valor;
        }

        public double valorMedio()
        {
            if (this.quantidade == 0)
            {
                return 0;
            }
            
            return this.valor / this.quantidade;
        }
    }
}

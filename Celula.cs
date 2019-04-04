using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApMatrizEsparsa
{
    public class Celula
    {
        Celula direita, abaixo;
        int linha, coluna;
        double valor;

        public Celula(int l, int c, double v)
        {
            linha = l;
            coluna = c;
            valor = v;
        }

        public double Valor { get => valor; set => valor = value; }
        public int Linha { get => linha; set => linha = value; }
        public int Coluna { get => coluna; set => coluna = value; }
        public Celula Direita { get => direita; set => direita = value; }
        public Celula Abaixo { get => abaixo; set => abaixo = value; }

        public override string ToString()
        {
            return "( " + this.Valor + "; " + this.Linha + "; " + this.Coluna + " )";
        }
    }
}

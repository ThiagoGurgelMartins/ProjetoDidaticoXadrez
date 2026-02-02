using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    internal class PosicaoXadrez // classe que tem funcao de transformar a matriz em notacao de xadrez
    {
        public char coluna {  get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a'); // metodo pra matematicamente transformar
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}

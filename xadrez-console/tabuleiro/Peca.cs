using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez_console.tabuleiro
{
    internal class Peca// classe generica
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab {  get; protected set; }

        public Peca(Tabuleiro tab, Cor cor )// quando crio uma peca, ela ainda não tem posicao
        {
            this.posicao = null;
            this.cor = cor;
            this.qteMovimentos = 0;
            this.tab = tab;
        }
    }
}

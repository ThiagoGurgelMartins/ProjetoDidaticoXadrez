using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;
using xadrez_console.tabuleiro;

namespace xadrez
{
    internal class Rei : Peca// rei herda de Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { }//cria construtor que quando for usado vai repassar a instrucao pra classe base (Pecas);
        public override string ToString()
        {
            return "R";
        }
    }
}

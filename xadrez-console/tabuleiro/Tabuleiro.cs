using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas {  get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; // cria matriz do tabuleiro e bloqueio ela de ser usada em outras classes

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];// recebe uma matriz de pecas com n linhas e ne colunas. O tabuleiro é ligado as PECAS, onde não tem pecas tem null 
        }
        public Peca peca (int linha, int coluna)// metodo publico que pode acessar uma peça. A matriz peca so pode ser acessada atraves daqui
        {
            return pecas[linha, coluna];
        }
    }
}

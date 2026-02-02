using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    internal class TabuleiroException: Exception // classe ta herdando da excecao pra criar um excessao personalizada
    {
        public TabuleiroException(string msg): base (msg)
        { }
    }
}

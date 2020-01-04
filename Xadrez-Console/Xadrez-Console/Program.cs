using System;
using tabuleiro;
using tabuleiro.Enums;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P = new Posicao(3, 4);

            Tabuleiro tab = new Tabuleiro(8, 8);

            Cor cor = Cor.Branca;

            Peca peca = new Peca(P, cor, tab);
        }
    }
}

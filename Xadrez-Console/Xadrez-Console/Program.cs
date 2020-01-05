using System;
using tabuleiro;
using tabuleiro.Enums;
using tabuleiro.Exceptions;
using Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(0, 0));
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(1, 1));
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 2));

            Tela.ImprimirTabuleiro(tabuleiro);
        }
    }
}

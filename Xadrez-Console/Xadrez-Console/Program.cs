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
            PartidaDeXadrez partida = new PartidaDeXadrez();

            Tela.ImprimirTabuleiro(partida.tabuleiro);
        }
    }
}

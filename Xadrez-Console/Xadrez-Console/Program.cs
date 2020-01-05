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

            while (!partida.Terminada) {
                Console.Clear();
                Tela.ImprimirTabuleiro(partida.tabuleiro);

                Console.WriteLine();

                Console.Write("Origem: ");
                Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                bool[,] posicoesPossiveis = partida.tabuleiro.PosicaoDaPeca(origem).MovimentosPossiveis();

                Console.Clear();
                Tela.ImprimirTabuleiro(partida.tabuleiro, posicoesPossiveis);


                Console.WriteLine();

                Console.Write("Destino: ");
                Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                partida.ExecutaMovimento(origem, destino);
            }
        }
    }
}

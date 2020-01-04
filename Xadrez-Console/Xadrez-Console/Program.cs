﻿using System;
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
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroExceptions e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

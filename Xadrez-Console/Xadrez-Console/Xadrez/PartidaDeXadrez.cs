using System;
using tabuleiro;
using tabuleiro.Enums;

namespace Xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tabuleiro { get; private set; }
        private int Turno;
        private Cor JogadorAtual;

        public PartidaDeXadrez()
        {
            tabuleiro = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = tabuleiro.RetirarPeca(origem);
            peca.IncrementarQuantidadeDeMovimentos();
            Peca pecaCapturada = tabuleiro.RetirarPeca(destino);
            tabuleiro.ColocarPeca(peca, destino);
        }

        private void ColocarPecas()
        {
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new PosicaoXadrez('a', 1).ToPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new PosicaoXadrez('h', 1).ToPosicao());

            tabuleiro.ColocarPeca(new Cavalo(tabuleiro, Cor.Branca), new PosicaoXadrez('b', 1).ToPosicao());
            tabuleiro.ColocarPeca(new Cavalo(tabuleiro, Cor.Branca), new PosicaoXadrez('g', 1).ToPosicao());

            tabuleiro.ColocarPeca(new Bispo(tabuleiro, Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
            tabuleiro.ColocarPeca(new Bispo(tabuleiro, Cor.Branca), new PosicaoXadrez('f', 1).ToPosicao());

            tabuleiro.ColocarPeca(new Rainha(tabuleiro, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());

            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('a', 8).ToPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('h', 8).ToPosicao());

            tabuleiro.ColocarPeca(new Cavalo(tabuleiro, Cor.Preta), new PosicaoXadrez('b', 8).ToPosicao());
            tabuleiro.ColocarPeca(new Cavalo(tabuleiro, Cor.Preta), new PosicaoXadrez('g', 8).ToPosicao());

            tabuleiro.ColocarPeca(new Bispo(tabuleiro, Cor.Preta), new PosicaoXadrez('c', 8).ToPosicao());
            tabuleiro.ColocarPeca(new Bispo(tabuleiro, Cor.Preta), new PosicaoXadrez('f', 8).ToPosicao());

            tabuleiro.ColocarPeca(new Rainha(tabuleiro, Cor.Preta), new PosicaoXadrez('d', 8).ToPosicao());
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new PosicaoXadrez('e', 8).ToPosicao());

            for (int i = 97; i <= 104; i++)
            {
                tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez(Convert.ToChar(i), 2).ToPosicao());
                tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez(Convert.ToChar(i), 7).ToPosicao());
            }
        }
    }
}

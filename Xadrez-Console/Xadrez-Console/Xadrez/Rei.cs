using tabuleiro;
using tabuleiro.Enums;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor)
            : base(tab, cor)
        {

        }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tab.PosicaoDaPeca(posicao);
            return ((peca == null) || (peca.Cor != this.Cor));
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //NORTE
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tab.PosicaoEhValida(pos) && PodeMover(pos))
                matriz[pos.Linha, pos.Coluna] = true;

            //NORDESTE
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tab.PosicaoEhValida(pos) && PodeMover(pos))
                matriz[pos.Linha, pos.Coluna] = true;

            //LESTE
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tab.PosicaoEhValida(pos) && PodeMover(pos))
                matriz[pos.Linha, pos.Coluna] = true;

            //SUDESTE
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tab.PosicaoEhValida(pos) && PodeMover(pos))
                matriz[pos.Linha, pos.Coluna] = true;

            //SUL
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tab.PosicaoEhValida(pos) && PodeMover(pos))
                matriz[pos.Linha, pos.Coluna] = true;

            //SUDOESTE
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tab.PosicaoEhValida(pos) && PodeMover(pos))
                matriz[pos.Linha, pos.Coluna] = true;

            //OESTE
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tab.PosicaoEhValida(pos) && PodeMover(pos))
                matriz[pos.Linha, pos.Coluna] = true;

            //NOROESTE
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tab.PosicaoEhValida(pos) && PodeMover(pos))
                matriz[pos.Linha, pos.Coluna] = true;

            return matriz;
        }

        public override string ToString()
        {
            return "R";
        }
    }

}

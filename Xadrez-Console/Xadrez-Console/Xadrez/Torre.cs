using tabuleiro;
using tabuleiro.Enums;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor)
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
            while (Tab.PosicaoEhValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if ((Tab.PosicaoDaPeca(pos) != null) && (Tab.PosicaoDaPeca(pos).Cor != Cor))
                    break;
                pos.Linha = pos.Linha - 1;
            }

            //SUL
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.PosicaoEhValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if ((Tab.PosicaoDaPeca(pos) != null) && (Tab.PosicaoDaPeca(pos).Cor != Cor))
                    break;
                pos.Linha = pos.Linha + 1;
            }

            //LESTE
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tab.PosicaoEhValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if ((Tab.PosicaoDaPeca(pos) != null) && (Tab.PosicaoDaPeca(pos).Cor != Cor))
                    break;
                pos.Coluna = pos.Coluna + 1;
            }

            //OESTE
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.PosicaoEhValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if ((Tab.PosicaoDaPeca(pos) != null) && (Tab.PosicaoDaPeca(pos).Cor != Cor))
                    break;
                pos.Coluna = pos.Coluna - 1;
            }

            return matriz;
        }

        public override string ToString()
        {
            return "T";
        }
    }

}

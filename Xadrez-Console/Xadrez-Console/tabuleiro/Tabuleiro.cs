using tabuleiro;
using tabuleiro.Exceptions;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca PosicaoDaPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca PosicaoDaPeca(Posicao posicao)
        {
            return Pecas[posicao.Linha, posicao.Coluna];
        }

        public bool ExistePecaNaPosicao(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return PosicaoDaPeca(posicao) != null;
        }

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if (ExistePecaNaPosicao(posicao))
                throw new TabuleiroExceptions("Já existe uma peça nessa posição!");
            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        public Peca RetirarPeca(Posicao posicao)
        {
            if (PosicaoDaPeca(posicao) == null)
                return null;
            Peca aux = PosicaoDaPeca(posicao);
            aux.Posicao = null;
            Pecas[posicao.Linha, posicao.Coluna] = null;
            return aux;
        }

        public bool PosicaoEhValida(Posicao posicao)
        {
            if ((posicao.Linha < 0) || (posicao.Linha >= Linhas) || (posicao.Coluna < 0) || (posicao.Coluna >= Colunas))
                return false;
            return true;
        }

        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoEhValida(posicao))
                throw new TabuleiroExceptions("Posição inválida!");
        }
    }
}

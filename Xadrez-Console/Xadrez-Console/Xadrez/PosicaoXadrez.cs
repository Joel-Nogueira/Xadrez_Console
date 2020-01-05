using tabuleiro;

namespace Xadrez
{
    class PosicaoXadrez
    {
        public char Linha { get; set; }
        public char Coluna { get; set; }

        public PosicaoXadrez(char coluna, char linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao()
        {
            return new Posicao(49 - Linha, Coluna - 'a' + 7);
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}

using tabuleiro;
using tabuleiro.Enums;

namespace Xadrez
{
    class Rainha : Peca
    {
        public Rainha(Tabuleiro tab, Cor cor)
            : base(tab, cor)
        {

        }

        public override bool[,] MovimentosPossiveis()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "D";
        }
    }

}

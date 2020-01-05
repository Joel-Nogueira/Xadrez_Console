using tabuleiro.Enums;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdDeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            QtdDeMovimentos = 0;
            Tab = tab;
        }

        public abstract bool[,] MovimentosPossiveis();

        public void IncrementarQuantidadeDeMovimentos()
        {
            QtdDeMovimentos++;
        }
    }
}

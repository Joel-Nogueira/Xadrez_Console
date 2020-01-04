using tabuleiro;

namespace Xadrez_Console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i ++)
            {
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (tabuleiro.PosicaoDaPeca(i, j) == null)
                        System.Console.Write("- ");
                    else
                        System.Console.Write(tabuleiro.PosicaoDaPeca(i, j) + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}

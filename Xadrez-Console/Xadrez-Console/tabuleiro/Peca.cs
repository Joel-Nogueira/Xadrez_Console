﻿using tabuleiro.Enums;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdDeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;
            QtdDeMovimentos = 0;
            Tab = tab;
        }
    }
}

﻿

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao {get; set;}
        public Cor cor { get; protected set; }
        public int qteMovimento { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca (Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tabuleiro = tab;
            this.cor = cor;
            this.qteMovimento = 0;

        }

    }
}

using System;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        private Tabuleiro _tabuleiro;
        private int _turno;
        private Cor _jogadorAtual;

        public PartidaDeXadrez()
        {
            _tabuleiro = new Tabuleiro(8, 8);
            _turno = 1;
            _jogadorAtual = Cor.Branca;
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = _tabuleiro.RetirarPeca(origem);
            p.IncrementarQtdMovimentos();
            Peca pecaCapturada = _tabuleiro.RetirarPeca(destino);
            _tabuleiro.ColocarPeca(p, destino);
        }
    }
}

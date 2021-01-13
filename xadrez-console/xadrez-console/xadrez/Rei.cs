using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor)
            :base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao posicao = new Posicao(0, 0);

            //acima
            posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            //ne
            posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            //direita
            posicao.DefinirValores(posicao.Linha, posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            //se
            posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            //abaixo
            posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            //so
            posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            //esquerda
            posicao.DefinirValores(posicao.Linha, posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            //no
            posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            return matriz;
        }
    }
}

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Tabuleiro = tabuleiro;
            Cor = cor;
            QtdMovimentos = 0;
        }

        public void IncrementarQtdMovimentos()
        {
            QtdMovimentos++;
        }

        public bool PodeMover(Posicao posicao)
        {
            Peca p = Tabuleiro.Peca(posicao);
            return (p == null) || (p.Cor != Cor);
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}

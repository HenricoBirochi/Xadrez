using XadrezConsole.Entities.Enums;

namespace XadrezConsole.Entities
{
    internal abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QtdMovimentos = 0;
        }

        public void IncrementarMovimentos()
        {
            QtdMovimentos++;
        }
        public abstract bool[,] MovimentosPossiveis();
    }
}

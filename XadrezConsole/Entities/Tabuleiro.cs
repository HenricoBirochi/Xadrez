using XadrezConsole.Entities.Exceptions;

namespace XadrezConsole.Entities
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }
        public Peca AcessarPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
        public Peca AcessarPeca(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }
        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return AcessarPeca(pos) != null;
        }
        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Ja existe uma peça nessa posição");
            }
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
        public void ValidarPosicao(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha > Linhas || pos.Coluna < 0 || pos.Coluna > Colunas)
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}

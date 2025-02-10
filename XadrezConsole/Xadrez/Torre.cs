using XadrezConsole.Entities;
using XadrezConsole.Entities.Enums;

namespace XadrezConsole.Xadrez
{
    internal class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}

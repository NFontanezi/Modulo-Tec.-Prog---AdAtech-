using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_JogoDaVelha
{
    public class Jogada
    {
        public int PosicaoLin { get; set; }   
        public int PosicaoCol { get; set; }

        public Player Player { get; set; }

        public Jogada (Player player, int posicaoLin, int posicaoCol)
        {
            Player = player;
            PosicaoLin = posicaoLin;
            PosicaoCol = posicaoCol;
        }
    }
}

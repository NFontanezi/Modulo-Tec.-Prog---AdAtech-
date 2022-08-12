using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_JogoDaVelha
{
    public class Tabuleiro
    {
        public Player Player1{ get; set; }
        public Player Player2 { get; set; }

        public string[,] Grade { get; set; }

        public Tabuleiro(Player player1, Player player2)
        {
            Player1 = player1;   
            Player2 = player2;
            //Grade = matriz;
        }

        

       public void  GerarNovoTab(Tabuleiro tabuleiro)
        {
            Grade = new string[3, 3];
            
            for (int i = 0; i < Grade.GetLength(0); i++)
            {
                for (int j=0; j < Grade.GetLength(1); j++)
                {
                    Grade[i, j] = "|_|";
                    
                }
            }
        }

        public void MostrarTab(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Grade.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.Grade.GetLength(1); j++)
                {
                    Console.WriteLine(Grade[i, j]);

                }
            }
        }

    }



    }


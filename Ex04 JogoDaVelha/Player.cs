﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_JogoDaVelha
{
    public class Player
    {
        public Jogada Jogada { get; set; }
        public string Nome { get; set; }

        public Player(string nome)
        {
            Nome = nome;
        }
    }

    
}
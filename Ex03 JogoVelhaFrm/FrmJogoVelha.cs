using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex03_JogoVelhaFrm
{
    public partial class FrmJogoVelha : Form
    {
        public FrmJogoVelha()
        {
            InitializeComponent();
        }

        static int linha, coluna;
        static string vez = "X";
        static bool fimdeJogo = false;
        static bool haVencedor = false;

        static int countJogadas = 0;
        static int[,] jogo = new int[3, 3];

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = vez;
            linha = 0; coluna = 0;
            MarcarPosicao(linha, coluna);
            VerificarGanhador();
            Vez();

        }


        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Text = vez;
            linha = 0; coluna = 1;
            MarcarPosicao(linha, coluna);
            VerificarGanhador();
            Vez();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn3.Text = vez;
            linha = 0; coluna = 2;
            VerificarGanhador();
            Vez();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Text = vez;
            linha = 1; coluna = 0;
            MarcarPosicao(linha, coluna);
            VerificarGanhador();
            Vez();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Text = vez;
            linha = 1; coluna = 1;
            MarcarPosicao(linha, coluna);
            VerificarGanhador();
            Vez();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Text = vez;
            linha = 1; coluna = 2;
            MarcarPosicao(linha, coluna);
            VerificarGanhador();
            Vez();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Text = vez;
            linha = 2; coluna = 0;
            MarcarPosicao(linha, coluna);
            VerificarGanhador();
            Vez();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Text = vez;
            linha = 2; coluna = 1;
            MarcarPosicao(linha, coluna);
            VerificarGanhador();
            Vez();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Text = vez;
            linha = 2; coluna = 2;
            MarcarPosicao(linha, coluna);
            VerificarGanhador();
            Vez();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ResetJogo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }



        public static void MarcarPosicao(int l, int c)
        {
            if (vez == "X")
                jogo[l, c] = 1;
            else
                jogo[l, c] = 0;

            countJogadas++;


        }

        public void Vez()
        {
            if (haVencedor)
                ResetJogo();
            else
                vez = vez == "X" ? "O" : "X";
        }

        int auxvez = vez == "X" ? 1 : 2;

        public bool VerificarGanhador()
        {
            
            if (countJogadas >= 5&& countJogadas<=9)
            {
                if (VerificarLinhas() ||
                VerificarColunas() ||
                VerificarDiagonais())
                {
                    WinMsg();
                    return true;

                }
                else
                {
                    if (countJogadas == 9)
                    {
                        Empate();
                        return false;
                    }
                    else
                    {
                        ProximaJogada();
                        return false;

                    }
                }
            }

            else
            {
                ProximaJogada();
                return false;

            }
        }
        public bool VerificarLinhas()
        {
            if ((jogo[0, 0] == jogo[0, 1] && jogo[0, 0] == jogo[0, 2] && jogo[0, 0] == auxvez) ||
                    (jogo[1, 0] == jogo[1, 1] && jogo[1, 0] == jogo[1, 2] && jogo[1, 0] == auxvez) ||
                     (jogo[2, 0] == jogo[2, 1] && jogo[2, 0] == jogo[2, 2] && jogo[2, 0] == auxvez))
            {
                return true;
            }

            else return false;
        }

        public bool VerificarColunas()
        {
            if ((jogo[0, 0] == jogo[1, 0] && jogo[0, 0] == jogo[2, 0] && jogo[0, 0] == auxvez) ||
                    (jogo[0, 1] == jogo[1, 1] && jogo[0, 1] == jogo[2, 1] && jogo[0, 1] == auxvez) ||
                     (jogo[0, 2] == jogo[1, 2] && jogo[0, 2] == jogo[2, 2] && jogo[0, 2] == auxvez))
            {

                return true;
            }

            else
            {
                return false;

            }
        }

        public bool VerificarDiagonais()
        {
            if ((jogo[0, 0] == jogo[1, 1] && jogo[0, 0] == jogo[2, 2] && (jogo[0, 0] == auxvez)) ||
                    (jogo[2, 0] == jogo[1, 1] && jogo[2, 0] == jogo[0, 2] && jogo[2, 0] == auxvez))
            {

                return true;
            }

            else return false;

        }

        public void WinMsg()
        {
            txtResult.Text = $"O campeão foi: {vez}";
            fimdeJogo = true;
        }
        public void ProximaJogada()
        {
            string vezprox = vez == "X" ? "O" : "X";
            txtResult.Text = $"A vez da jogada é de: {vezprox}";
        }
        public void Empate()
        {
            txtResult.Text = $"Tentem outra vez";
            fimdeJogo = true;
        }



        public void ResetJogo()
        {
            vez = "X";
            fimdeJogo = false;
            haVencedor = false;
            countJogadas = 0;
            btn1.Text = String.Empty;
            btn2.Text = String.Empty;
            btn3.Text = String.Empty;
            btn4.Text = String.Empty;
            btn5.Text = String.Empty;
            btn6.Text = String.Empty;
            btn7.Text = String.Empty;
            btn8.Text = String.Empty;
            btn9.Text = String.Empty;
            txtResult.Text = String.Empty;
            Array.Clear(jogo);



        }
    }


}

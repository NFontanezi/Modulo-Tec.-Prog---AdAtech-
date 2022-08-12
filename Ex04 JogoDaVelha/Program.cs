// See https://aka.ms/new-console-template for more information

using Ex04_JogoDaVelha;

bool fimJogo = false;
bool sairAplicacao = false;

Uteis.Show("###Jogo da Velha###");
Uteis.Show("Entre com o nome do Jogador 1: ");
string nomeP1  = Console.ReadLine();

Uteis.Show("Entre com o nome do Jogador 2: ");
string nomeP2 = Console.ReadLine();

Player P1 = new Player(nomeP1);
Player P2 = new Player(nomeP2);

Tabuleiro Jogo = new(P1, P2);






/*
do
{

    MostrarTabuleiro();
    LerJogada();
    VerificarJogada();
    MarcarJogada();
    VerificarPonto();
    MudarVez();

} while (!fimJogo);
*/

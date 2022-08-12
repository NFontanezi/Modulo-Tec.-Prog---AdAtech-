// See https://aka.ms/new-console-template for more information


Console.WriteLine("Entre com a quantidade de linhas");
int linhas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entre com a quantidade de colunas");
int colunas = Convert.ToInt32(Console.ReadLine());
int valor = 1;
int[,] matriz = new int[linhas, colunas];

for(int i = 0; i<linhas; i++)
{
    for (int j = 0; j < colunas; j++)
        matriz[i, j] = valor++;

}

for (int i = 0; i < linhas; i++)
{
        Console.WriteLine("");
    for (int j = 0; j < colunas; j++)
    {
        Console.Write(".");
        Console.Write(matriz[i, j]);
    }
}


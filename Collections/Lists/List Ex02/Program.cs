// See https://aka.ms/new-console-template for more information

List<int> lista1 = new()
{
   1, 2, 3, 4
};
int posicao0 = 0;
int maior = 0;
int menor = 0;

CalcularLista(lista1);

void CalcularLista(List<int> lista)
{
    maior = lista[0];
    menor = lista[0];

    for (int i=0; i<lista.Count; i++)
    {

        if (i > 0 && i <= lista.Count)
        {
            if(lista[i] > (lista[i-1]))
            {
                maior = lista[i];
            }
            else menor = lista[i];
        }
    }

    Console.WriteLine(maior - menor);

}

/*foreach (int item in lista)
{
    posicao0 = item;

    if (item > posicao0)
    {

        maior = +item;
    }

}
foreach (int item in lista)
{
    menor = item;
    if (item < menor)
    {
        menor = item;
    }
}*/





// See https://aka.ms/new-console-template for more information

List<int> lista1 = new()
{
   2, 4, -1, -3
};

List<int> listaDifZero = new();

int diferencaAtual = 0;


PrxZero(lista1);

void PrxZero(List<int> lista)
{

    for (int i = 0; i < lista.Count; i++)
    {

        diferencaAtual = Math.Abs(lista[i]);

        listaDifZero.Add(diferencaAtual);

    }


    if (haValoresIguais(listaDifZero))
    {
        Console.WriteLine("Nenhum");
    }
    else 
    {
        int menorValor = listaDifZero.Min();

        int posicaomenorValor = listaDifZero.IndexOf(menorValor);

        Console.WriteLine(lista1[posicaomenorValor]);
    }


}
bool haValoresIguais(List<int> listaAbs)
{
    List<int> listaDupli = listaAbs.Distinct().ToList();

    if (listaDupli.Count == listaAbs.Count)
        return false;

    else return true;

}

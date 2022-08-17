// See https://aka.ms/new-console-template for more information


List<int> lista1 = new()
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15
};



int countPos = 0;
int somaNeg = 0;

LerLista(lista1);


void LerLista(List<int> lista1)
{
    if (lista1.Count == 0)
    {
        Console.WriteLine("lista vazia ou nula");

    }
    else
    {

        foreach (int item in lista1)
        {

            if (item > 0) countPos++;

            else if (item < 0) somaNeg += item;

        }
        Console.WriteLine($"Soma Positivos: {countPos}\nSoma Negativos: {somaNeg}");
    }
}
/*

        return somaPos switch 
        {

            item < 0 => somaPos += item,
            //item > 0 => somaNeg += item,
            _ => null
        };

*/
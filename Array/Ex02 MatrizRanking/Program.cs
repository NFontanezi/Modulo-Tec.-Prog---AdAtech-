// See https://aka.ms/new-console-template for more information

int[] arrayNotas = new int[] { 5, 4, 9, 7, 6, 5 };

int[] arrayNotasDesc = new int[] { 5, 4, 9, 7, 6, 5 };

int[] arrayRank = new int[arrayNotas.Length];

Array.Sort(arrayNotasDesc);
Array.Reverse(arrayNotasDesc);

int index = 0;
int indexRank = 0;
int j = 0;


for (int i = 0; i < arrayNotas.Length; i++)
{
    j = 0;
    for ( j = 0; j < arrayNotasDesc.Length; j++)
    {
        if (arrayNotas[i] == arrayNotasDesc[j])
        {
            index = Array.IndexOf(arrayNotasDesc, arrayNotasDesc[j]);
            arrayRank[indexRank] = index+1;
            indexRank++;
            break;
        }
    }
}


Console.WriteLine("\nNotas: ");
foreach (int i in arrayNotas)
    Console.WriteLine(i);


Console.WriteLine("\nRanking: ");
foreach (int i in arrayRank)
    Console.WriteLine(i);

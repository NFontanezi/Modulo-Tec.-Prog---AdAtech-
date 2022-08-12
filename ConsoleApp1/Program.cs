// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] array1 = new int[10];
int countPar = 0;
int countImpar = 0;

bool inputval = false;
int input;

ShowMsg("Insira 10 numeros:");

for (int i = 0; i < array1.Length; i++)
{
    do
    {
        inputval = int.TryParse(Console.ReadLine(), out input) && input > 0;

       if(!inputval)
            ShowMsg("Numero invalido, tente novamente");

    }
    while (!inputval);

    array1[i] = input;

    if (isPar(input))
        countPar++;
    else countImpar++;
    inputval = false;
}
int indexpar = 0;
int indexImpar = 0;

int[] arrayPar = new int[countPar];
int[] arrayImpar = new int[countImpar];

foreach (int num in array1)
{
    if (isPar(num))
    {
      
        arrayPar[indexpar] = num;
        indexpar++;
    }
    else
    {
        arrayImpar[indexImpar] = num;
        indexImpar++;
    }
}

ShowMsg("\nArray 10 numeros:");
ShowResult(array1);

ShowMsg("\nArray numeros Pares:");
ShowResult(arrayPar);

ShowMsg("\nArray numeros Impares:");
ShowResult(arrayImpar);

static bool isPar(int num)
{
    if (num % 2 == 0)
        return true;

    else
        return false;
}

static void ShowResult(int []array)
{
    foreach (int i in array)
        Console.WriteLine(i);
}

static void ShowMsg(string msg)
{
    Console.WriteLine(msg);
}
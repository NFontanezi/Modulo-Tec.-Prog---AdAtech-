// See https://aka.ms/new-console-template for more information



int[] array1 = new int[9];
bool inputval = false;
int input;

Console.WriteLine("Insira 10 numeros:");

for(int i =0; i<= array1.Length;i++)
{
    do 
    {
        inputval = int.TryParse(Console.ReadLine(), out input) && input > 0;
        Console.WriteLine("Numero invalido, tente novamente");

    }
    while(!inputval);

    array1[i] = input;
    inputval = false;
}

foreach(int i in array1)
{
    Console.WriteLine(i);
}

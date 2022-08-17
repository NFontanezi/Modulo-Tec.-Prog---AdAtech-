// See https://aka.ms/new-console-template for more information

Dictionary<string, string> dicTradutor = new()
{

{"if", "se" },
{ "while", "enquanto" },
{ ">", "maior"},
{ "<", "menor"},
{ ">=", "maior igual que"},
{ "<=", "menor igual que"},
{ "==", "igual a"},
{ "!=", "diferente de"}

};

Console.WriteLine("Escreva o texo em c#: " );
char[] txt = Console.ReadLine().ToCharArray();

Console.WriteLine("traduzindo... ");

foreach( char item in txt )
{

}

bool existePalavra()
{

}
// See https://aka.ms/new-console-template for more information

/*Enunciado
Faça um script que leia uma frase do usuário e use um dicionário 
    que apresente as vogais e a frequência de sua aparição na frase.
*/



using System.Globalization;
using System.Text;

List<char> listaVogais = new()
{
 'a','e','i','o','u'
};

Dictionary<char, int> dicVogal = new();

Console.WriteLine("Escreva o texto: ");
string texto = Console.ReadLine().ToLower();
string txtTratado = RemoveDiacritics(texto);
char [] txt = txtTratado.ToCharArray();

foreach (char item in listaVogais)
{
    alimentarDic(item, txt);

}

foreach(var item in dicVogal)
{
    Console.WriteLine(item);
}

void alimentarDic(char vogal, char[]txt)
{
    int count = 0;
    for (int i = 0; i < txt.Length; i++)
    {

        if (txt[i] == vogal)
        {
            count++;
        }
    }
    dicVogal.Add(vogal, count);
}

static string RemoveDiacritics(string text)
{
    var normalizedString = text.Normalize(NormalizationForm.FormD);
    var stringBuilder = new StringBuilder();

    foreach (var c in normalizedString)
    {
        var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
        if (unicodeCategory != UnicodeCategory.NonSpacingMark)
        {
            stringBuilder.Append(c);
        }
    }

    return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
}
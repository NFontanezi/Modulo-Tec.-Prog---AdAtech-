// See https://aka.ms/new-console-template for more information
using System.Collections;



Console.WriteLine("Hello, World!");

ArrayList listaInicio = new ArrayList() {"Mercúrio", "Marte"};
listaInicio.Add("Jupiter");
listaInicio.Add("Saturno");

ArrayList listaFim = new ArrayList() { "Urano", "Netuno" };

listaInicio.AddRange(listaFim);

listaInicio.Insert(2, "Terra");
listaInicio.Insert(1, "Venus");
listaInicio.Add("Plutão");

ArrayList listaRochosos = listaInicio.GetRange(0, 4);

Console.WriteLine("Lista Planeta Rochosos");
foreach (var item in listaRochosos)
    Console.WriteLine(item);


listaInicio.Remove("Plutão");

Console.WriteLine("\nLista Planeta Atuais");
foreach (var item in listaInicio)
    Console.WriteLine(item);









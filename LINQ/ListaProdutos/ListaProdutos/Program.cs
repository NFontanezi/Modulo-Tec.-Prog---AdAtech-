// See https://aka.ms/new-console-template for more information


using System.Collections.Generic;
using static System.Console;


    List<Produto> listaProdutos = new()
{
new Produto{Id = 2, Nome = "Camiseta", Valor = 52, Ativo = true},
new Produto{Id = 8, Nome = "Guarda-Chuva", Valor = 19, Ativo = true},
new Produto{Id = 4, Nome = "Celular", Valor = 8500, Ativo = true},
new Produto{Id = 3, Nome = "Arroz", Valor = 21, Ativo = false},
new Produto{Id = 1, Nome = "Geladeira", Valor = 1900, Ativo = true},
new Produto{Id = 9, Nome = "Panela", Valor = 41, Ativo = true},
new Produto{Id = 5, Nome = "Chinelo", Valor = 11, Ativo = false},
new Produto{Id = 7, Nome = "TV", Valor = 2350, Ativo = true},
new Produto{Id = 6, Nome = "Patins", Valor = 66, Ativo = true},
};




/* Enunciado#1
Utilizando a fonte de dados disponibilizada, crie um método que retorne
uma lista de produtos cuja última letra do nome é a vogal "O".*/


 List<Produto> retornaUtimaletra(List<Produto> lista)
{
    return lista.Where(p => p.Nome.ToLower().EndsWith('o')).ToList();
}

/*Enunciado#2
crie um método que retorne a 
quantidade de produtos cujo valor é menor que 50 reais*/

List<Produto> retornaQtddeValor50(List<Produto> lista)
{
    return lista.Where(p => p.Valor < 50).ToList();
}

/*Enunciado#3
 crie um método que retorne 
a média de preço dos produtos inativos.*/
 
decimal retornaMediaInativos(List<Produto> lista)
{
    
      var listaTrue = lista.Where(p => p.Ativo == true);
    return listaTrue.Average(p => p.Valor);

}
/*Enunciado#4
crie um método que retorne o primeiro produto com valor inferior à 10 reais. 
Retorne nulo se não existir.*/

Produto primeiroInferior10(List<Produto> lista)
{

        return lista.FirstOrDefault(p => p.Valor < 10);
}

/*Enunciado#5
crie um método que ordene os produtos por Nome, em ordem decrescente, 
e retorne o último elemento da lista.*/

Produto retorneUltimoProduto(List<Produto> lista)
{
    return lista.OrderByDescending(p=>p.Nome).ToList().Last();

}

/*Enunciado#6
crie um método que permita a alteração dos valores dos produtos. 
Esse método irá receber o Id e o novo valor e irá realizar a atualização. 
Caso o Id não exista, exiba uma mensagem.*/

void atualizarValor(List<Produto> lista, int _id, decimal valor)
{
   List<Produto> lista1 = lista.Where(p => p.Id == _id).ToList();
    lista1.ForEach(p=>p.Valor=valor);

}


atualizarValor(listaProdutos, 4, 100);

foreach (var p in listaProdutos)
{
    WriteLine(p.ToString());
}
//var retorno = retorneUltimoProduto(listaProdutos);
//WriteLine(retorno);
/*atualizar ex:
var ValidCustomers = customers.Where(c => c.IsValid).ToList();
ValidCustomers.ForEach(c => c.CreditLimit = 1000);*/



public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Valor { get; set; }
    public bool Ativo { get; set; }


    public override string ToString()
    {
        return $"Id: {Id} | Nome: {Nome} | Valor: R$ {Valor}";
    }
}


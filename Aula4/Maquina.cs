using System;
using System.Collections.Generic;

class Maquina
{
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string TipoProduto { get; set; }
    public List<Produto> Produtos { get; set; }

    public Maquina(int id, string marca, string modelo, string tipoProduto)
    {
        Id = id;
        Marca = marca;
        Modelo = modelo;
        TipoProduto = tipoProduto;
        Produtos = new List<Produto>();
    }

    public void ExibirInformacoes() //Exibir informações da máquina
    {
        Console.WriteLine($"Identificador: {Id}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Tipo de Produto: {TipoProduto}");
    }

    public void IniciarProducao()
    {
        Console.WriteLine($"Máquina {Marca} {Modelo} iniciou a produção.");
    }

    public void AdicionarProduto(Produto produto) //Add um produto à máquina
    {
        Produtos.Add(produto);
        Console.WriteLine($"Produto '{produto.Nome}' adicionado a máquina '{Id}'.");
    }
}

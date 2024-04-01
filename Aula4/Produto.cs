using System;

class Produto
{
    public string Nome { get; set; }
    public string Codigo { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nome, string codigo, decimal preco)
    {
        Nome = nome;
        Codigo = codigo;
        Preco = preco;
    }

    public void ExibirDetalhes()  // Método exibir detalhes
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Preço: {Preco:C2}"); // Exibir o preço em formato de moeda
    }

    public void AtualizarPreco(decimal novoPreco)  // Método atualizar o preço
    {
        Preco = novoPreco;
        Console.WriteLine($"Preço do produto '{Nome}' atualizado para: {Preco:C2}");
    }
}

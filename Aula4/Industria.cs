using System;
using System.Collections.Generic;

class Indústria
{
    public string Nome { get; set; }
    public string Localização { get; set; }
    public int AnoFundacao { get; set; }
    public List<LinhaProducao> LinhasProducao { get; set; }

    public Indústria(string nome, string localização, int anoFundacao)
    {
        Nome = nome;
        Localização = localização;
        AnoFundacao = anoFundacao;
        LinhasProducao = new List<LinhaProducao>();
    }

    public void ExibirInformacoes() //Informações da indústria
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Localização: {Localização}");
        Console.WriteLine($"Ano de Fundação: {AnoFundacao}");
    }

    public void AdicionarLinhaProducao(LinhaProducao linhaProducao) //Add uma linha de produção à indústria
    {
        LinhasProducao.Add(linhaProducao);
        Console.WriteLine($"Linha de produção '{linhaProducao.Numero}' adicionada à indústria '{Nome}'.");
    }
}

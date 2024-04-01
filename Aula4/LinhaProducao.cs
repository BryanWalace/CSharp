using System;
using System.Collections.Generic;

class LinhaProducao
{
    public int Numero { get; set; }
    public string Tipo { get; set; }
    public int Capacidade { get; set; }
    public List<Maquina> Maquinas { get; set; }

    public LinhaProducao(int numero, string tipo, int capacidade)
    {
        Numero = numero;
        Tipo = tipo;
        Capacidade = capacidade;
        Maquinas = new List<Maquina>();
    }

    public void ExibirDetalhes() //Detalhes da linha de produção
    {
        Console.WriteLine($"Número: {Numero}");
        Console.WriteLine($"Tipo: {Tipo}");
        Console.WriteLine($"Capacidade: {Capacidade} produtos por hora");
    }

    public void AdicionarMaquina(Maquina maquina) //Add uma máquina à linha de produção
    {
        Maquinas.Add(maquina);
        Console.WriteLine($"Máquina '{maquina.Id}' adicionada à linha de produção '{Numero}'.");
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Indústria minhaIndústria = new Indústria("Fábrica de Automóveis", "Cidade Industrial", 1980); // Industri de auto
        
        LinhaProducao linha1 = new LinhaProducao(1, "Automóveis", 100); //Linha 1
        LinhaProducao linha2 = new LinhaProducao(2, "Motos", 50); //Linha 2

        minhaIndústria.AdicionarLinhaProducao(linha1); //Inclementando
        minhaIndústria.AdicionarLinhaProducao(linha2);

        Maquina maquina1Linha1 = new Maquina(1, "Volkswagen", "Hatch", "Polo"); //Maquina 1 volks - marca - modelo - carro
        Maquina maquina2Linha1 = new Maquina(2, "Volks", "Sedan", "Jetta"); //Maquina 2 ""

        linha1.AdicionarMaquina(maquina1Linha1); //Inclementando
        linha1.AdicionarMaquina(maquina2Linha1);

        Maquina maquina1Linha2 = new Maquina(1, "Kasinski", "Custom", "Mirage 250"); //Maquina 1 kasinski - marca - modelo - carro
        Maquina maquina2Linha2 = new Maquina(2, "Harley Davidson", "Cruiser", "Fat Bob"); //Maquina 2 Harley

        linha2.AdicionarMaquina(maquina1Linha2);
        linha2.AdicionarMaquina(maquina2Linha2);

        Console.WriteLine("Info indústria:"); //info
        minhaIndústria.ExibirInformacoes();
        Console.WriteLine();

        Console.WriteLine("Detalhes das linhas:");
        linha1.ExibirDetalhes();
        linha2.ExibirDetalhes();
        Console.WriteLine();

        Console.WriteLine("Máquinas nas linhas:");
        ExibirMaquinas(linha1);
        ExibirMaquinas(linha2);
    }

    static void ExibirMaquinas(LinhaProducao linha)
    {
        foreach (var maquina in linha.Maquinas)
        {
            Console.WriteLine($"Número: {maquina.Id}");
            Console.WriteLine($"Marca: {maquina.Marca}");
            Console.WriteLine($"Modelo: {maquina.Modelo}");
            Console.WriteLine($"Tipo de Produto: {maquina.TipoProduto}");
            Console.WriteLine();
        }
    }
}

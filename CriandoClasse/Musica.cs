class Musica
{
    public Musica(Banda artista, string nome, Cantor cantor)
    {
        Artista = artista;
        Nome = nome;
        InformacaoCantor = cantor;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";
    public Genero Genero { get; set; }
    public Cantor InformacaoCantor { get; }
    
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
        Console.WriteLine($"Genero: {Genero.NomeGenero}");
        Console.WriteLine($"Nome cantor: {InformacaoCantor.Nome}");
        Console.WriteLine($"Idade cantor: {InformacaoCantor.Idade}\n");

    }
}
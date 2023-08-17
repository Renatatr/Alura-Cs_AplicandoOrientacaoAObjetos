class Podcast
{
    private List<Episodios> episodios = new List<Episodios>();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }

    public int TotalEpisodios => episodios.Count;

    public void AdiconarEpsodio(Episodios episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
        foreach (Episodios episodio in episodios.OrderBy(prop => prop.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Total de epsódios: {TotalEpisodios}\n");
    }
}
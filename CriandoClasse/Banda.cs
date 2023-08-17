class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
        Nome = nome;
    }
    
    private List<Album> albuns = new List<Album>();
    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (var album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}
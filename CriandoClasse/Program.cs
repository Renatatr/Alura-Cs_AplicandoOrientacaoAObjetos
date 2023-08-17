Album albumOzzy = new Album("No more tears");
Banda ozzy = new Banda("Ozzy");

Musica musica1 = new Musica(ozzy, "Mama, I'm Coming Home")
{
    Duracao = 252,
    Disponivel = true,
};

Genero genero1 = new Genero();
musica1.Genero = genero1;
genero1.NomeGenero = "rock";

Musica musica2 = new Musica(ozzy, "Desire")
{
    Duracao = 500,
    Disponivel = false,
};
Console.WriteLine(musica2.DescricaoResumida);

Genero genero2 = new Genero();
musica2.Genero = genero2;
genero2.NomeGenero = "metal";

albumOzzy.AdicionarMusica(musica1);
albumOzzy.AdicionarMusica(musica2);

albumOzzy.ExibirMusicas();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

ozzy.AdicionarAlbum(albumOzzy);
ozzy.ExibirDiscografia();

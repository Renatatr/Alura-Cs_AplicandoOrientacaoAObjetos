Album albumOzzy = new Album();
albumOzzy.Nome = "No more tears";

Musica musica1 = new Musica();
musica1.Nome = "Mama, I'm Coming Home";
musica1.Artista = "Ozzy Osbourne";
musica1.Duracao = 252;
musica1.Disponivel = true;

Genero genero1 = new Genero();
musica1.Genero = genero1;
genero1.NomeGenero = "rock";

Musica musica2 = new Musica();
musica2.Nome = "Desire";
musica2.Artista = "Ozzy Osbourne";
musica2.Duracao = 500;
Console.WriteLine(musica2.DescricaoResumida);

Genero genero2 = new Genero();
musica2.Genero = genero2;
genero2.NomeGenero = "metal";

albumOzzy.AdicionarMusica(musica1);
albumOzzy.AdicionarMusica(musica2);

albumOzzy.ExibirMusicas();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

Banda ozzy = new Banda();
ozzy.Nome = "Ozzy";
ozzy.AdicionarAlbum(albumOzzy);
ozzy.ExibirDiscografia();

Album albumTeste = new Album();
albumTeste.Nome = "Testando album";

albumTeste.AdicionarMusica(musica1);

Banda teste = new Banda();
teste.Nome = "teste";
teste.AdicionarAlbum(albumTeste);
teste.ExibirDiscografia();
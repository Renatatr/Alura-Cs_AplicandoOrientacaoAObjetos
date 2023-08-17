Episodios ep1 = new Episodios( 1, "teste1", 72);
ep1.AdicionarCovidados("ca");
ep1.AdicionarCovidados("be");

Episodios ep2 = new Episodios( 2, "teste2", 21);
ep2.AdicionarCovidados("re");
ep2.AdicionarCovidados("tw");
ep2.AdicionarCovidados("as");

Podcast podcast = new Podcast("tatata", "zé");
podcast.AdiconarEpsodio(ep1);
podcast.AdiconarEpsodio(ep2);

podcast.ExibirDetalhes();

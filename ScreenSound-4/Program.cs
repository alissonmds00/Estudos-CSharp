using ScreenSound_4.Modelos;
using System.Text.Json;
using ScreenSound_4.Filtros;
using (HttpClient client = new  HttpClient())
{
  try
  {
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
    //LinqFilter.FiltrarTodosGenerosMusicais(musicas);
    //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
    //LinqFilter.FiltrarArtistasPorGeneroMuscial(musicas, "rock");
    //LinqFilter.FiltrarMusicasPorArtista(musicas ,"U2");
    // musicas[1].ExibirDetalhesDaMusica();
    // var musicasPreferidas = new MusicasFavoritas("Alisson");
    // musicasPreferidas.AdicionarMusicaAosFavoritos(musicas[55]);
    // musicasPreferidas.AdicionarMusicaAosFavoritos(musicas[5]);
    // musicasPreferidas.AdicionarMusicaAosFavoritos(musicas[155]);
    // musicasPreferidas.AdicionarMusicaAosFavoritos(musicas[50]);
    // musicasPreferidas.AdicionarMusicaAosFavoritos(musicas[555]);

    // musicasPreferidas.ExibirMusicasFavoritas();
    // musicasPreferidas.GerarArquivoJson();
    LinqFilter.FiltrarMusicasPorTonalidade(musicas);

  } catch (Exception ex)
  {
    Console.WriteLine(ex.Message);
  }
}
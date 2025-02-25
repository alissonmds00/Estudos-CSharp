using ScreenSound_4.Modelos;
using System.Linq;

namespace ScreenSound_4.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.
        OrderBy(musica => musica.Artista!).Select(musica => musica.Artista!).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados");
        foreach (string artista in artistasOrdenados)
        {
            Console.WriteLine(artista!);
        }
    }
}
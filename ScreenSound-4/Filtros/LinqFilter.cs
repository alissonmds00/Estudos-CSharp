using System.Linq;
using ScreenSound_4.Modelos;

namespace ScreenSound_4.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosGenerosMusicais(List<Musica> musicas)
    {
        var generosMusicais = musicas.
        Select(generos => generos.Genero!).
        Distinct().
        ToList();
        foreach (string genero in generosMusicais)
        {
            Console.WriteLine(genero!);
        }
    }

    public static void FiltrarArtistasPorGeneroMuscial(List<Musica> musicas, string genero)
    {
        var artistasFiltrados = musicas.
        Where(musica => musica.Genero!.
        Contains(genero)).
        Select(musica => musica.Artista!).
        Distinct()
        .ToList();
        Console.WriteLine($"Exibindo os artistas por gênero {genero}");
        foreach (string artista in artistasFiltrados)
        {
            Console.WriteLine(artista!);
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.
        Where(musica => musica.Artista!.Equals(artista)).
        ToList();
        Console.WriteLine($"Exibindo músicas do artista {artista}");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine(musica.Nome!);
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas)
    {
        var musicasFiltradas = musicas.
        Where(musica => musica.Tonalidade.Equals("C#")).
        Select(musica => musica.Nome). //seleciona o atributo nome apenas
        Distinct().
        ToList();
        Console.WriteLine("Mostrando músicas cuja tonalidade é o C#");
        foreach (var musica in musicasFiltradas)
        {
            Console.WriteLine($"{musica}");
        }
    }
}

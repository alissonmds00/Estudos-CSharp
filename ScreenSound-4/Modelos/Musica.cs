using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ScreenSound_4.Modelos;

internal class Musica
{
    private string[] tonalidade = {"C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"}; 
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade => tonalidade[Key];

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao/1000}s");
        Console.WriteLine($"Gênero musical: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}

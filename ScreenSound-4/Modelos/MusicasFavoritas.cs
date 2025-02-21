namespace ScreenSound_4.Modelos;
using System.Text.Json;
internal class MusicasFavoritas
{
    public string Nome { get; set; }
    private List<Musica> musicas;
    public IEnumerable<Musica> Musicas => musicas;

    public MusicasFavoritas(string nome)
    {
        Nome = nome;
        musicas = new List<Musica>();
    }

    public void AdicionarMusicaAosFavoritos(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas {Nome}");
        foreach (var musica in Musicas)
        {
            Console.WriteLine($"{musica.Nome} - {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = Musicas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo json criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}

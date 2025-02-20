

namespace poo_1
{
    public class Album
    {
        public string Nome { get; }
        public Banda Artista { get; }
        private List<Musica> Musicas = new List<Musica>();
        public int DuracaoTotal => Musicas.Sum(m => m.Duracao);

        public Album(string nome, Banda artista)
        {
            Nome = nome;
            Artista = artista;
        }

        public void AdicionarMusica(Musica musica)
        {
            Musicas.Add(musica);
        }

        public void MostrarMusicas()
        {
            this.Musicas.ForEach(musica => Console.WriteLine(musica.Nome));
            System.Console.WriteLine($"Para ouvir esse álbum, você precisará de {this.DuracaoTotal} segundos");
        }
    }
}

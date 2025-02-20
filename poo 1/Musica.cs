

namespace poo_1
{
    public class Musica
    {
        public string Nome { get; set; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }

        public Genero Genero { get; set; }


        public string DescricaoObra => 
            $"{Nome} - {Artista}";

        public Musica(string nome, Banda artista, int duracao, Genero genero)
        {
            this.Nome = nome;
            this.Artista = artista;
            this.Duracao = duracao;
            this.Genero = genero;
            this.Disponivel = true;
        }

        public Musica()
        {

        }

        public void ExibirFichaTecnica()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Artista: {Artista}");
            System.Console.WriteLine($"Duração: {Duracao}s");
            System.Console.WriteLine($"Gênero: {Genero}");
            if (Disponivel) 
            {
                System.Console.WriteLine("Disponível no plano");
            }
            else 
            {
                System.Console.WriteLine("Adquira o plano Plus+");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_1
{
    public class Banda
    {
        private List<Album> Albuns = new List<Album>();
        public string Nome { get; }

        public Banda(string nome) 
        {
            Nome = nome;
        }

        public void AdicionarAlbum(Album album)
        {
            this.Albuns.Add(album);
        }

        public void ExibirDiscografia() 
        {
            System.Console.WriteLine($"Discografia da banda {Nome}");
            foreach(Album album in Albuns)
            {
                System.Console.WriteLine($"Álbum: {album.Nome} {album.DuracaoTotal}");
            }
        }
    }
}
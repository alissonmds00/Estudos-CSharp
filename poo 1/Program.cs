namespace poo_1
{
  public class Program
  {
    static void Main(string[] args)
    {
      Banda queen = new Banda("Queen");
      Album albumDoQueen = new Album("A night at the opera", queen);
      Musica musica1 = new Musica("Love of my life", queen, 347, Genero.OPERA);
      Musica musica2 = new Musica("Bohemian Rhapsody", queen, 671, Genero.OPERA);
      
      musica2.ExibirFichaTecnica();
      albumDoQueen.AdicionarMusica(musica1);
      albumDoQueen.AdicionarMusica(musica2);
      queen.AdicionarAlbum(albumDoQueen);
      albumDoQueen.MostrarMusicas();
      queen.ExibirDiscografia();
    }
  }
}
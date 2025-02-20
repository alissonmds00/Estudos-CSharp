Dictionary<string, List<float>> bandas = new Dictionary<string, List<float>>();
bandas.Add("Maroon 5", new List<float>{10, 8, 6});
bandas.Add("Imagine Dragons", new List<float>{6, 9, 10});
void ExibirLogo()
{
  string ExibirLogo = "Seja bem-vindo ao Screen Sound";
  Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

  ");
  Console.WriteLine(ExibirLogo);

}

void ExibirTituloDaOpcao(string titulo)
{
  int quantidadeDeLetras = titulo.Length;
  string asteriscos =  string.Empty.PadLeft(quantidadeDeLetras, '*');
  Console.WriteLine($"\n{asteriscos}");
  Console.WriteLine(titulo);
  Console.WriteLine($"{asteriscos}\n");
}

void ExibirMenu()
{
  ExibirLogo();
  Console.WriteLine("\nDigite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para mostrar todas as bandas");
  Console.WriteLine("Digite 3 para avaliar uma banda");
  Console.WriteLine("Digite 4 para exibir a média de uma banda");
  Console.WriteLine("Digite -1 para sair");

  Console.Write("\nDigite a opção que você deseja executar: ");
  string opcaoEscolhida = Console.ReadLine()!;
  int opcaoEscolhidaEmNumero = int.Parse(opcaoEscolhida);
  switch(opcaoEscolhidaEmNumero)
  {
    case 1: RegistrarBanda();
      break;
    case 2: MostrarBandas();
      break;
    case 3: AvaliarBanda();
      break;
    case 4: MostrarMediaBanda();
      break;
    case -1: break;
    default: Console.WriteLine("Você digitou um valor inválido");
      ExibirMenu();
      break;
    
  }
}

void RegistrarBanda()
{
  Console.Clear();
  ExibirTituloDaOpcao("Registro de bandas");
  Console.Write("Digite o nome da banda que deseja registrar: ");
  String banda = Console.ReadLine()!;
  bandas.Add(banda, new List<float>());
  Console.WriteLine($"A banda {banda} foi registrada com sucesso!");
  Thread.Sleep(2000);
  Console.Clear();
  ExibirMenu();
}

void MostrarBandas()
{
  ExibirTituloDaOpcao("Listando as bandas");
  // for (int c = 0; c < bandas.Count; c++)
  // {
  //   Console.WriteLine($"Banda: {bandas[c]}");
  // }
  // bandas.ForEach(banda => Console.WriteLine($"Banda: {banda}"));
  foreach (string banda in bandas.Keys)
  {
    Console.WriteLine($"Banda: {banda}");
  }
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void AvaliarBanda()
{
  Console.Clear();
  ExibirTituloDaOpcao("Registrar nota para uma banda");
  Console.Write("Digite o nome da banda que deseja avaliar: ");
  string banda = Console.ReadLine()!;
  if (bandas.ContainsKey(banda))
  {
    Console.Write($"Digite a nota que deseja atribuir à banda {banda}: ");
    float nota = float.Parse(Console.ReadLine()!);
    bandas[banda].Add(nota);
    Console.WriteLine($"A nota {nota} foi atribuída à banda {banda} com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
  }
  else 
  {
    Console.WriteLine($"\nA banda {banda} ainda não foi registrada");
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    ExibirMenu();
  }
}

void MostrarMediaBanda() {
  Console.Clear();
  Console.Write("Digite o nome da banda que você deseja consultar a média: ");
  string banda = Console.ReadLine()!;
  if (bandas.ContainsKey(banda))
  {
    List<float> notas = bandas[banda];
    Console.WriteLine($"A nota média da banda {banda} é {notas.Average()}.");
    Console.WriteLine("Digite qualquer tecla para voltar ao menu principal.");
    Console.ReadKey();
    ExibirMenu();
  }
  else 
  {
    Console.WriteLine($"A banda {banda} não foi registrada ainda");
    Console.WriteLine("Aperte qualquer tecla para retornar ao menu principal");
    Console.ReadKey();
    ExibirMenu();
  }
}


ExibirMenu();

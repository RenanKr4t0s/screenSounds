// Screen Sound - App para aprender C#

string logoScSnd = @"
████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████
█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░░░███░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░██████████░░░░░░████░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░██░░░░░░█░░░░░░██████████░░░░░░█░░░░░░░░░░░░███░░░░░░░░░░░░░░█
█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀▄▀░░███░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░░░░░░░░░██░░▄▀░░████░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░░░░░██░░▄▀░░█░░▄▀▄▀▄▀▄▀░░░░█░░▄▀▄▀▄▀▄▀▄▀░░█
█░░▄▀░░░░░░░░░░█░░▄▀░░░░░░░░░░█░░▄▀░░░░░░░░▄▀░░███░░▄▀░░░░░░░░░░█░░▄▀░░░░░░░░░░█░░▄▀▄▀▄▀▄▀▄▀░░██░░▄▀░░████░░▄▀░░░░░░░░░░█░░▄▀░░░░░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░██░░▄▀░░█░░▄▀░░░░▄▀▄▀░░█░░▄▀░░░░░░░░░░█
█░░▄▀░░█████████░░▄▀░░█████████░░▄▀░░████░░▄▀░░███░░▄▀░░█████████░░▄▀░░█████████░░▄▀░░░░░░▄▀░░██░░▄▀░░████░░▄▀░░█████████░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░█████████
█░░▄▀░░░░░░░░░░█░░▄▀░░█████████░░▄▀░░░░░░░░▄▀░░███░░▄▀░░░░░░░░░░█░░▄▀░░░░░░░░░░█░░▄▀░░██░░▄▀░░██░░▄▀░░████░░▄▀░░░░░░░░░░█░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░░░░░█
█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░█████████░░▄▀▄▀▄▀▄▀▄▀▄▀░░███░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░██░░▄▀░░██░░▄▀░░████░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█
█░░░░░░░░░░▄▀░░█░░▄▀░░█████████░░▄▀░░░░░░▄▀░░░░███░░▄▀░░░░░░░░░░█░░▄▀░░░░░░░░░░█░░▄▀░░██░░▄▀░░██░░▄▀░░████░░░░░░░░░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░█░░░░░░░░░░▄▀░░█
█████████░░▄▀░░█░░▄▀░░█████████░░▄▀░░██░░▄▀░░█████░░▄▀░░█████████░░▄▀░░█████████░░▄▀░░██░░▄▀░░░░░░▄▀░░████████████░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░░░░░▄▀░░█░░▄▀░░██░░▄▀░░█████████░░▄▀░░█
█░░░░░░░░░░▄▀░░█░░▄▀░░░░░░░░░░█░░▄▀░░██░░▄▀░░░░░░█░░▄▀░░░░░░░░░░█░░▄▀░░░░░░░░░░█░░▄▀░░██░░▄▀▄▀▄▀▄▀▄▀░░████░░░░░░░░░░▄▀░░█░░▄▀░░░░░░▄▀░░█░░▄▀░░░░░░▄▀░░█░░▄▀░░██░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░░░▄▀▄▀░░█░░░░░░░░░░▄▀░░█
█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░██░░▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░██░░░░░░░░░░▄▀░░████░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░██░░░░░░░░░░▄▀░░█░░▄▀▄▀▄▀▄▀░░░░█░░▄▀▄▀▄▀▄▀▄▀░░█
█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░██░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░██████████░░░░░░████░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░██████████░░░░░░█░░░░░░░░░░░░███░░░░░░░░░░░░░░█
████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████";
string mensagem = "\nBem vindo ao Screen Sounds";
//string OutraMensagem = 'Não devemos usar aspas simples';
// List<string> listaDeBandas = new List<string> { "U2", "Dream Theater", "Chitãozinho e Xororó" };
Dictionary<string, List<int>> bandasCadastradas = new Dictionary<string, List<int>> { { "Nirvana", new List<int> { 5, 10, 4 } } };
bandasCadastradas.Add("Linkin Park", new List<int> { 9, 7 });
void ExibirLogo()
{
    Console.WriteLine(logoScSnd);
    Console.WriteLine(mensagem);
}
;
void AnimacaoPensando()
{
    Thread.Sleep(300);
    Console.Write("\n.");
    Thread.Sleep(300);
    Console.Write(".");
    Thread.Sleep(300);
    Console.Write(".");
    Thread.Sleep(700);
    Console.Clear();
}
;
void KeyParaMenu()
{
    Console.WriteLine("\nAperte qualquer tecla para voltar ao Menu");
    Console.ReadKey();
    Console.Clear();
    AnimacaoPensando();
    MenuEscolha();
}
;
void ExibeTitulos(string titulo)
{
    int quantidade = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidade + 6, '*');
    Console.WriteLine("\n" + asteriscos);
    Console.WriteLine($"** {titulo} **");
    Console.WriteLine(asteriscos + "\n");
}
;

void MenuEscolha()
{
    ExibirLogo();

    Console.WriteLine("\nEscolha uma alternativa:");
    Console.WriteLine("\nAlternativa 1 - Cadastrar uma nova Banda");
    Console.WriteLine("Alternativa 2 - Ver Bandas Cadastradas");
    Console.WriteLine("Alternativa 3 - Avaliar uma Banda");
    Console.WriteLine("Alternativa 4 - Exibir média de uma Banda");
    Console.WriteLine("Alternativa -1 - Sair do Programa.");

    Console.Write("\nQual a sua escolha? ");
    int opcaoUser = int.Parse(Console.ReadLine()!);

    switch (opcaoUser)
    {
        case 1:
            Console.WriteLine("Vamos adicionar uma banda!");
            AnimacaoPensando();
            AdicionarUmaBanda();
            break;
        case 2:
            Console.WriteLine("Vamos ver as bandas cadastradas");
            AnimacaoPensando();
            BandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Avaliação de Bandas");
            AnimacaoPensando();
            AvaliarBanda();
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção: " + opcaoUser);
            MediaBanda();
            break;
        case -1:
            Console.WriteLine("Obrigado por Utilizar nossos serviços");
            AnimacaoPensando();
            break;
        default:
            Console.WriteLine("Opção não foi reconhecida");
            AnimacaoPensando();
            MenuEscolha();
            break;
    }
}

void AdicionarUmaBanda()
{
    ExibeTitulos("Adicionando Bandas");
    Console.WriteLine("\nQual o nome da banda a adicionar?");
    Console.Write("Banda: ");
    string nomeBanda = Console.ReadLine()!;
    bandasCadastradas.Add(nomeBanda, new List<int>());
    AnimacaoPensando();
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    KeyParaMenu();
}
void BandasRegistradas()
{
    ExibeTitulos("As Bandas Registradas são:");

    // for (int i = 0; i < listaDeBandas.Count; i++)
    // {
    // Console.WriteLine($"Banda: {listaDeBandas[i]}");
    // }

    foreach (string banda in bandasCadastradas.Keys)
    {
        Console.WriteLine("Banda: " + banda);
    }
    KeyParaMenu();
}
void AvaliarBanda()
{
    ExibeTitulos("Avaliação de bandas");
    Console.WriteLine("\nQual banda gostaria de avaliar?");
    string bandaUsuario = Console.ReadLine()!;

    if (bandasCadastradas.ContainsKey(bandaUsuario))
    {
        Console.Write($"Qual nota a {bandaUsuario} merece? ");
        int notaUsuario = int.Parse(Console.ReadLine()!);
        bandasCadastradas[bandaUsuario].Add(notaUsuario);
        Console.WriteLine($"\nA nota {notaUsuario} foi atribuida a banda {bandaUsuario} com sucesso!");
        KeyParaMenu();
    }
    else
    {
        Console.WriteLine($"Banda {bandaUsuario} não encontrada");
        KeyParaMenu();
    }
}
;

void MediaBanda()
{
    ExibeTitulos("Média de Notas da Banda");
    Console.Write("\nDe que banda você quer saber a média? ");
    string bandaUsuario = Console.ReadLine()!;
    if (bandasCadastradas.ContainsKey(bandaUsuario))
    {
        double notaMedia = bandasCadastradas[bandaUsuario].Average();
        Console.WriteLine($"A média de notas da {bandaUsuario} é {notaMedia}");
        KeyParaMenu();
    }
    else
    {
        Console.WriteLine($"Banda {bandaUsuario} não está no nosso sistema.");
        Console.WriteLine($"Gostaria de cadastrar a banda {bandaUsuario} no nosso sistema?(y/n): ");
        string respostaCadastrar = Console.ReadLine()!;
        if (respostaCadastrar == "y")
        {
            bandasCadastradas.Add(bandaUsuario, new List<int>());
            AnimacaoPensando();
            Console.WriteLine($"\nA banda {bandaUsuario} foi registrada com sucesso");
            Thread.Sleep(2000);
            KeyParaMenu();
        }
    }
}
MenuEscolha();
// Replicar as acoes no pc do trampo.
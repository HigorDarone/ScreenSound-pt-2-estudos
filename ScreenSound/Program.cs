using ScreenSound.Menus;
using ScreenSound.Modelos;


internal class Program
{
    private static void Main(string[] args)
    {
        Banda banda1 = new Banda("Lagum");
        banda1.AdicionarNota(new Avaliacao(10));
        banda1.AdicionarNota(new Avaliacao(8));
        banda1.AdicionarNota(new Avaliacao(6));
        Banda banda2 = new("Veigh");

        Dictionary<string, Banda> bandasRegistradas = new( );
        bandasRegistradas.Add(banda1.Nome, banda1);
        bandasRegistradas.Add(banda2.Nome, banda2);

        Dictionary<int, Menu> opcoes = new( );
        opcoes.Add(1, new MenuRegistrarBanda());
        opcoes.Add(2, new MenuRegistrarAlbum());
        opcoes.Add(3, new MenuMostrarBandasRegistradas());
        opcoes.Add(4, new MenuAvaliarBanda());
        opcoes.Add(5, new MenuExibirDetalhes());
        opcoes.Add(-1, new MenuExibirDetalhes());
        

        void ExibirLogo()
        {
            Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
            Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
        }

        void ExibirOpcoesDoMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if (opcoes.ContainsKey(opcaoEscolhidaNumerica)) 
            { 
            Menu MenuASerExibido = opcoes[opcaoEscolhidaNumerica];
            }else
            {
                Console.WriteLine("Opcao invalida");
            }



            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    MenuRegistrarBanda menu1 = new MenuRegistrarBanda();
                    menu1.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 2:
                    MenuRegistrarAlbum menu2 = new MenuRegistrarAlbum();
                    menu2.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 3:
                    MenuMostrarBandasRegistradas menu3 = new MenuMostrarBandasRegistradas();
                    menu3.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 4:
                    MenuAvaliarBanda menu4 = new MenuAvaliarBanda();
                    menu4.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 5:
                    MenuExibirDetalhes menu5 = new MenuExibirDetalhes();
                    menu5.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case -1:
                   MenuSair menu6 = new MenuSair();
                    menu6.Executar(bandasRegistradas);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

 
        

        ExibirOpcoesDoMenu();
    }
}
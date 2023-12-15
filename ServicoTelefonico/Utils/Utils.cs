using ServicoTelefonico.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoTelefonico.Utils
{
    public static class Utils
    {
        public static void MenuNokia()
        {
            bool continuarMenuNokia = true;
            Nokia nokia = new(string.Empty, string.Empty, string.Empty, 0);
            while (continuarMenuNokia)
            {
                Console.WriteLine("Menu Nokia:");
                Console.WriteLine("1 - Adicionar Item à Lista do Nokia");
                Console.WriteLine("2 - Instalar Aplicativo no Nokia");
                Console.WriteLine("3 - Listar modelos cadastrados");
                Console.WriteLine("4 - Listar aplicativos instalados");
                Console.WriteLine("5 - Voltar ");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Nokia.AdicionarTelefone();
                        break;
                    case "2":
                        string nomeApp = NomeApp();
                        nokia.InstalarAplicativo(nomeApp);
                        break;
                    case "3":
                        Nokia.MostrarTelefones();
                        break;
                    case "4":
                        Nokia.MostrarAplicativos();
                        break;
                    case "5":
                        continuarMenuNokia = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }

        }

        public static void MenuIphone()
        {
            bool continuarMenuNokia = true;
            Iphone iphone = new(string.Empty, string.Empty, string.Empty, 0);
            while (continuarMenuNokia)
            {
                Console.WriteLine("Menu Nokia:");
                Console.WriteLine("1 - Adicionar Item à Lista do Nokia");
                Console.WriteLine("2 - Instalar Aplicativo no Nokia");
                Console.WriteLine("3 - Listar modelos cadastrados");
                Console.WriteLine("4 - Listar aplicativos instalados");
                Console.WriteLine("5 - Voltar ");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Iphone.AdicionarTelefone();
                        break;
                    case "2":
                        string nomeApp = NomeApp();
                        iphone.InstalarAplicativo(nomeApp);
                        break;
                    case "3":
                        Iphone.MostrarTelefones();
                        break;
                    case "4":
                        Iphone.MostrarAplicativos();
                        break;
                    case "5":
                        continuarMenuNokia = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        public static string NomeApp()
        {
            string nomeApp = string.Empty;
            Console.WriteLine("Deseja instalar qual aplicativo?");
            nomeApp = Console.ReadLine();
            if(!string.IsNullOrEmpty(nomeApp))
            {
                return nomeApp;
            }
            else
            {
                Console.WriteLine("Digite um nome válido");
                return nomeApp;
            }
        }
    }
}

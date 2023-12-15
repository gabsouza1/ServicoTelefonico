using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoTelefonico.Entities
{
    public class Nokia : Smartphone
    {
        public static List<Nokia> Nokias = [];
        public static List<string> Aplicativos = [];
        public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
            Nokias.Add(this);
        }

        public static void AdicionarTelefone()
        {
            Console.WriteLine("Digite o numero do telefone: ");
            string numero = Console.ReadLine();
            Console.WriteLine("Digite o modelo do telefone: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Digite o numero IMEI do telefone: ");
            string imei = Console.ReadLine();
            Console.WriteLine("Digite quanto de mémoria possui o telefone: ");
            int memoria = Convert.ToInt32(Console.ReadLine());

            if (!string.IsNullOrEmpty(numero) && !string.IsNullOrEmpty(modelo) && !string.IsNullOrEmpty(imei) && memoria > 0)
            {
                Nokia nokia = new(numero, modelo, imei, memoria);
                List<Nokia> nokias = [nokia];
                Console.WriteLine($"{nokia.Modelo}, foi adicionado com sucesso");
            }
            else
            {
                Console.WriteLine("Informações incompletas!");
            }

        }

        public static void MostrarTelefones()
        {
            Console.WriteLine("Telefones Disponíveis:");
            int i = 1;
            foreach (var nokia in Nokias)
            {
                if (!string.IsNullOrEmpty(nokia.Numero))
                {
                    Console.WriteLine($"{i} - {nokia.Modelo}");
                    i++;
                }
                
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public static void MostrarAplicativos()
        {
            Console.WriteLine("Aplicativos Instalados:");
            int i = 1;
            foreach (var aplicativo in Aplicativos)
            {
                Console.WriteLine($"{i} - {aplicativo}");
                i++;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            if (!string.IsNullOrEmpty(nomeApp))
            {
                Aplicativos.Add(nomeApp);
                Console.WriteLine($"Instalando: {nomeApp} em seu aparelho Nokia");
            }
            else
            {
                Console.WriteLine("Aplicativo Inválido");
            }
        }
    }

}

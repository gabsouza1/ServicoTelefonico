using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoTelefonico.Entities
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; private set; }
        public string IMEI { get; private set; }
        public int Memoria { get; private set; }

        protected Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        public static void Ligar()
        {
            Random random = new Random();
            bool ligacao = random.Next(0, 2) == 0;
            Console.WriteLine("Disque o número");
            string numero = Console.ReadLine();
            if(!string.IsNullOrEmpty(numero)) 
            {
                if (ligacao)
                {
                    Console.WriteLine("Ligando.");
                    Console.WriteLine("Ligando..");
                    Console.WriteLine("Ligando...");
                    Console.WriteLine("Alô? Quem fala?");
                }
                else
                {
                    Console.WriteLine("Não foi possível completar sua ligação. Tente novamente!");
                }
                
            }
            else
            {
                Console.WriteLine("Digite um número válido");
            }
            
        }

        public static void ReceberLigacao()
        {
            Random random = new Random();
            int telefone = random.Next(10000000, 99999999);
            Console.WriteLine($"Recebendo ligação de {telefone}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}

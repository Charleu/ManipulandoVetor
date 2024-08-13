using System;

namespace manipulandovetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[11];
            int indice = 0;

            // Adicionando alguns nomes em índices específicos
            AdicionarNome(nomes, 0, "Maria");
            AdicionarNome(nomes, 1, "João");
            AdicionarNome(nomes, 2, "Ana");
            AdicionarNome(nomes, 3, "Pedro");
            AdicionarNome(nomes, 4, "Lucas");
            AdicionarNome(nomes, 5, "Luiza");
            AdicionarNome(nomes, 6, "Paula");
            AdicionarNome(nomes, 7, "Carlos");
            AdicionarNome(nomes, 8, "Roberta");
            AdicionarNome(nomes, 9, "Fernanda");
            AdicionarNome(nomes, 10, "Ricardo");
            indice = 11;

            // Verificando se o vetor está cheio
            if (indice >= nomes.Length)
            {
                Console.WriteLine("Vetor cheio");
            }

            // Ordenando e imprimindo todos os nomes
            OrdenarNomes(nomes);
            ImprimirNomes(nomes);

            // Removendo um registro
            RemoverNome(nomes, "Ana");
            ImprimirNomes(nomes);
        }

        public static void AdicionarNome(string[] lista, int indice, string nome)
        {
            if (indice >= 0 && indice < lista.Length)
            {
                lista[indice] = nome;
                Console.WriteLine($"Nome '{nome}' adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Índice inválido!");
            }
        }

        public static void OrdenarNomes(string[] nomes)
        {
            Array.Sort(nomes);
        }

        public static void ImprimirNomes(string[] nomes)
        {
            bool estaVazio = true;

            for (int i = 0; i < nomes.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(nomes[i]))
                {
                    estaVazio = false;
                    break;
                }
            }

            if (estaVazio)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                Console.WriteLine("Lista de nomes:");

                for (int i = 0; i < nomes.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(nomes[i]))
                    {
                        Console.WriteLine(nomes[i]);
                    }
                }
            }
        }

        public static void RemoverNome(string[] nomes, string nome)
        {
            bool encontrado = false;

            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == nome)
                {
                    nomes[i] = string.Empty;
                    encontrado = true;
                    Console.WriteLine($"Nome '{nome}' removido com sucesso!");
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"Nome '{nome}' não encontrado na lista!");
            }
        }
    }
}

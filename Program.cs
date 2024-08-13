using System;
using System.Linq;

namespace manipulandovetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string separador = new string('-', 45);
            string[] nomes = new string[10];
            int indice = 0;
            Console.WriteLine(separador);
            Console.WriteLine("Adicionando nome na lista");
            Console.WriteLine(separador);
            AddNome(nomes, "Charleu");
            AddNome(nomes, "Charles");
            AddNome(nomes, "Shyrley");
            indice++;

            if (indice > nomes.Length)
            {
                Console.WriteLine("Vetor cheio");
            }

            ImprimeNomes(nomes);
            Console.WriteLine(separador);
            Console.WriteLine("Adicionando nome em índice específico...");
            Console.WriteLine(separador);
            AddNomeEmIndice(nomes, 3, "Maria");
            AddNomeEmIndice(nomes, 7, "José");
            AddNomeEmIndice(nomes, 9, "Sheylla");

            ImprimeNomes(nomes);
            Console.WriteLine(separador);
            Console.WriteLine("Ordenando nomes em ordem alfabética...");
            Console.WriteLine(separador);

            OrdenarNomes(nomes);

            ImprimeNomes(nomes);
            Console.WriteLine(separador);
            Console.WriteLine("Removendo nome da lista...");
            Console.WriteLine(separador);
            RemoverNome(nomes, "Shyrlley");
            ImprimeNomes(nomes);
        }

        public static void AddNome(string[] lista, string nome)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (string.IsNullOrEmpty(lista[i]))
                {
                    lista[i] = nome;
                    Console.WriteLine($"Nome '{nome}' adicionado com sucesso!");
                    return;
                }
            }
            Console.WriteLine("Lista cheia. Não é possível adicionar mais nomes.");
        }

        public static void AddNomeEmIndice(string[] lista, int indice, string nome)
        {
            if (indice < 0 || indice >= lista.Length)
            {
                Console.WriteLine($"Índice inválido. Escolha um índice entre 0 e {lista.Length - 1}");
                return;
            }

            if (!string.IsNullOrEmpty(lista[indice]))
            {
                Console.WriteLine("Índice já ocupado.");
                return;
            }

            lista[indice] = nome;
            Console.WriteLine($"Nome '{nome}' adicionado com sucesso no índice {indice}!");
        }

        public static void OrdenarNomes(string[] nomes)
        {
            Array.Sort(nomes, (a, b) => string.Compare(a, b, StringComparison.Ordinal));
            Console.WriteLine("Nomes ordenados com sucesso!");
        }

        public static void ImprimeNomes(string[] nomes)
        {
            bool estaVazia = true;

            for (int i = 0; i < nomes.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(nomes[i]))
                {
                    estaVazia = false;
                    break;
                }
            }

            if (estaVazia)
            {
                Console.WriteLine("Lista vazia.");
            }
            else
            {
                Console.WriteLine("\nNomes na lista:");
                for (int i = 0; i < nomes.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(nomes[i]))
                    {
                        Console.WriteLine(nomes[i]);
                    }
                }
            }
        }

        public static void RemoverNome(string[] lista, string nome)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == nome)
                {
                    lista[i] = null;
                    Console.WriteLine($"Nome '{nome}' removido com sucesso!");
                    return;
                }
            }
            Console.WriteLine($"Nome '{nome}' não encontrado na lista.");
        }
    }
}

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
            AddNome(nomes, "Maria");
            AddNome(nomes, "José");
            AddNome(nomes, "Sheylla");
            AddNome(nomes, "Ana");
            AddNome(nomes, "João");
            AddNome(nomes, "Lucas");
            indice = 9;

            if (indice >= nomes.Length)
            {
                Console.WriteLine("Vetor cheio");
            }

            ImprimeNomes(nomes);
            Console.WriteLine(separador);
            Console.WriteLine("Adicionando nome em índice específico...");
            Console.WriteLine(separador);

            AddNomeEmIndice(nomes, 3, "MariaNova");
            AddNomeEmIndice(nomes, 7, "JoséNovo");
            AddNomeEmIndice(nomes, 9, "SheyllaNova");

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

            bool vetorCheio = true;
            for (int i = 0; i < lista.Length; i++)
            {
                if (string.IsNullOrEmpty(lista[i]))
                {
                    vetorCheio = false;
                    break;
                }
            }

            if (vetorCheio)
            {
                Console.WriteLine("Lista cheia.");
                return;
            }

            for (int i = lista.Length - 1; i > indice; i--)
            {
                lista[i] = lista[i - 1];
            }

            lista[indice] = nome;
            Console.WriteLine($"Nome '{nome}' adicionado com sucesso no índice {indice}!");
        }

        public static void OrdenarNomes(string[] nomes)
        {
            int tamanho = nomes.Length;
            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (string.Compare(nomes[j], nomes[j + 1], StringComparison.Ordinal) > 0)
                    {
                        string aux = nomes[j];
                        nomes[j] = nomes[j + 1];
                        nomes[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("Ordenação concluída!");
        }

        public static void ImprimeNomes(string[] nomes)
        {
            bool vetorNull = false;
            for (int i = 0; i < nomes.Length; i++)
            {
                if (string.IsNullOrEmpty(nomes[i]))
                {
                    vetorNull = true;
                    break;
                }
            }

            if (nomes.All(n => string.IsNullOrWhiteSpace(n)))
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                for (int i = 0; i < nomes.Length; i++)
                {
                    Console.WriteLine(nomes[i]);
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
            Console.WriteLine($"Nome '{nome}' não encontrado.");
        }
    }
}


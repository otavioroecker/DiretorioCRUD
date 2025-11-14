using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiretorioCRUD
{
    public class Pasta
    {
        // Caminhos BASE eles ficam armazenado para direcionar onde será criado a pasta etc...
        private static List<string> caminhosBase = new List<string>()
        {
            @"\\JUPIAFS\Departamento de Informática\TesteOtavio",
            @"C:\Users\orr\Desktop"
        };
        public static string caminhoCompleto { get; set; }

        //CODIGOOOOOOO para juntar caminho com o nome da pasta       caminhoCompleto = Path.Combine(CaminhoBase, nomePasta);


        public static void CriarPasta()
        {
            Console.Clear();

            Console.WriteLine("Escolha em qual local você irá criar a pasta");
            Console.WriteLine();

            for (int i = 0; i <  caminhosBase.Count; i++)
            {
                Console.WriteLine((i + 1) +" - "+caminhosBase[i]);
            }

            string input = Console.ReadLine();
            Console.Clear();

            if (!int.TryParse(input, out int escolha) || escolha < 1 || escolha > caminhosBase.Count)
            {
                Console.WriteLine("Digite um valor valido (" + 1 + "-" + caminhosBase.Count + ") por favor");
                Console.Write("Aperte qualquer tecla para voltar...");
                Console.ReadKey();
                Console.Clear();
                return;
            }


            string caminhoEscolhido = caminhosBase[escolha - 1];


            Console.WriteLine("Digite o nome da pasta ou (v/voltar) para voltar: ");
            string resposta = Console.ReadLine();
            string nomePasta;

            if (string.Equals(resposta, "voltar", StringComparison.OrdinalIgnoreCase)
                || string.Equals(resposta, "v", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
            else
            {
                nomePasta = resposta;
            }

            caminhoCompleto = Path.Combine(caminhoEscolhido, nomePasta);

            if (Directory.Exists(caminhoCompleto)) // verifica se ja existe diretorio com aquele nome
            {
                Console.Clear();
                Console.WriteLine("Não foi possivel criar a pasta, pois este nome ja existe!");
                Console.ReadLine();
                Console.Clear();
            }
            else // caso não exista a pasta, o codigo cria e imprimi na tela uma mensagem confirmando a operação
            {
                Console.Clear();
                Directory.CreateDirectory(caminhoCompleto);
                if (Directory.Exists(caminhoCompleto))
                {
                    Console.WriteLine("Pasta criada com sucesso!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Não foi possivel criar esta pasta!");
                }
            }
        }



    }
}

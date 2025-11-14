using System;
using System.IO;

namespace DiretorioCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool rodando = true;
            Pasta pasta = new Pasta();

            while (rodando == true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("(1) - Criar Pastas");
                Console.WriteLine("(2) - Editar Nome da Pastas");
                Console.WriteLine("(3) - Listar Pastas");
                Console.WriteLine("(4) - Excluir Pastas");
                Console.WriteLine("(0) - Sair");
                Console.WriteLine();

                string input = (Console.ReadLine()); // variavel - escolha da ação

                if(!int.TryParse(input, out int escolha) || escolha < 0 || escolha > 4)
                {
                    Console.WriteLine("Digite um valor valido 0-4 por favor");
                    Console.Write("Aperte qualquer tecla para voltar...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                switch (escolha)
                {
                    case 0:
                        rodando = false;
                        break;

                        case 1:
                        Pasta.CriarPasta();
                        break;
                }
            }



            
        }
    }
}
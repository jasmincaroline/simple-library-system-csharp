class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Livro aCabecaDoSanto = new Livro(1, "A Cabeça do Santo");
            Livro it = new Livro(2, "IT: A Coisa");

            biblioteca.CadastrarLivro(aCabecaDoSanto);
            biblioteca.CadastrarLivro(it);

            Console.WriteLine("Bem-vindo à Biblioteca Pônei!");

            bool executando = true;

            while (executando)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Listar livros");
                Console.WriteLine("2 - Emprestar livro");
                Console.WriteLine("3 - Sair");

                string? input = Console.ReadLine();

                if (!int.TryParse(input, out int opcao))
                {
                Console.WriteLine("Invalid option.");
                return;
                }

                if (opcao == 1)
                {
                    biblioteca.ListarLivros();
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Digite o nome de quem pegará o livro:");
                    string? nome = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nome))
                    {
                     Console.WriteLine("Invalid name.");
                     return;
                    }

                    Pessoa pessoa = new Pessoa(nome);
                    biblioteca.CadastrarPessoa(pessoa);

                    Console.WriteLine("\nLivros disponíveis:");
                    biblioteca.ListarLivros();

                    Console.WriteLine("Digite o ID do livro que deseja pegar:");
                    string? idInput = Console.ReadLine();

                    if (!int.TryParse(idInput, out int idLivro))
                    {
                    Console.WriteLine("Invalid book ID.");
                    continue;
                    }

                    Livro? livroEscolhido = biblioteca.BuscarLivroPorId(idLivro);

                    if (livroEscolhido == null)
                    {
                        Console.WriteLine("Livro não encontrado.");
                    }
                    else
                    {
                        biblioteca.EmprestarLivro(livroEscolhido, pessoa);
                        Console.WriteLine("Empréstimo concluído!");
                    }
                }
                else if (opcao == 3)
                {
                    executando = false;
                    Console.WriteLine("Saindo da biblioteca...");
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }
        }
    }


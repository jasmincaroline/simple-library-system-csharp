public class Biblioteca
    {
        public List<Livro> Livros { get; set; }
        public List<Pessoa> Pessoas { get; set; }

        public Biblioteca()
        {
            Livros = new List<Livro>();
            Pessoas = new List<Pessoa>();
        }

        public void CadastrarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public void CadastrarPessoa(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
        }

        public void ListarLivros()
        {
            if (Livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro disponível.");
                return;
            }

            foreach (var livro in Livros)
            {
                Console.WriteLine($"{livro.Id} - {livro.Titulo} ({livro.Status})");
            }
        }

        public Livro BuscarLivroPorId(int id)
        {
            return Livros.Find(l => l.Id == id);
        }

        public void EmprestarLivro(Livro livro, Pessoa pessoa)
        {
          if (livro.Status == "Disponível")
        {
        livro.Emprestar(pessoa.Nome);
        pessoa.PegarLivro(livro);
        }
}

        public void ReceberLivro(Livro livro, Pessoa pessoa)
        {
            livro.Devolver();
            pessoa.DevolverLivro(livro);
            Livros.Add(livro);
        }
    }


public class Pessoa
    {
        public string Nome { get; set; }
        public List<Livro> Livros { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
            Livros = new List<Livro>();
        }

        public void PegarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public void DevolverLivro(Livro livro)
        {
            Livros.Remove(livro);
        }
    }

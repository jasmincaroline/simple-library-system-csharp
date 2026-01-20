public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Status { get; set; }
        public string Locatario { get; set; }

        public Livro(int id, string titulo)
        {
            Id = id;
            Titulo = titulo;
            Status = "Disponível";
            Locatario = "";
        }

        public void Emprestar(string nomeLocatario)
        {
            Status = "Emprestado";
            Locatario = nomeLocatario;
        }

        public void Devolver()
        {
            Status = "Disponível";
            Locatario = "";
        }
    }

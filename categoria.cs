namespace sistema-basico-de-atendimento.Models
{
    public class Categoria
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public Categoria(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}


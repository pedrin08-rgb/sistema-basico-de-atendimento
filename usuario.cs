namespace sistema-basico-de-atendimento.Models
{
    public abstract class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }

        protected Usuario(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }
    }
}


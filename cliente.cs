namespace sistema-basico-de-atendimento.Models
{
    public class Cliente : Usuario
    {
        public string Telefone { get; private set; }

        public Cliente(int id, string nome, string email, string telefone)
            : base(id, nome, email)
        {
            Telefone = telefone;
        }
    }
}


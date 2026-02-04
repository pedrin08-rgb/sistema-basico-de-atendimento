using ProjetoChamados.Models;
using ProjetoChamados.Services;

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente(1, "João", "joao@email.com", "99999-9999");
        Tecnico tecnico = new Tecnico(1, "Maria", "maria@email.com", "Redes");
        Categoria categoria = new Categoria(1, "Internet");

        Chamado chamado = new Chamado(1, "Sem internet", "Internet caiu", cliente, categoria);

        ChamadoService service = new ChamadoService();
        service.AbrirChamado(chamado);

        chamado.AtribuirTecnico(tecnico);
        chamado.Encerrar();
    }
}


using SistemaBasicoDeAtendimento.Models; 
using SistemaBasicoDeAtendimento.Services;

namespace SistemaBasicoDeAtendimento
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Sistema de chamados iniciado com sucesso!");

            Cliente cliente = new Cliente(1, "João", "joao@email.com", "99999-9999");
            Tecnico tecnico = new Tecnico(1, "Maria", "maria@email.com", "Redes");
            Categoria categoria = new Categoria(1, "Internet");

            Chamado chamado = new Chamado(1, "Sem internet", "Internet caiu", cliente, categoria);

            ChamadoService service = new ChamadoService();
            console.Writeline($"cliente: {cliente.Nome}";
            console.Writeline($"assunto: {chamado.Titulo}");        
            service.AbrirChamado(chamado);
            console.writeline("chamado aberto com sucesso!");
                              
            chamado.AtribuirTecnico(tecnico);
            console.writeline($"tecnico: {tecnico.Nome} atribuido ao chamado");

                              
            chamado.Encerrar();

            Console.WriteLine("Chamado encerrado");
            Console.WriteLine("\n--- HISTÓRICO DO CHAMADO ---");
            Console.WriteLine($"{DateTime.Now}: Chamado criado por {cliente.Nome}");
            Console.WriteLine($"{DateTime.Now}: Técnico {tecnico.Nome} assumiu o caso");
            Console.WriteLine($"{DateTime.Now}: Resolução finalizada.");
        }
    }
}





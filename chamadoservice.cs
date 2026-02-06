using System.Collections.Generic;
using sistema-basico-de-atendimento.Models;

namespace sistema-basico-de-atendimento.Services
{
    public class ChamadoService
    {
        private List<Chamado> chamados = new List<Chamado>();

        public void AbrirChamado(Chamado chamado)
        {
            chamados.Add(chamado);
        }

        public List<Chamado> ListarPorStatus(string status)
        {
            return chamados.FindAll(c => c.Status == status);
        }

        public List<Chamado> ListarPorTecnico(Tecnico tecnico)
        {
            return chamados.FindAll(c => c.Tecnico == tecnico);
        }
    }
}




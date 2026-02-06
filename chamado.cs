using System.Collections.Generic;
using sistema-basico-de-atendimento.Interfaces;

namespace sistema-basico-de-atendiment.Models
{
    public class Chamado : IAtribuivel, IEncerravel
    {
        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public string Status { get; private set; }

        public Cliente Cliente { get; private set; }
        public Tecnico Tecnico { get; private set; }
        public Categoria Categoria { get; private set; }

        public List<HistoricoChamado> Historico { get; private set; }

        public Chamado(int id, string titulo, string descricao, Cliente cliente, Categoria categoria)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Cliente = cliente;
            Categoria = categoria;
            Status = "Aberto";
            Historico = new List<HistoricoChamado>();

            Historico.Add(new HistoricoChamado("Chamado aberto"));
        }

        public void AtribuirTecnico(Tecnico tecnico)
        {
            Tecnico = tecnico;
            Status = "Em andamento";
            Historico.Add(new HistoricoChamado("Técnico atribuído"));
        }

        public void Encerrar()
        {
            Status = "Encerrado";
            Historico.Add(new HistoricoChamado("Chamado encerrado"));
        }
    }
}


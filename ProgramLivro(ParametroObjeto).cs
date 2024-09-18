using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso_C_
{
    public class Dados
    {
        public List<Cliente> Clientes { get; set; }
        public List<Servico> Servicos { get; set; }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
        }
    }

    public class Servico
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        // Construtor que recebe descrição e valor
        public Servico(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
    }

    public class Agendamento
    {
        public Cliente Cliente { get; set; }
        public Servico Servico { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public string Local { get; set; }

        public Agendamento(Cliente cliente, Servico servico, DateTime data, TimeSpan hora, string local)
        {
            Cliente = cliente;
            Servico = servico;
            Data = data;
            Hora = hora;
            Local = local;
        }
    }

    public class DadosAgendamento
    {
        public List<Agendamento> Agendamentos { get; set; }
    }
}
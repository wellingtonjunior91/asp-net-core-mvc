using System;
using System.Collections.Generic;
using System.Linq;

namespace WebMvc.Models
{
    public class Vendedores
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }
        public double Salario { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<RegistroDeVendas> Vendas { get; set; } = new List<RegistroDeVendas>();

        //Construtores (OBS: Não utilizar atributos com coleções)
        public Vendedores()
        {
        }

        public Vendedores(int id, string nome, string email, DateTime dataAniversario, double salario, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataAniversario = dataAniversario;
            Salario = salario;
            Departamento = departamento;
        }
        
        //Métodos customizados
        public void AdicionarVendas(RegistroDeVendas rv)
        {
            Vendas.Add(rv);
        }
        public void RemoverVendas(RegistroDeVendas rv)
        {
            Vendas.Remove(rv);
        }
        public double TotalVendas(DateTime inicial, DateTime final)
        {
            //linq com expressão lambda
            return Vendas.Where(rv => rv.Data >= inicial && rv.Data <= final).Sum(rv => rv.Valor);
        }
    }
}

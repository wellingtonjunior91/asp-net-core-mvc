using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedores> Vendedores { get; set; } = new List<Vendedores>();

        //Construtores (OBS: Não utilizar atributos com coleções)
        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        //Métodos customizados
        public void AdicionarVendedor(Vendedores vendedor)
        {
            Vendedores.Add(vendedor);
        }
        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendedores.Sum(vendedor => vendedor.TotalVendas(inicial, final));
        }
    }
}

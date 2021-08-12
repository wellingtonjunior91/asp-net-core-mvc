using System;
using WebMvc.Models.Enums;

namespace WebMvc.Models
{
    public class RegistroDeVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedores Vendedores { get; set; }

        //Construtores (OBS: Não utilizar atributos com coleções)
        public RegistroDeVendas()
        {
        }

        public RegistroDeVendas(int id, DateTime data, double valor, StatusVenda status, Vendedores vendedores)
        {
            Id = id;
            Data = data;
            Valor = valor;
            Status = status;
            Vendedores = vendedores;
        }
    }
}

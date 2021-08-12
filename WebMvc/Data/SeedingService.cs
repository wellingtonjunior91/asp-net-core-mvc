using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;
using WebMvc.Models.Enums;

namespace WebMvc.Data
{
    public class SeedingService
    {
        private WebMvcContext _context;

        public SeedingService(WebMvcContext context)
        {
            _context = context;
        }

        //Método para popular o Banco de dados
        public void Seed()
        {
            if (_context.Departamento.Any() ||
                _context.Vendedores.Any() ||
                _context.RegistroDeVendas.Any())
            {
                return; //DB já populado.
            }

            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletronicos");
            Departamento d3 = new Departamento(3, "Fashion");
            Departamento d4 = new Departamento(4, "Livros");

            Vendedores v1 = new Vendedores(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Vendedores v2 = new Vendedores(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31),3500.0, d2);
            Vendedores v3 = new Vendedores(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Vendedores v4 = new Vendedores(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Vendedores v5 = new Vendedores(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Vendedores v6 = new Vendedores(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            RegistroDeVendas rv1 = new RegistroDeVendas(1, new DateTime(2021, 08, 01), 11000.0, StatusVenda.Faturado, v1);
            RegistroDeVendas rv2 = new RegistroDeVendas(2, new DateTime(2018, 09, 4), 7000.0, StatusVenda.Faturado, v5);
            RegistroDeVendas rv3 = new RegistroDeVendas(3, new DateTime(2018, 09, 13), 4000.0, StatusVenda.Cancelado, v4);
            RegistroDeVendas rv4 = new RegistroDeVendas(4, new DateTime(2018, 09, 1), 8000.0, StatusVenda.Faturado, v1);
            RegistroDeVendas rv5 = new RegistroDeVendas(5, new DateTime(2018, 09, 21), 3000.0, StatusVenda.Faturado, v3);
            RegistroDeVendas rv6 = new RegistroDeVendas(6, new DateTime(2018, 09, 15), 2000.0, StatusVenda.Faturado, v1);
            RegistroDeVendas rv7 = new RegistroDeVendas(7, new DateTime(2018, 09, 28), 13000.0, StatusVenda.Faturado, v2);
            RegistroDeVendas rv8 = new RegistroDeVendas(8, new DateTime(2018, 09, 11), 4000.0, StatusVenda.Faturado, v4);
            RegistroDeVendas rv9 = new RegistroDeVendas(9, new DateTime(2018, 09, 14), 11000.0, StatusVenda.Pendente, v6);
            RegistroDeVendas rv10 = new RegistroDeVendas(10, new DateTime(2018, 09, 7), 9000.0, StatusVenda.Faturado, v6);
            RegistroDeVendas rv11 = new RegistroDeVendas(11, new DateTime(2018, 09, 13), 6000.0, StatusVenda.Faturado, v2);
            RegistroDeVendas rv12 = new RegistroDeVendas(12, new DateTime(2018, 09, 25), 7000.0, StatusVenda.Pendente, v3);
            RegistroDeVendas rv13 = new RegistroDeVendas(13, new DateTime(2018, 09, 29), 10000.0, StatusVenda.Faturado, v4);
            RegistroDeVendas rv14 = new RegistroDeVendas(14, new DateTime(2018, 09, 4), 3000.0, StatusVenda.Faturado, v5);
            RegistroDeVendas rv15 = new RegistroDeVendas(15, new DateTime(2018, 09, 12), 4000.0, StatusVenda.Faturado, v1);
            RegistroDeVendas rv16 = new RegistroDeVendas(16, new DateTime(2018, 10, 5), 2000.0, StatusVenda.Faturado, v4);
            RegistroDeVendas rv17 = new RegistroDeVendas(17, new DateTime(2018, 10, 1), 12000.0, StatusVenda.Faturado, v1);
            RegistroDeVendas rv18 = new RegistroDeVendas(18, new DateTime(2018, 10, 24), 6000.0, StatusVenda.Faturado, v3);
            RegistroDeVendas rv19 = new RegistroDeVendas(19, new DateTime(2018, 10, 22), 8000.0, StatusVenda.Faturado, v5);
            RegistroDeVendas rv20 = new RegistroDeVendas(20, new DateTime(2018, 10, 15), 8000.0, StatusVenda.Faturado, v6);
            RegistroDeVendas rv21 = new RegistroDeVendas(21, new DateTime(2018, 10, 17), 9000.0, StatusVenda.Faturado, v2);
            RegistroDeVendas rv22 = new RegistroDeVendas(22, new DateTime(2018, 10, 24), 4000.0, StatusVenda.Faturado, v4);
            RegistroDeVendas rv23 = new RegistroDeVendas(23, new DateTime(2018, 10, 19), 11000.0, StatusVenda.Cancelado, v2);
            RegistroDeVendas rv24 = new RegistroDeVendas(24, new DateTime(2018, 10, 12), 8000.0, StatusVenda.Faturado, v5);
            RegistroDeVendas rv25 = new RegistroDeVendas(25, new DateTime(2018, 10, 31), 7000.0, StatusVenda.Faturado, v3);
            RegistroDeVendas rv26 = new RegistroDeVendas(26, new DateTime(2018, 10, 6), 5000.0, StatusVenda.Faturado, v4);
            RegistroDeVendas rv27 = new RegistroDeVendas(27, new DateTime(2018, 10, 13), 9000.0, StatusVenda.Pendente, v1);
            RegistroDeVendas rv28 = new RegistroDeVendas(28, new DateTime(2018, 10, 7), 4000.0, StatusVenda.Faturado, v3);
            RegistroDeVendas rv29 = new RegistroDeVendas(29, new DateTime(2018, 10, 23), 12000.0, StatusVenda.Faturado, v5);
            RegistroDeVendas rv30 = new RegistroDeVendas(30, new DateTime(2018, 10, 12), 5000.0, StatusVenda.Faturado, v2);

            //Adicionar os objetos no BD
            _context.Departamento.AddRange(d1, d2, d3, d4);

            _context.Vendedores.AddRange(v1, v2, v3, v4, v5, v6);

            _context.RegistroDeVendas.AddRange(
                rv1, rv2, rv3, rv4, rv5, rv6, rv7,
                rv8, rv9, rv10, rv11, rv12, rv13,
                rv14, rv15, rv16, rv17, rv18, rv19, rv20,
                rv21, rv22, rv23, rv24, rv25, rv26, rv27,
                rv28, rv29, rv30
                );

            _context.SaveChanges();
        }
    }
}

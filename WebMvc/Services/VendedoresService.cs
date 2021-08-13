using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;

namespace WebMvc.Services
{
    public class VendedoresService
    {
        //Dependencia com o DBContext
        private readonly WebMvcContext _context;

        public VendedoresService(WebMvcContext context)
        {
            _context = context;
        }

        //Retornar todos vendedores do DB
        public List<Vendedores> FindAll()
        {
            return _context.Vendedores.ToList();
        }

        //Método para inserir novo vendedor no BD
        public void Insert(Vendedores obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}

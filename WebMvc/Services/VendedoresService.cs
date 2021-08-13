using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;
using Microsoft.EntityFrameworkCore;

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
        
        //Método para retornar vendedor por Id
        public Vendedores FindById(int id)
        {
            return _context.Vendedores.Include(obj => obj.Departamento).FirstOrDefault(obj => obj.Id == id);
        }

        //Remover vendedor do BD
        public void Remover(int id)
        {
            var obj = _context.Vendedores.Find(id);
            _context.Vendedores.Remove(obj);
            _context.SaveChanges();
        }
    }
}

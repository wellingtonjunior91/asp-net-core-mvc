using System;
using System.Collections.Generic;

namespace WebMvc.Models.ViewModels
{
    public class VendedorFormViewModel
    {
        public Vendedores Vendedores { get; set; }
        public ICollection<Departamento> Departamento { get; set; }
    }
}

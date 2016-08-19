using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoWeb.Models
{
    public class Categoria
    {
        public string Nome { get; set; }
        public string CategoriaID { get; set; }
        public int UsuarioID { get; set; }
    }
}
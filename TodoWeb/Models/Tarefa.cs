using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoWeb.Models
{
    public class Tarefa
    {
        public int TarefaID { get; set; }

        public string Nome { get; set; }

        public bool Concluida { get; set; }

        public int UsuarioID { get; set; }

        public int CategoriaID { get; set; }

        public string Descricao { get; set; }
    }
}
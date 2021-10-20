using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace sistemaDeTarefas.Models
{
    //classe que representa o contexto do bd gerenciado pelo EF, que por sua vez lida com as operacoes de CRUD
    public class TarefaDBContext : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
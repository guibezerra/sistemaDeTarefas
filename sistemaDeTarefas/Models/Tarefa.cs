using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace sistemaDeTarefas.Models
{
    /*
     * classe que representa uma tabela do bd, onde cada instancia representa uma tupla e cada propriedade representa uma coluna 
     * da tabela
     */
    public class Tarefa
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string responsavel { get; set; }
        public string prioridade { get; set; }
        public string deadline { get; set; }
        public string status { get; set; }
    }



}
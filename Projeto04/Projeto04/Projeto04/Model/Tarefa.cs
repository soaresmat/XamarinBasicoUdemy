using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04.Model
{
    [Table("Tarefa")]
    public class Tarefa
    {
        [PrimaryKey, AutoIncrement]
        public int TarefaId { get; set; }

        public string Nome { get; set; }
        public bool Finalizado { get; set; }
    }
}

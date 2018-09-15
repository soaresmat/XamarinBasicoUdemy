using Projeto04.Database;
using Projeto04.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04.ViewModel
{
    public class TelaPrincipalViewModel
    {
        public List<Tarefa> Tarefas { get; set; }

        public TelaPrincipalViewModel()
        {
            Tarefas = new TarefasDataAccess().GetTarefas();
        }
    }
}
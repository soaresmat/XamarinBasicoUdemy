using Projeto04.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projeto04.Database
{
    class TarefasDataAccess
    {
        private SQLiteConnection _database;

        public TarefasDataAccess()
        {
            _database = DependencyService.Get<IDatabase>().GetConnection();
            _database.CreateTable<Tarefa>();
        }

        public List<Tarefa> GetTarefas()
        {
            return _database.Table<Tarefa>().ToList();
        }

        public void SalvarTarefa(Tarefa tarefa)
        {
            _database.Insert(tarefa);
        }

        public void ExcluirTarefa(Tarefa tarefa)
        {
            _database.Delete(tarefa);
        }

        public void AtualizarTarefa(Tarefa tarefa)
        {
            _database.Update(tarefa);
        }
    }
}

using Projeto03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.ViewModel
{
    class TelaListaPessoaViewModel
    {
        public List<Pessoa> Pessoas { get; set; }

        public TelaListaPessoaViewModel()
        {
            Pessoas = new List<Pessoa>()
            {
                new Pessoa { Nome = "Matheus Soares", Email = "matulao12@gmail.com", Cargo = "Programador" },
                new Pessoa { Nome = "Jadir Rosa de Paula", Email = "jadirdepaula777@gmail.com", Cargo = "Autonomo" },
                new Pessoa { Nome = "Naira Lucia Soares de Paula", Email = "naira123@gmail.com", Cargo = "" },
                new Pessoa { Nome = "Renan Soares", Email = "renan_soares7@hotmail.com", Cargo = "Logístico" },
                new Pessoa { Nome = "Eduardo Soares", Email = "eduardo_rusbe@hotmail.com", Cargo = "Operador" }
            };          
        }
    }
}

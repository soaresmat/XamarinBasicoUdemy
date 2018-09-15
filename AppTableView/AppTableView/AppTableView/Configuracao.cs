using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04
{
    class Configuracao
    {
        public bool SincAutomatico { get; set; }
        public string SenhaBackup { get; set; }
        public string Descricao { get; set; }
        public string SenhaWifi { get; set; }

        public Configuracao()
        {
            SincAutomatico = true;
            SenhaBackup = "123abc";
            Descricao = "abcde";
            SenhaWifi = "321qwerty";
        }
    }
}

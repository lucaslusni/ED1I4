using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade9
{
    public class Visitante
    {
        public string Inscricao { get; set; }
        public string Nome { get; set; }
        public DateTime DtCheckIn { get; }

        public Visitante(string inscricao, string nome)
        {
            Inscricao = inscricao;
            Nome = nome;
            DtCheckIn = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Inscricao} - {Nome} - {DtCheckIn.ToString("yyyy/MM/dd HH:mm:ss")}";
        }
    }
}

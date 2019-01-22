using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjManut.Entidades
{
    class Mesa
    {
        public int CodMesa { get; set; }
        public int CodAluno { get; set; }
        public DateTime HrRetirada { get; set; }
        public DateTime HrEntrega { get; set; }

        public Mesa()
        {

        }

        public Mesa(int codMesa, int codAluno, DateTime hrRetirada, DateTime hrEntrega)
        {
            CodMesa = codMesa;
            CodAluno = codAluno;
            HrRetirada = hrRetirada;
            HrEntrega = hrEntrega;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace prjManut.Entidades
{
    class Aluno
    {

        public int CodAluno { get; set; }
        public uint Biometria { get; set; }

        public Aluno()
        {

        }

        public Aluno(int codAluno, uint biometria)
        {
            CodAluno = codAluno;
            Biometria = biometria;
        }
    }
}

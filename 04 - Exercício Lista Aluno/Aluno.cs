﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Exercício_Lista_Aluno
{
    internal class Aluno
    {
        public int Matricula { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateOnly DataNascimento { get; set; }

        public Aluno()
        {

        }

        public Aluno(int matricula, string nome, string cpf, DateOnly dataNascimento)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Cpf = cpf;
            this.DataNascimento = dataNascimento;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Livro;
using ClassesBasicas.Usuario;


namespace ClassesBasicas.Aluguel
{
    public class AluguelBC
    {
        private char dtEmprestimo;
        private int dtEntrega;

        private ICollection<LivroBC> livro;
        private UsuarioBC usuario;

     
        public AluguelBC()
        {
            
        }

        public char DtEmprestimo { get => dtEmprestimo; set => dtEmprestimo = value; }
        public int DtEntrega { get => dtEntrega; set => dtEntrega = value; }
        internal ICollection<LivroBC> Livro { get => livro; set => livro = value; }
        internal UsuarioBC Usuario { get => usuario; set => usuario = value; }

        public void cadastrarAluguel()
        {

        }

        public void listarAluguel()
        {

        }

        public void deletarAluguel()
        {

        }
    }
}
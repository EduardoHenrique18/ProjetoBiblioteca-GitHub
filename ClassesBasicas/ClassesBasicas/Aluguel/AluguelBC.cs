using System;
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
        private DateTime dtEmprestimo;
        private DateTime dtEntrega;
        private LivroBC livro;
        private UsuarioBC usuario;

     
        public AluguelBC()
        {
            this.Livro = new LivroBC();
            this.usuario = new UsuarioBC();
        }

        public DateTime DtEmprestimo { get => dtEmprestimo; set => dtEmprestimo = value; }
        public DateTime DtEntrega { get => dtEntrega; set => dtEntrega = value; }
        public LivroBC Livro { get => livro; set => livro = value; }
        public UsuarioBC Usuario { get => usuario; set => usuario = value; }

        public void cadastrarAluguel()
        {

        }

        public void listarAluguel()
        {

        }

        public void deletarAluguel()
        {

        }
        public void alterarAluguel()
        {

        }
    }
}

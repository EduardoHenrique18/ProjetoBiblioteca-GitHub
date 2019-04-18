using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Livro;
using ClassesBasicas.Usuario;


namespace ClassesBasicas.Aluguel
{
    class Aluguel
    {
        private char dtEmprestimo;
        private int dtEntrega;

        private ICollection<Livro> livro;

        private Usuario usuario;

        public Aluguel()
        {
            this.Livro = new Livro();
            this.Usuario = new Usuario();
        }

        public char DtEmprestimo
        {
            get
            {
                return dtEmprestimo;
            }

            set
            {
                dtEmprestimo = value;
            }
        }

        public int DtEntrega
        {
            get
            {
                return dtEntrega;
            }

            set
            {
                dtEntrega = value;
            }
        }

        public ICollection<Livro> Livro
        {
            get
            {
                return livro;
            }

            set
            {
                livro = value;
            }
        }

        public Usuario Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

       

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

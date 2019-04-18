using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Pagamento;
using ClassesBasicas.Aluguel;


namespace ClassesBasicas.Usuario
{
    class Usuario
    {
        private char cpfLeitor;
        private char nomeLeitor;
        private char dtNascimento;
        private char nmTelefone;
        private int multa;
        private Boolean status;

        private ICollection<Aluguel> aluguel;
        private ICollection<Pagamento> pagamento;

        public Usuario()
        {
            this.aluguel = new Aluguel();
            this.pagamento = new Pagamento();
        }

        public void cadastrarUsuario()
        {

        }

        public void realizarEmprestimo()
        {

        }

        public void realizarDevolucao()
        {

        }

        public void listarUsuario()
        {

        }

        public void deletarUsuario()
        {

        }
    }
}

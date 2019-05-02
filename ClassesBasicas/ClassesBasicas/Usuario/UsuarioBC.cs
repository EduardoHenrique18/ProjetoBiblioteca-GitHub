using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Pagamento;
using ClassesBasicas.Aluguel;


namespace ClassesBasicas.Usuario
{
    public class UsuarioBC
    {
        private char cpfLeitor;
        private char nomeLeitor;
        private char dtNascimento;
        private char nmTelefone;
        private int multa;
        private Boolean status;

       
        private ICollection<AluguelBC> aluguel;
        private ICollection<PagamentoBC> pagamento;

        
        public UsuarioBC()
        {
            this.Status = true;
            this.Multa = 0;
        }

        public char CpfLeitor { get => cpfLeitor; set => cpfLeitor = value; }
        public char NomeLeitor { get => nomeLeitor; set => nomeLeitor = value; }
        public char DtNascimento { get => dtNascimento; set => dtNascimento = value; }
        public char NmTelefone { get => nmTelefone; set => nmTelefone = value; }
        public int Multa { get => multa; set => multa = value; }
        public bool Status { get => status; set => status = value; }
        internal ICollection<AluguelBC> Aluguel { get => aluguel; set => aluguel = value; }
        internal ICollection<PagamentoBC> Pagamento { get => pagamento; set => pagamento = value; }

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

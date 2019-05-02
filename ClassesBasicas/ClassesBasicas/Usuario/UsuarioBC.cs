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
        private String cpfLeitor;
        private String nomeLeitor;
        private String dtNascimento;
        private String nmTelefone;
        private int multa;
        private Boolean status;

       
        private ICollection<AluguelBC> aluguel;
        private ICollection<PagamentoBC> pagamento;

        
        public UsuarioBC()
        {
            this.Status = true;
            this.Multa = 0;
        }

        public String CpfLeitor { get => cpfLeitor; set => cpfLeitor = value; }
        public String NomeLeitor { get => nomeLeitor; set => nomeLeitor = value; }
        public String DtNascimento { get => dtNascimento; set => dtNascimento = value; }
        public String NmTelefone { get => nmTelefone; set => nmTelefone = value; }
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

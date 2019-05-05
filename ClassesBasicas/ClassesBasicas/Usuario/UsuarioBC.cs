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
        private String cpfUsuario;
        private String nomeUsuario;
        private String dtNascimento;
        private String nmTelefone;
        private int status;
        private String endereco;
        private String sexo;

       
        private ICollection<AluguelBC> aluguel;
        private ICollection<PagamentoBC> pagamento;

        
        public UsuarioBC()
        {
            this.Status = 0;          
        }

        public String CpfUsuario { get => cpfUsuario; set => cpfUsuario = value; }
        public String NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public String DtNascimento { get => dtNascimento; set => dtNascimento = value; }
        public String NmTelefone { get => nmTelefone; set => nmTelefone = value; }
        public int Status { get => status; set => status = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        internal ICollection<AluguelBC> Aluguel { get => aluguel; set => aluguel = value; }
        internal ICollection<PagamentoBC> Pagamento { get => pagamento; set => pagamento = value; }
       
    }
}

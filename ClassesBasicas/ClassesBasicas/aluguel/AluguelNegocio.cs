using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasicas.Aluguel
{
    public class AluguelNegocio : IAluguelInterface
    {

        #region Cadastrar
        public void cadastrarAluguel(AluguelBC a)
        {
            if (a == null)
            {
                throw new Exception("Informar os dados do Aluguel");
            }
            //#CPF USUARIO
            if (String.IsNullOrEmpty(a.Usuario.CpfUsuario) == true)
            {
                throw new Exception("Cpf do usuario precisa ser preenchido");
            }
            if (String.IsNullOrWhiteSpace(a.Usuario.CpfUsuario) == true)
            {
                throw new Exception("Cpf do usuario precisa ser preenchido");
            }
            if (a.Usuario.CpfUsuario.Length > 15)
            {
                throw new Exception("O CPF do Usuário Não pode Conter mais de 15 Caracteres");
            }
            //DATA DE SAÍDA
            if (Convert.ToDateTime(a.DtEmprestimo) == null)
            {
                throw new Exception("A data de Saída precisa ser preenchido");
            }
            if (Convert.ToString(a.DtEmprestimo).Length > 10)
            {
                throw new Exception("a data de emprestimo Não pode Conter mais de 10 Caracteres");
            }
            //DATA DE ENTREGA
            if (Convert.ToDateTime(a.DtEntrega) == null)
            {
                throw new Exception("A data de Entrega precisa ser preenchido");
            }
            if (Convert.ToString(a.DtEntrega).Length > 10)
            {
                throw new Exception("a data de entrega Não pode Conter mais de 10 Caracteres");
            }
            //CODIGO DO LIVRO
            if (a.Livro.CodLivro <= 0)
            {
                throw new Exception("Informar o código do Livro");
            }
            AluguelDados dados = new AluguelDados();
            dados.cadastrarAluguel(a);     
        }
        #endregion
        #region Listar
        public List<AluguelBC> listarAluguel(AluguelBC a)
        {
            return new AluguelDados().listarAluguel(a);
            

        }
        #endregion
        #region Alterar
        public void alterarAluguel(AluguelBC a)
        {
            if (a == null)
            {
                throw new Exception("Informar os dados do Aluguel");
            }
            //#DATA DE SAÍDA
            if (Convert.ToDateTime(a.DtEmprestimo) == null)
            {
                throw new Exception("A data de Saída precisa ser preenchido");
            }
            if (Convert.ToString(a.DtEmprestimo).Length > 10)
            {
                throw new Exception("a data de emprestimo Não pode Conter mais de 10 Caracteres");
            }
            //DATA DE ENTREGA
            if (Convert.ToDateTime(a.DtEntrega) == null)
            {
                throw new Exception("A data de Entrega precisa ser preenchido");
            }
            if (Convert.ToString(a.DtEntrega).Length > 10)
            {
                throw new Exception("a data de entrega Não pode Conter mais de 10 Caracteres");
            }
            //CPF USUARIO
            if (String.IsNullOrEmpty(a.Usuario.CpfUsuario) == true)
            {
                throw new Exception("Cpf do usuario precisa ser preenchido");
            }

            if (String.IsNullOrWhiteSpace(a.Usuario.CpfUsuario) == true)
            {
                throw new Exception("Cpf do usuario precisa ser preenchido");
            }
            AluguelDados dados = new AluguelDados();
            dados.alterarAluguel(a);
        }
        #endregion
        #region Deletar
        public void deletarAluguel(AluguelBC a)
        {
            if (a == null)
            {
                throw new Exception("informe os dados do Aluguel");
            }
            if (String.IsNullOrEmpty(a.Usuario.CpfUsuario))
            {
                throw new Exception("Informar o Cpf do Usuario");
            }
            if (String.IsNullOrWhiteSpace(a.Usuario.CpfUsuario))
            {
                throw new Exception("Informar o CPF do Usuario");
            }
            AluguelBC alugel = new AluguelBC();
            alugel.Usuario.CpfUsuario = a.Usuario.CpfUsuario;
            AluguelDados dados = new AluguelDados();
            if (dados.listarAluguel(alugel).Count <= 0)
            {
                throw new Exception("O código referido não se encontra cadastrado");
            }
            
            dados.deletarAluguel(a);
        }
        #endregion
    }
}

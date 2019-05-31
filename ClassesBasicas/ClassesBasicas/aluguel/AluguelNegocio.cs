using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasicas.Aluguel
{
    public class AluguelNegocio : IAluguelInterface
    {
        

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

            //DATA DE SAÍDA
            if (Convert.ToDateTime(a.DtEmprestimo) == null)
            {
                throw new Exception("A data de Saída precisa ser preenchido");
            }

           
            //DATA DE ENTREGA
           if (Convert.ToDateTime(a.DtEntrega) == null)
            {
                throw new Exception("A data de Entrega precisa ser preenchido");
            }
            //CODIGO DO LIVRO
            if (a.Livro.CodLivro <= 0)
            {
                throw new Exception("Informar o código do Livro");
            }
            AluguelDados dados = new AluguelDados();
            dados.cadastrarAluguel(a);
            
        }

        public List<AluguelBC> listarAluguel(AluguelBC a)
        {
            return new AluguelDados().listarAluguel(a);
            

        }
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
            //DATA DE ENTREGA
           if (Convert.ToDateTime(a.DtEntrega) == null)
            {
                throw new Exception("A data de Entrega precisa ser preenchido");
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
    }
}

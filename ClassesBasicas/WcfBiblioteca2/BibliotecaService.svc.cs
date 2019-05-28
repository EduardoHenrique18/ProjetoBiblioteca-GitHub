using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassesBasicas.Aluguel;
using ClassesBasicas.Livro;
using ClassesBasicas.Pagamento;
using ClassesBasicas.Usuario;

namespace WcfBiblioteca2
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Service1 : IBibliotecaService
    {
        public void AlterarAluguel(AluguelBC a)
        {
            throw new NotImplementedException();
        }

        public void AlterarLivro(LivroBC l)
        {
            throw new NotImplementedException();
        }

        public void AlterarPagamento(PagamentoBC p)
        {
            throw new NotImplementedException();
        }

        public void AlterarUsuario(UsuarioBC u)
        {
            throw new NotImplementedException();
        }

        public void BaixaMulta(UsuarioBC u)
        {
            throw new NotImplementedException();
        }

        public void BloquearUsuario(UsuarioBC u)
        {
            throw new NotImplementedException();
        }

        public void CadastrarAluguel(AluguelBC a)
        {
            throw new NotImplementedException();
        }

        public void CadastrarLivro(LivroBC l)
        {
            throw new NotImplementedException();
        }

        public void CadastrarPagamento(PagamentoBC p)
        {
            throw new NotImplementedException();
        }

        public void CadastrarUsuario(UsuarioBC u)
        {
            throw new NotImplementedException();
        }

        public void DeletarLivro(LivroBC l)
        {
            throw new NotImplementedException();
        }

        public void DeletarPagamento(PagamentoBC p)
        {
            throw new NotImplementedException();
        }

        public void DeletarUsuario(UsuarioBC u)
        {
            throw new NotImplementedException();
        }

        public void DeltetarAluguel(AluguelBC a)
        {
            throw new NotImplementedException();
        }

        public void EmitirNF(UsuarioBC u)
        {
            throw new NotImplementedException();
        }

        public void LancarMulta(UsuarioBC u)
        {
            throw new NotImplementedException();
        }
        //TESTE ----------------------
        public string ListarAleatorio()
        {
            string a = "abc";
            return a;
        }
        // ---------------
        public List<AluguelBC> ListarAluguel(AluguelBC filtro)
        {
            throw new NotImplementedException();
        }
        public List<LivroBC> ListarLivro(LivroBC l)
        {
            //LivroBC filtro = new LivroBC();
            //filtro.CodLivro = 1;
            return new LivroNegocio().ListarLivros(l);
        }

        public List<PagamentoBC> ListarPagamento(PagamentoBC filtro)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioBC> ListarUsuario(UsuarioBC filtro)
        {
            throw new NotImplementedException();
        }
    }
}

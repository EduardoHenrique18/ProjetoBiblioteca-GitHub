using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ClassesBasicas.Aluguel;
using ClassesBasicas.Livro;
using ClassesBasicas.Pagamento;
using ClassesBasicas.Usuario;

namespace WcfBiblioteca
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class BibliotecaService1 : IBibliotecaService1
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

        public List<AluguelBC> ListarAluguel(AluguelBC filtro)
        {
            throw new NotImplementedException();
        }

        public List<LivroBC> ListarLivro(LivroBC filtro)
        {
            throw new NotImplementedException();
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

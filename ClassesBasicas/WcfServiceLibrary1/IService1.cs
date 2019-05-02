using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ClassesBasicas.Livro;
using ClassesBasicas.Aluguel;
using ClassesBasicas.Pagamento;
using ClassesBasicas.Usuario;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        //CRUD----------------------------------------------------
        void CadastrarLivro(LivroBC l);
        [OperationContract]
        void AlterarLivro(LivroBC l);
        [OperationContract]
        List<LivroBC> ListarLivro(LivroBC filtro);
        [OperationContract]
        void DeletarLivro(LivroBC l);

        [OperationContract]
        void CadastrarUsuario(UsuarioBC u);
        [OperationContract]
        void AlterarUsuario(UsuarioBC u);
        [OperationContract]
        List<UsuarioBC> ListarUsuario(UsuarioBC filtro);
        [OperationContract]
        void DeletarUsuario(UsuarioBC u);

        [OperationContract]
        void CadastrarAluguel(AluguelBC a);
        [OperationContract]
        void AlterarAluguel(AluguelBC a);
        [OperationContract]
        List<AluguelBC> ListarAluguel(AluguelBC filtro);
        [OperationContract]
        void DeltetarAluguel(AluguelBC a);

        [OperationContract]
        void CadastrarPagamento(PagamentoBC p);
        [OperationContract]
        void AlterarPagamento(PagamentoBC p);
        [OperationContract]
        List<PagamentoBC> ListarPagamento(PagamentoBC filtro);
        [OperationContract]
        void DeletarPagamento(PagamentoBC p);

        //Metodos Funcionais
        [OperationContract]
        void LancarMulta(UsuarioBC u);
        [OperationContract]
        void BaixaMulta(UsuarioBC u);
        [OperationContract]
        void EmitirNF(UsuarioBC u);
        [OperationContract]
        void BloquearUsuario(UsuarioBC u);

        // TODO: Add your service operations here
    }

    
    }


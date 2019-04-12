using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        //CRUD----------------------------------------------------
        void CadastrarLivro(Livro l);
        [OperationContract]
        void AlterarLivro(Livro l);
        [OperationContract]
        List<Livro> ListarLivro(Livro filtro);
        [OperationContract]
        void DeletarLivro(Livro l);

        [OperationContract]
        void CadastrarUsuario(Usuario u);
        [OperationContract]
        void AlterarUsuario(Usuario u);
        [OperationContract]
        List<Usuario> ListarUsuario(Usuario filtro);
        [OperationContract]
        void DeletarUsuario(Usuario u);

        [OperationContract]
        void CadastrarAluguel(Aluguel a);
        [OperationContract]
        void AlterarAluguel(Aluguel a);
        [OperationContract]
        List<Aluguel> ListarAluguel(Aluguel filtro);
        [OperationContract]
        void DeltetarAluguel(Aluguel a);

        [OperationContract]
        void CadastrarPagamento(Pagamento p);
        [OperationContract]
        void AlterarPagamento(Pagamento p);
        [OperationContract]
        List<Pagamento> ListarPagamento(Pagamento filtro);
        [OperationContract]
        void DeletarPagamento(Pagamento p);

        //Metodos Funcionais
        [OperationContract]
        void LancarMulta(Usuario u);
        [OperationContract]
        void BaixaMulta(Usuario u);
        [OperationContract]
        void EmitirNF(Usuario u);
        [OperationContract]
        void BloquearUsuario(Usuario u);

        // TODO: Add your service operations here
    }

    
    }


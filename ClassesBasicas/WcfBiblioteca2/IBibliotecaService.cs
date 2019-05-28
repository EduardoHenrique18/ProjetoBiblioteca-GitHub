using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassesBasicas.Livro;
using ClassesBasicas.Aluguel;
using ClassesBasicas.Pagamento;
using ClassesBasicas.Usuario;

namespace WcfBiblioteca2
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IBibliotecaService
    {
        // TESTE
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        Method = "GET")]
        string ListarAleatorio();
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void CadastrarLivro(LivroBC l);
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void AlterarLivro(LivroBC l);        
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "ListarLivro/{l}",
        Method = "GET")]
        List<LivroBC> ListarLivro(LivroBC l);
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void DeletarLivro(LivroBC l);

        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void CadastrarUsuario(UsuarioBC u);
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void AlterarUsuario(UsuarioBC u);
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        List<UsuarioBC> ListarUsuario(UsuarioBC filtro);
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void DeletarUsuario(UsuarioBC u);

        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void CadastrarAluguel(AluguelBC a);
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void AlterarAluguel(AluguelBC a);
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        List<AluguelBC> ListarAluguel(AluguelBC filtro);
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void DeltetarAluguel(AluguelBC a);

        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void CadastrarPagamento(PagamentoBC p);
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void AlterarPagamento(PagamentoBC p);
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        List<PagamentoBC> ListarPagamento(PagamentoBC filtro);
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
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

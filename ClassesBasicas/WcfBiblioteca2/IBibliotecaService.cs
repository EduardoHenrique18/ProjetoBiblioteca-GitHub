using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassesBasicas.Livro;
using ClassesBasicas.Aluguel;
using ClassesBasicas.Usuario;
using Newtonsoft.Json;

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
        Method = "GET")]
        List<LivroBC> ListarLivro(string l);
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
        ResponseFormat = WebMessageFormat.Json,
        Method ="GET")]
        List<AluguelBC> ListarAluguel();
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void DeletarAluguel(AluguelBC a);

        //Metodos Funcionais
        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        Method = "POST")]
        void ConfirmarEntrega(string a);

        [OperationContract]
        [WebInvoke(
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        Method = "GET")]
        List<LivroBC> ListarTodosLivros();

        // TODO: Add your service operations here
    }
}

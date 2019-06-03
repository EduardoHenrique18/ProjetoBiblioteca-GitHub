using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassesBasicas.Aluguel;
using ClassesBasicas.Livro;
using ClassesBasicas.Usuario;
using Newtonsoft.Json;

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

        public void AlterarUsuario(UsuarioBC u)
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

        public void CadastrarUsuario(UsuarioBC u)
        {
            throw new NotImplementedException();
        }

        public void ConfirmarEntrega(string a) 
        {
            AluguelBC obj = JsonConvert.DeserializeObject<AluguelBC>(a);
            AluguelNegocio neg = new AluguelNegocio();
            neg.ConfirmarEntrega(obj);
        }

        public void DeletarAluguel(AluguelBC a)
        {
            throw new NotImplementedException();
        }

        public void DeletarLivro(LivroBC l)
        {
            throw new NotImplementedException();
        }

        public void DeletarUsuario(UsuarioBC u)
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
        public List<AluguelBC> ListarAluguel()
        {
            AluguelNegocio neg = new AluguelNegocio();
            return neg.ListarAluguel();
        }
        public List<LivroBC> ListarLivro(string l)
        {
            var result = JsonConvert.DeserializeObject<LivroBC>(l);

            return new LivroNegocio().ListarLivros(result);
        }

        public List<LivroBC> ListarTodosLivros()
        {
            LivroNegocio neg = new LivroNegocio();
            return neg.ListarTodosLivros();
        }

        public List<UsuarioBC> ListarUsuario(UsuarioBC filtro)
        {
            throw new NotImplementedException();
        }
    }
}

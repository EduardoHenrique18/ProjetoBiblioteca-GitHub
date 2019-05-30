using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Livro;
using ClassesBasicas.Usuario;

namespace ConsoleApp1
{
    class Teste
    {
        static void Main(string[] args)
        {
            /*UsuarioBC usuario = new UsuarioBC();
            usuario.CpfUsuario = "125966789";
            
            UsuarioDados dao = new UsuarioDados();
            List<UsuarioBC> listar = new List<UsuarioBC>();
            listar = dao.ListarUsuario(usuario);           
            foreach (UsuarioBC u in listar)
            {
                Console.WriteLine(u.CpfUsuario + " " + u.NomeUsuario + " " + u.Sexo +" " + u.NmTelefone +" " + u.Endereco +" " + u.DtNascimento +" " + u.Status);
            }
            Console.ReadKey();*/
            // teste create
            LivroBC livro = new LivroBC();
            //livro.CodLivro = 2;
            //livro.Autor = "cleiton";
            //livro.EditoraLivro = "marisvaldas";
            livro.TituloLivro = "a volta dos que nao foram";
            LivroNegocio livronegocio = new LivroNegocio();
            //livronegocio.CadastrarLivro(livro);
            // teste listar
            List<LivroBC> listar = new List<LivroBC>();
            //listar = livronegocio.ListarLivros(livro);
                        

            ServiceReference1.BibliotecaServiceClient client = new ServiceReference1.BibliotecaServiceClient();
            ICollection<LivroBC> returnn = client.ListarLivro(livro);
            //Console.WriteLine(returnn);
            //Console.ReadKey();
            foreach (LivroBC l in returnn)
            {
                Console.WriteLine(l.CodLivro + " " + l.Autor);
            }
            Console.ReadKey();

        }
    }
}

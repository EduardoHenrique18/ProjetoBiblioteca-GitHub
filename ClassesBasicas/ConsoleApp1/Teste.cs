using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Livro;
using ClassesBasicas.Usuario;
using ClassesBasicas.Aluguel;


namespace ConsoleApp1
{
    class Teste
    {
        static void Main(string[] args)
        {
            /*UsuarioBC usuario = new UsuarioBC();
            usuario.CpfUsuario = "175456789";
            usuario.DtNascimento = DateTime.Parse("2000/01/16");
            usuario.Endereco = "rua das aves";
            usuario.NmTelefone = "81995923931";
            usuario.Sexo = "Masculino";
            usuario.NomeUsuario = "eduardo";
            UsuarioNegocio neg = new UsuarioNegocio();
            neg.CadastrarUsuario(usuario);
            ICollection<UsuarioBC> col = neg.ListarUsuario(usuario);
            foreach (UsuarioBC u in col)
            {
                Console.WriteLine(u.CpfUsuario + " " + u.NomeUsuario + " " + u.Sexo + " " + u.NmTelefone + " " + u.Endereco + " " + u.DtNascimento + " " + u.Status);
            }
            Console.ReadKey();*/
            //Teste cadastrar livro !funcionando
            /*LivroBC livro = new LivroBC();
            livro.Autor = "cleiton rasta";
            livro.EditoraLivro = "marisvalda";
            livro.TituloLivro = "a volta dos que nao foram";
            LivroNegocio neg = new LivroNegocio();
            
            ICollection<LivroBC> col = neg.ListarLivros(livro);
            foreach (LivroBC u in col)
            {
                Console.WriteLine(u.CodLivro);
            }
            Console.ReadKey();*/

            /*AluguelBC aluguel = new AluguelBC();
            AluguelNegocio neg = new AluguelNegocio();
            aluguel.Usuario.CpfUsuario = "175456789";
            aluguel.Livro.CodLivro = 2;
            //neg.CadastrarAluguel(aluguel);
            ICollection<AluguelBC> col = neg.ListarAluguel(aluguel);
            foreach (AluguelBC a in col)
            {
                Console.WriteLine(a.DtEmprestimo + "" + a.DtEntrega + "" + a.Valor);
            }
            Console.ReadKey();*/ 

        }
    }
}

            
          
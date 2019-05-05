using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Usuario;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioBC usuario = new UsuarioBC();
            usuario.CpfUsuario = "125966789";
            usuario.NomeUsuario = "eduardoow";
            usuario.Sexo = "masculino";
            usuario.NmTelefone = "995923931";
            usuario.Endereco = "av. sao paulo";
            usuario.DtNascimento = "16012000";
            UsuarioDados dao = new UsuarioDados();
            Console.WriteLine(dao.ListarUsuario(usuario));
            Console.ReadKey();

        }
    }
}

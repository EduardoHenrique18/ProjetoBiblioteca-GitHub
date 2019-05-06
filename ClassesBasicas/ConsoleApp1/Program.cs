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
            
            UsuarioDados dao = new UsuarioDados();
            List<UsuarioBC> listar = new List<UsuarioBC>();
            listar = dao.ListarUsuario(usuario);           
            foreach (UsuarioBC u in listar)
            {
                Console.WriteLine(u.CpfUsuario + " " + u.NomeUsuario + " " + u.Sexo +" " + u.NmTelefone +" " + u.Endereco +" " + u.DtNascimento +" " + u.Status);
            }
            Console.ReadKey();

        }
    }
}

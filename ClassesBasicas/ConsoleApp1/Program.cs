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
            usuario.CpfLeitor = "123456";
            usuario.NomeLeitor = "joana";
            usuario.DtNascimento = "16/01/2000";
            UsuarioDados dao = new UsuarioDados();
            dao.CadastrarUsuario(usuario);
        }
    }
}

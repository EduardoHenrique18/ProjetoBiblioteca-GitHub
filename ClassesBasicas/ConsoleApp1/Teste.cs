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
            AluguelBC al = new AluguelBC();
            AluguelNegocio negocio = new AluguelNegocio();
            LivroBC livro = new LivroBC();
            al.Usuario.CpfUsuario = "11030869448";
            al.Livro.CodLivro = 3;
            al.DtEmprestimo =Convert.ToDateTime("1992/07/06");
            al.DtEntrega =Convert.ToDateTime("2013/05/31");
            negocio.cadastrarAluguel(al);
            
        }
    }
}

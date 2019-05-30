using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Usuario;
using ClassesBasicas.Aluguel;
using ClassesBasicas.Livro;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AluguelBC a = new AluguelBC();
           
            AluguelNegocio negocio = new AluguelNegocio();

            a.Livro.CodLivro = 1;
            a.Usuario.CpfUsuario = "11122233344";

            negocio.cadastrarAluguel(a);

            
           
           

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasicas.Aluguel
{
    public class AluguelNegocio : IAluguelInterface
    {
        

        public void CadastrarAluguel(AluguelBC a)
        {
            if (a.Usuario.Status == 0)
            {
                throw new Exception("Usuario bloqueado ate a devolução");
            }
            if (a.Livro.Situaçao == 0)
            {
                throw new Exception("Livro ja esta alugado");
            }
            AluguelDados dao = new AluguelDados();
            dao.CadastrarAluguel(a);
        }

        public List<AluguelBC> ListarAluguel()
        {
            return new AluguelDados().ListarAluguel();

        }
        public void AlterarAluguel(AluguelBC a)
        {
            AluguelDados dao = new AluguelDados();
            dao.AlterarAluguel(a);
        }
       

        public void CalcularValor(AluguelBC a)
        {
            AluguelDados dao = new AluguelDados();
            dao.CalcularValor(a);
        }

        public void ConfirmarEntrega(AluguelBC a)
        {
            AluguelDados dao = new AluguelDados();
            dao.ConfirmarEntrega(a);
        }
    }
}

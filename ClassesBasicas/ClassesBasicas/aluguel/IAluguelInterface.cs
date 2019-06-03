using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasicas.Aluguel
{
    public interface IAluguelInterface
    {
        void CadastrarAluguel(AluguelBC a);
        void AlterarAluguel(AluguelBC a);
        List<AluguelBC> ListarAluguel();
        void CalcularValor(AluguelBC a);
        void ConfirmarEntrega(AluguelBC a);
    }
}

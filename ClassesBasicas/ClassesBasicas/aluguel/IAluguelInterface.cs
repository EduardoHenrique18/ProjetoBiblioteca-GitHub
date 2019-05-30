using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasicas.Aluguel
{
    interface IAluguelInterface
    {
        void cadastrarAluguel(AluguelBC a);
        void alterarAluguel(AluguelBC a);
        void deletarAluguel(AluguelBC a);
        List<AluguelBC> listarAluguel(AluguelBC a);
    }
}

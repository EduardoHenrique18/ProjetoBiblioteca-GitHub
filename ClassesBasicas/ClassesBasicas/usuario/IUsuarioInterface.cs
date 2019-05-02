using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Usuario;

namespace ClassesBasicas.Usuario
{
    public interface IUsuarioInterface
    {
        void CadastrarUsuario(UsuarioBC u);
        void AlterarProduto(UsuarioBC u);
        void RemoverProduto(UsuarioBC u);
        List<UsuarioBC> ListarProdutos(UsuarioBC u);
    }
}

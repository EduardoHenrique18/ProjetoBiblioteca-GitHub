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
        void AlterarUsuario(UsuarioBC u);
        void RemoverUsuario(UsuarioBC u);
        List<UsuarioBC> ListarUsuario(UsuarioBC filtro);
    }
}

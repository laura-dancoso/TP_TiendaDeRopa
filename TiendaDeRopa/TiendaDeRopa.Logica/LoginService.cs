using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDeRopa.Dominio.Entidades;

namespace TiendaDeRopa.Logica
{
    public interface ILoginService
    {
        void LogIn(Usuario usuario); 
        void LogOut(Usuario usuario);
    }
    public class LoginService : ILoginService
    {
        public void LogIn(Usuario usuario)
        {
            if (usuario.Email.Contains("@"))
            {
                usuario.LogIn();
                return;
            }
            throw new Exception("El mail debe ser válido");
        }

        public void LogOut(Usuario usuario)
        {
            usuario.LogOut();
        }
    }
}

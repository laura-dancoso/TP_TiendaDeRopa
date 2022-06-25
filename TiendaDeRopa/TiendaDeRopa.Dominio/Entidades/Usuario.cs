namespace TiendaDeRopa.Dominio.Entidades
{
    public abstract class Usuario: Entidad
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public bool EstaLogueado { get; protected set; }

        public Usuario(string nombre, string email)
        {
            Nombre = nombre;
            Email = email;
        }
        public abstract void LogIn();
        public abstract void LogOut();
    }
}

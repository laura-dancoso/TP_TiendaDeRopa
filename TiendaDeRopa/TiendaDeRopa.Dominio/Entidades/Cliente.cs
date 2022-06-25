namespace TiendaDeRopa.Dominio.Entidades
{
    public class Cliente : Usuario
    { 
        public bool Premium { get; private set; }

        public Cliente(string nombre, string email) : base(nombre, email)
        {
            Premium = false;
        }

        public Cliente(string nombre, string email, bool premium) : base(nombre, email)
        {
            Premium = premium;
        }

        public void DarDeAltaPremium()
        {
            Premium = true;
        }

        public void DarDeBajaPremium()
        {
            Premium = false;
        }

        public override void LogIn()
        {
            EstaLogueado = true;
        }

        public override void LogOut()
        {
            EstaLogueado = false;
        }
    }
}

namespace TiendaDeRopa.Dominio.Entidades
{
    public class Cliente : Usuario
    { 
        public bool Premium { get; private set; }

        public Cliente(int id, string nombre, string email) : base(id,nombre, email)
        {
            Premium = false;
        }

        public Cliente(int id,string nombre, string email, bool premium) : base(id,nombre, email)
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

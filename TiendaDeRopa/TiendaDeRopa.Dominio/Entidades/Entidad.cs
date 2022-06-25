namespace TiendaDeRopa.Dominio.Entidades
{
    public abstract class Entidad
    {
        public int Id { get; set; }

        protected Entidad(int id)
        {
            Id = id;
        }
    }
}

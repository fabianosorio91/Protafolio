namespace Portafolio.Servicios
{
    public class ServicioUnico
    {
        public ServicioUnico()
        {
            ObtenerGuid = new Guid();
        }

        public Guid ObtenerGuid { get; set; }
    }
}

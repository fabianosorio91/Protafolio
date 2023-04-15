using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }


    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "Programa realizado con ASP",
                Link= "https://amazon.com",
                ImagenULR = "/img/amazon.png"
            },

            new Proyecto
                {
                Titulo = "New yor times",
                Descripcion = "Programa realizado con ASP",
                Link= "https://amazon.com",
                ImagenULR = "/img/amazon.png"
            },

            new Proyecto
                    {
                Titulo = "Reddit",
                Descripcion = "Programa realizado con ASP",
                Link= "https://amazon.com",
                ImagenULR = "/img/amazon.png"
            },

             new Proyecto
                    {
                Titulo = "Steam",
                Descripcion = "Programa realizado con ASP",
                Link= "https://amazon.com",
                ImagenULR = "/img/amazon.png"
            }

            };

        }
    }
}

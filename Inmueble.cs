using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Inmueble
    {
        public string TipoInmueble { get; set; }
        public string Ubicacion { get; set; }
        public double AreaTerreno { get; set; }
        public double Precio { get; set; }

        public void Vender()
        {
            Console.WriteLine($"{TipoInmueble} con un area de {AreaTerreno}, con ubicacion {Ubicacion} ha sido vendida por L{Precio}");

        }

        public void Vender(string Cliente) 
        {
            Console.WriteLine($"{TipoInmueble} con un area de {AreaTerreno}, con ubicacion {Ubicacion} ha sido vendida por L{Precio} al cliente {Cliente}");
        }

        public void Vender(double Descuento)
        {
            Console.WriteLine($"{TipoInmueble} con un area de {AreaTerreno}, con ubicacion {Ubicacion} ha sido vendida por L{Precio} con un descuento de L{Descuento}");
        }

        public void Vender(string Cliente, double Descuento)
        {
            Console.WriteLine($"{TipoInmueble} con un area de {AreaTerreno}, con ubicacion {Ubicacion} ha sido vendida por L{Precio} al cliente {Cliente} y con un descuento de L{Descuento}");
        }

    }
}

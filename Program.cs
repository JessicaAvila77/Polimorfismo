using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //polimorfismo mediante lista
            List<Edificio> edificiolista = new List<Edificio>();

            string opcion = "";


            do
            {
                Edificio edificio = new Edificio();
                Console.Write("Ingrese tipo de edificio:");
                edificio.Tipo = Console.ReadLine();
                Console.Write("Ingrese el precio:");
                edificio.Precio = Convert.ToDouble(Console.ReadLine());
                edificiolista.Add(edificio);

                Console.Write("Desea continuar (s/n)?");
                opcion = Console.ReadLine();


            } while (opcion != "n");


            Console.WriteLine();
            Console.WriteLine("****Lista de edificios********");

            foreach (Edificio edificio in edificiolista)
            {
                edificio.Vender();
            }

        }
    }
}

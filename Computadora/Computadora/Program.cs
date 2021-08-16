using Computadora.Entidades;
using Computadora.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsComputadora clscomputadora = new ClsComputadora();
            NClsComputadora nclscomputadora = new NClsComputadora();

            clscomputadora.Microprocesador = "intel core i5";
            clscomputadora.Memoriaram = 8;

            Console.WriteLine(nclscomputadora.Encender(clscomputadora));

            Console.ReadLine();
        }
    }
}

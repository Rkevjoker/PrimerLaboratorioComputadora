using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Entidades
{
    class ClsComputadora
    {
        private String mouse;
        private String teclado;
        private String monitor;
        private int memoriaram;
        private int discoduro;
        private String cpu;
        private String tarjetadevideo;
        private String webcam;
        private String bocinas;
        private String tarjetamadre;

        public string Mouse { get => mouse; set => mouse = value; }
        public string Teclado { get => teclado; set => teclado = value; }
        public string Monitor { get => monitor; set => monitor = value; }
        public int Memoriaram { get => memoriaram; set => memoriaram = value; }
        public int Discoduro { get => discoduro; set => discoduro = value; }
        public string Cpu { get => cpu; set => cpu = value; }
        public string Tarjetadevideo { get => tarjetadevideo; set => tarjetadevideo = value; }
        public string Webcam { get => webcam; set => webcam = value; }
        public string Bocinas { get => bocinas; set => bocinas = value; }
        public string Tarjetamadre { get => tarjetamadre; set => tarjetamadre = value; }
    }
}

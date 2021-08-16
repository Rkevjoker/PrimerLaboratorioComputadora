using Computadora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Negocio
{
    class NClsComputadora
    {
        public String ReproducirAudio(ClsComputadora computadora)

        {
            computadora.Bocinas = "Logitech z120";   
            return "las bocinas logitech z120" + computadora.Bocinas + "estan reproduciendo audio";


        }
        public String EditorDeTexto(ClsComputadora computadora)
        {
            computadora.Teclado = "Logitech k380";
            return "El teclado logitech k380" +computadora.Teclado + "esta escibiendo texto";
        }
        public String CapturarVideo(ClsComputadora computadora)
        {
            computadora.Webcam = "Go pro hero 8";
            return " la webcam go pro hero 8" + computadora.Webcam + "esta  capturando video";
        }
        public String Encender(ClsComputadora computadora)

        {
            computadora.Microprocesador = "intel core i5";
            computadora.Memoriaram = 8;


            return " la computadora con microprocesado " + computadora.Microprocesador + " con memoria ram de " + computadora.Memoriaram + " esta Encendida ";



        }
    }
}

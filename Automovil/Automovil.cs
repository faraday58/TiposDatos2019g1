using System;

namespace Automoviles
{
    class Automovil
    {
        private string marca;
        private ushort modelo;
        private string color;
        private ushort potencia;
        private bool alarma;

        public Automovil()
        {
            marca = "Rolls Royce";
            modelo = 2019;
            potencia = 500;

            Console.WriteLine("Mi automovil es marca: {0} \n modelo: {1} \n potencia: {2}", marca, modelo, potencia);

        }



        public void Encender()
        {
            Console.WriteLine("Automovil Encendido");
        }
        public void Apagar()
        {
            Console.WriteLine("Automovil Apagado");
        }



    }
}

using System;

namespace MediosTransporte
{
    class Camion:Transporte
    {
        private int numerosillas;


        public Camion()
        {
            Modelo = 1700;
            Potencia = 3000;
            Encender();
            Acelerar();
        }
    }
}

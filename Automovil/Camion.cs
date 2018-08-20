using System;

namespace MediosTransporte
{
    class Camion:Transporte
    {
        public Camion()
        {
            Modelo = 1700;
            Potencia = 3000;
            Encender();
            Acelerar();
        }
    }
}

using System;

namespace MediosTransporte
{
    class Bicicleta: Transporte
    {
        public Bicicleta()
        {

            
        }

        public override void Acelerar()
        {
            Velocidad++;
            if ( Velocidad >= 40 )
            {
                Velocidad = 40;
            }
            Console.WriteLine("Velocidad : {0} km/h ", Velocidad);

        }
    }
}

using System;

namespace Automoviles
{
    class Automovil
    {
        public string marca;
        public ushort modelo;
        public string color;
        public ushort potencia;
        public bool alarma;

        public void Encender()
        {
            Console.WriteLine("Automovil Encendido");
        }
        public void Apagar()
        {
            Console.WriteLine("Automovil Apagado");
        }
        


    }



    class Program
    {
        static void Main()
        {
            //Instancia de la clase Automovil
            Automovil miAutomovil = new Automovil();
            miAutomovil.marca = "BMW";
            miAutomovil.modelo = 2019;
            miAutomovil.color = "Blanco";
            miAutomovil.potencia = 520;
            miAutomovil.alarma = true;

            Console.WriteLine(" Mi Automovil es : {0}  \n modelo: {1} \n color: {2}  \n potencia: {3} hp ",miAutomovil.marca,miAutomovil.modelo,miAutomovil.color,miAutomovil.potencia );
            if (miAutomovil.alarma)  // miAutomovil.alarma == true
            {
                Console.WriteLine("Se lo están robando");
                miAutomovil.Encender();
            }
            miAutomovil.Apagar();


        }
    }
}

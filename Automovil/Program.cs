using System;

namespace Automoviles
{


    class Program
    {



        static void Main()
        {
            //Instancia de la clase Automovil
            
            Automovil miAutomovil = new Automovil();

            Console.WriteLine("Ingresa la marca de tu Automóvil ");
            string marca = Console.ReadLine();
             Automovil suautomovil = new Automovil(marca);
            miAutomovil = suautomovil;

            Console.WriteLine("Ingresa el modelo y la potencia");
            ushort modelo = ushort.Parse(Console.ReadLine());
            ushort potencia = ushort.Parse(Console.ReadLine());

            Automovil nuestroAutomovil = new Automovil(modelo, potencia);
            


            /*
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
            */



        }
    }
}

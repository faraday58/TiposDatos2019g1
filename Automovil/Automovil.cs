using System;

namespace Automoviles
{
    class Automovil
    {
        #region Atributos
        private string marca;
        private ushort modelo;
        private string color;
        private ushort potencia;
        private bool alarma;
        #endregion

        #region Propiedades
        #endregion


        #region Constructores
        public Automovil()
        {
            marca = "Rolls Royce";
            modelo = 2019;
            potencia = 500;

            Console.WriteLine("Mi automovil es marca: {0} \n modelo: {1} \n potencia: {2}", marca, modelo, potencia);
            Apagar();
        }

        public Automovil(string marca)
        {
            //Asignando valor al atributo 
            this.marca = marca;
            Console.WriteLine("La marca que ingresaste es {0}", this.marca);
            Encender();

        }

        public Automovil(ushort modelo, ushort potencia)
        {
            int distancia=0; 
            this.modelo = modelo;
            this.potencia = potencia;

           
            Console.WriteLine("Ingrese distancia recorrida");
            distancia = int.Parse(Console.ReadLine());      
            int velocity = potencia * distancia;

            Console.WriteLine("Mi automovil modelo {0} recorrió {1} km con potencia de {2} HP y a una velocidad de {3}", modelo, distancia, potencia, velocity);            

        }

        #endregion

        #region Métodos

        public void Encender()
        {

            Console.WriteLine("Automovil Encendido");
        }
        public void Apagar()
        {
            Console.WriteLine("Automovil Apagado");
        }
        #endregion


    }
}

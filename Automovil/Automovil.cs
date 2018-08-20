using System;

namespace Automoviles
{
    class Automovil
    {
        #region Atributos
        private byte velocidad;
        private string marca;
        private ushort modelo;
        private string color;
        private ushort potencia;
        private bool alarma;
        #endregion

        #region Propiedades
        public ushort Modelo
        {
            //get Lee el valor del atributo modelo
            get
            {
                if (modelo == 0)
                    return 2005;
                else
                    return modelo;
            }
            //Escribe o asigna un nuevo valor al atributo modelo
            set
            {
                if ( value < 1890 || value > 2019 )
                {
                    modelo = 2019;
                }
                else
                {
                    modelo = value;
                }
                
            }
        }

        public ushort Potencia
        {
            get
            {
                return potencia;
            }
            set
            {
                if (value < 200 || value > 2000)
                {
                    potencia = 1000;
                }
                else
                {
                    potencia = value;
                }

            }
        }

        public byte Velocidad {
            get => velocidad;
            set
            {
                if( velocidad > 253)
                {
                    velocidad = 254;
                }
                else
                {
                    velocidad = value;
                }
                
            } 
                

        }

        #endregion


        #region Constructores
        public Automovil()
        {
            marca = "Rolls Royce";
            modelo = 2019;
            Potencia = 500;

            Console.WriteLine("Mi automovil es marca: {0} \n modelo: {1} \n potencia: {2}", marca, modelo, Potencia);
            Encender();
        }

        public Automovil(string marca)
        {
            //Asignando valor al atributo 
            this.marca = marca;
            Console.WriteLine("La marca que ingresaste es {0}", this.marca);
            Apagar();

        }

        public Automovil(ushort modelo, ushort potencia)
        {
            int distancia=0; 
            this.modelo = modelo;
            this.Potencia = potencia;

           
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


        public void Acelerar()
        {
            Velocidad++; //velocidad = velocidad + 1
            Console.WriteLine(Velocidad);
        }

        public void Apagar()
        {
            Console.WriteLine("Automovil Apagado");
        }
        #endregion


    }
}

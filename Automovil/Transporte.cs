using System;

namespace MediosTransporte
{
    class Transporte
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
                if (value < 1890 || value > 2019)
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

        public byte Velocidad
        {
            get => velocidad;
            set
            {
                if (velocidad > 253)
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


        #region Métodos

        public void Encender()
        {

            Console.WriteLine("Medio Encendido");
        }


        public void Acelerar()
        {
            Velocidad++; //velocidad = velocidad + 1
            Console.WriteLine(Velocidad);
        }

        public void Apagar()
        {
            Console.WriteLine("Medio Apagado");
        }
        #endregion
    }
}

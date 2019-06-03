using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto8
{
    class Vector
    {
        int[] vectorNumeros;
        string[] vectorCadenaTexto;

        public Vector()
        {
        }

        public Vector(int capacidadVectores)
        {
            vectorNumeros = new int[capacidadVectores];
            vectorCadenaTexto = new string[capacidadVectores];
        }

        public void llenarVectorNumero()
        {
            
            for(int i = 0; i < vectorNumeros.Length; i++) // Length -> numero de elementos que contiene el vector
            {
                vectorNumeros[i] = i+5;
            }
        }

        public void llenarVectorCadena()
        {

            for (int i = 0; i < vectorCadenaTexto.Length; i++) // Length -> numero de elementos que contiene el vector
            {
                vectorCadenaTexto[i] = "Vamos sumando de 15 en 15, El valor de la posicion es: "+(i + 15).ToString();
            }
        }
        
        public string dameDatosPosicionVectorCadenas(int posicion)
        {
            // string texto = "La posicion es mayor que la capacidad del vector.posicion: " + posicion.ToString() + " capacidad vector: " + vectorCadenaTexto.Length.ToString();
            string texto = "";
            if(posicion < vectorCadenaTexto.Length)
            {
                texto = vectorCadenaTexto[posicion].ToString();
            }
            else if (posicion > vectorCadenaTexto.Length)
            {
                texto = "LA POSICION DEL VECTOR ES " + posicion.ToString() + " NO TIENE CAPACIDAD EL VECTOR YA QUE SU LIMITE ES DE: " + vectorCadenaTexto.Length.ToString();
            }
            else if (posicion >= vectorCadenaTexto.Length)
            {
                texto = "LA POSICION DEL VECTOR ES " + posicion.ToString() + " LA CAPACIDAD VECTORES: " + vectorCadenaTexto.Length.ToString();
            }


            return texto;

        }

        public string dibujarDatosVector()
        {
            string vectorTexto = "";
            int cont = 5;
            for (int i = 0; i < vectorCadenaTexto.Length; i++)
            {
                vectorCadenaTexto[i] = cont.ToString();
                vectorTexto += vectorCadenaTexto[i];
                cont++;
            }
            return vectorTexto;
        }
    }
}

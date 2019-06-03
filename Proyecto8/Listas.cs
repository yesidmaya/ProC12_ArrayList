using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto8
{
    class Listas
    {
        private List<int> lista;
        int tamLista = -1; //tamaño lista Esta variable es de tipo privado

        public int TamLista { get => tamLista; set => tamLista = value; }
        public List<int> Lista { get => lista; set => lista = value; }

        //public int TamLista { get => tamLista; set => tamLista = value; } 
        // de esta manera nos devuelve automaticamente cuando le damos clic derecho a la variable tamLista-acciones rapidas-encapsular y usar propiedad 
        // la comvertimos a una variable de tipo publico
        // get: valor que podemos devolver
        // set: para asignar un valor

        // public int TamLista { get => lista.Count; set => tamLista = value; } 
        // SE PUEDE ACCEDER A LA VARIABLE A TRAVES DE LA PROPIEDAD TamLista
        // la modifique para que nos diga los elementos de una lista
        // seria lo mismo si se utiliza la variable (lista). pero en este momento utilizamos la de la forma (lista.Count)

        public Listas() //Constructor
        {
            Lista = new List<int>(); // objeto tipo lista y tipo de valor que va a almacenar que puede ser int, boolean, vector
        }

        public void llamarLista(int tam)
        {
            for (int i = 0; i < tam; i++)
                Lista.Add(i); //Agregamos elementos a la lista

            TamLista = tam; // inicializamos tamaño de la lista
        }

        public int dameElementoLista(int pos)
        {
            return Lista[pos]; //elemento de la lista que este en la posicion que nosotros queremos indicar
        }

        public Boolean BorrarElemento(int posicion)
        {
            Boolean elementoBorradoCorrectamente = false; //para comprobar si la operacion se hizo correctamente o no 

            if (posicion < Lista.Count)
            {
                Lista.Remove(posicion);
                elementoBorradoCorrectamente = true; //si se borra correctamente cambia a true
            }
            return elementoBorradoCorrectamente;
        }
    }
}

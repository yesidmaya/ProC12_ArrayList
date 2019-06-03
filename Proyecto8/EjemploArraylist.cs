using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Proyecto8
{
    class EjemploArraylist
    {
        ArrayList arraylist;

        public EjemploArraylist(List<int> lista) // al constructor se le pasa la lista directamente y no se la construye con el metodo (arraylist.Add())
        {
            arraylist = new ArrayList(lista);
        }

        public  int[] dameArray() // me devuelve un array de enteros a partir de un arrayLIst
        {
            return (int[]) arraylist.ToArray(typeof (int)); // pasar un array list a un array de enteros
                                                            // (int[]) testear para que devuelva lista de enteros
                                                            // typeof (int) se especifica al tipo que lo tiene que comvertir
                                                            // el typeof lo combierte a int
        }

        public int dameElemento(int pos)
        {
            return (int)arraylist[pos]; //devuelve la posicion del elemento tipo int 
        }

        public void borrarElemento(int posicion)
        {
            arraylist.Remove(posicion);
        }
    }
}
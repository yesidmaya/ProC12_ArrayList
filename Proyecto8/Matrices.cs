using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto8
{
    class Matrices
    {
        private string[,] mat; // Declaramos matriz

        public Matrices(int filas, int columnas)
        {
            mat = new string[filas, columnas];
        }

        public void cargarMatriz()
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++) // Obtenemos numero de columnas con GetLength
                {
                    mat[f, c] = "Fila: " + f.ToString() + " Columna: " + c.ToString();
                }
            }
        }

        public string dameElementoMatriz(int fila, int columna)
        {
            string valor = "ELEMENTO NO ENCONTRADO, ESTA POSICION NO PERTENECE A LA MATRIZ: Fila -> " + fila.ToString() + " Columna -> " + columna.ToString();
            if (fila < mat.GetLength(0) && columna < mat.GetLength(1))
            {
                valor = mat[fila, columna];
            }
            return valor;
        }

        public string dibujarMatriz()
        {
            string matrizTexto = String.Empty;
            int cont = 100;

            for (int f = 0; f < mat.GetLength(0); f++)
            {
                matrizTexto += "\n";
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    mat[f, c] = cont.ToString();
                    matrizTexto += " " + mat[f, c].ToString();
                    cont++;
                }
            }
            return matrizTexto;
        }
    }
}

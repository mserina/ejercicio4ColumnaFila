using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4ColumnasFilas.servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {

        public void meterValoresTabla(int[,] tablaNumeros)
        {
            int fila;
            int columna;
            Random numerosRandom = new Random();

            //Este for controla las filas, empiezas con 0, si el numero de filas es menor que el numero de filas de la matriz suma 1 a la variable filas
            for (fila = 0; fila < tablaNumeros.GetLength(0); fila++)
            {
                //Lo mismo seria con columna solo que en el GetLength ponemos uno para que haga referencia a la segunda dimension del array
                for (columna = 0; columna < tablaNumeros.GetLength(1); columna++)
                {
                    //Y ya luego asigna a filas y columnas los numeros aleaorios entre 1 y 100
                    tablaNumeros[fila, columna] = numerosRandom.Next(1, 100);
                }
            }
        }

        public void mostrarEnTabla(int[,] tablaNumeros)
        {
            //Fila
            for (int i = 0; i < tablaNumeros.GetLength(0); i++)
            {
            //Columna
                for (int j = 0; j < tablaNumeros.GetLength(1); j++)
                {
                    //OJO: TEN EN CUENTA QUE EN ESTA PARTE SE UTILIZA EL WRITE Y NO EL WRITELINE, POR QUE SINO LOS NUMEROS  DE LA SEGUNDA COLUMNA SE PONDRAN ABAJO
                    Console.Write(tablaNumeros[i, j] + "\t");
                }
                //Agrega un salto de línea al final de cada fila
                Console.WriteLine();
            }
        }
        public void ordenarColumnas(int[,] numeros)
        {
            int filas = numeros.GetLength(0);
            int columnas = numeros.GetLength(1);

            //Columna
            for (int j = 0; j < columnas; j++)
            {
                //Metemos el valor que representa la longuitud del array filas
                int[] OrdenarColumnas = new int[filas];
                
            //Mete los datos de la columna del array numeros al array OrdenarColumnas (j) ; pd: la i es la fila la cual lo controla este for y la j es la columna que lo controla el for exterior
                for(int i = 0; i < filas; i++)
                {
                    OrdenarColumnas[i] = numeros[i, j];
                }

            //Ordenar los numeros de la columna 
                Array.Sort(OrdenarColumnas);

            //Meter la columna ya ordenada dentro del array; en este caso es igual que con el 
                for (int i = 0;i < filas; i++)
                {
                    numeros[i, j] = OrdenarColumnas[i]; 
                }
                
            }
        }
    }
}

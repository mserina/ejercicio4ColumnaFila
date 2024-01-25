namespace ejercicio4ColumnasFilas
{

    class Program
    {

        static void Main(string[] args)
        {
            int fila;
            int columna;
            Random numerosRandom = new Random();
            int[,] tablaNumeros = new int [3, 2];

            //Este for controla las filas, empiezas con 0, si el numero de filas es menor que el numero de filas de la matriz suma 1 a la variable filas
            for (fila = 0;fila < tablaNumeros.GetLength(0); fila++)
            {
             //Lo mismo seria con columna solo que en el GetLength ponemos uno para que haga referencia a la segunda dimension del array
                for (columna = 0; columna < tablaNumeros.GetLength(1);columna++)
                {
                    //Y ya luego asigna a filas y columnas los numeros aleaorios entre 1 y 100
                   tablaNumeros[fila, columna] = numerosRandom.Next(1, 100);
                }
            }
            
            for (fila = 0; fila < tablaNumeros.GetLength(0); fila++)
            {
                Console.WriteLine(tablaNumeros[fila, 0]);
                Console.WriteLine(tablaNumeros[fila, 1]);
            }
           
            
        }
    } 
}
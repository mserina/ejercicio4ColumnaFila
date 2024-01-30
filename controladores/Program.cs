using ejercicio4ColumnasFilas.servicios;

namespace ejercicio4ColumnasFilas.controladores
{

    class Program
    {

        static void Main(string[] args)
        {
          
            OperacionInterfaz op = new OperacionImplementacion();
            int[,] tablaNumeros = new int[3, 2];

            op.meterValoresTabla(tablaNumeros);
            op.mostrarEnTabla(tablaNumeros);
            Console.WriteLine(" ");
            op.ordenarColumnas(tablaNumeros);
            Console.WriteLine(" ");
            op.mostrarEnTabla(tablaNumeros);
        }
    }
}
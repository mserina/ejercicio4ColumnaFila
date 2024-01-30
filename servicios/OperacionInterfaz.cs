using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4ColumnasFilas.servicios
{
    internal interface OperacionInterfaz
    {

        public void meterValoresTabla(int[,] tablaNumeros);

        public void ordenarColumnas(int[,] numeros);

        public void mostrarEnTabla(int[,] tablaNumeros);

    }
}

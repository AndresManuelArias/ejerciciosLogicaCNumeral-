using System;

namespace esencia_logica
{
    public class GestionDeDatos
    {
        public Libreria libreria = new Libreria();

        public int[] inputInt(int digitosPedir,int cantidadDigitos){
            int[] numerosIngresados = new int[digitosPedir];
            for (int numeroIngresado = 0; numeroIngresado < digitosPedir; numeroIngresado++)
            {
                bool pasar = false;
                do
                {
                    Console.WriteLine("Introduzca el numero "+(numeroIngresado+1));
                    numerosIngresados[numeroIngresado]=Convert.ToInt32(Console.ReadLine());
                    if(cantidadDigitos == 0 || libreria.contarDigitos(numerosIngresados[numeroIngresado]) == cantidadDigitos){
                        pasar = true;
                    }else{
                        pasar = false;
                        Console.WriteLine("El numero debe tener {0} digitos para que sea valido, por favor vuelva a ingresar los datos",cantidadDigitos);
                    }
                     
                } while (!pasar);
            }
            return numerosIngresados;
        }
    }
}

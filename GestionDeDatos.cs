using System;

namespace esencia_logica
{
    public class GestionDeDatos
    {
        private Libreria libreria = new Libreria();
        public bool numeroDosDigitos(int numero){
            bool tieneDosDigitos = libreria.determinarSiTiene(numero,2);
            if(!tieneDosDigitos){
                Console.WriteLine("El numero {0} no tiene dos digitos, por favor ingrese un numero de 2 digitos.",numero);
            }
            return tieneDosDigitos;
        }
        public int[] inputInt(int digitosPedir,Func<int, bool>[] funciones){
            int[] numerosIngresados = new int[digitosPedir];
            for (int numeroIngresado = 0; numeroIngresado < digitosPedir; numeroIngresado++)
            {
                bool pasar = false;
                do
                {
                    Console.WriteLine("Introduzca el numero "+(numeroIngresado+1));
                    numerosIngresados[numeroIngresado]=Convert.ToInt32(Console.ReadLine());
                    int[] numeroRevisar = {numerosIngresados[numeroIngresado]};
                    pasar =  libreria.every(numeroRevisar,funciones);
                    // if(cantidadDigitos == 0 || libreria.contarDigitos(numerosIngresados[numeroIngresado]) == cantidadDigitos){
                    //     pasar = true;
                    // }else{
                    //     pasar = false;
                    //     Console.WriteLine("El numero debe tener {0} digitos para que sea valido, por favor vuelva a ingresar los datos",cantidadDigitos);
                    // }
                     
                } while (!pasar);
            }
            return numerosIngresados;
        }
        public int[] inputInt(int digitosPedir,Func<int, bool> funcion){
            int[] numerosIngresados = new int[digitosPedir];
            for (int numeroIngresado = 0; numeroIngresado < digitosPedir; numeroIngresado++)
            {
                bool noPasar = true;
                do
                {
                    Console.WriteLine("Introduzca el numero "+(numeroIngresado+1));
                    numerosIngresados[numeroIngresado]=Convert.ToInt32(Console.ReadLine());
                    noPasar =  libreria.every(numerosIngresados,funcion);
                     
                } while (!noPasar);
            }
            return numerosIngresados;
        }
        public int[] inputInt(int digitosPedir){
            int[] numerosIngresados = new int[digitosPedir];
            for (int numeroIngresado = 0; numeroIngresado < digitosPedir; numeroIngresado++)
            {
                Console.WriteLine("Introduzca el numero "+(numeroIngresado+1));
                numerosIngresados[numeroIngresado]=Convert.ToInt32(Console.ReadLine());

            }
            return numerosIngresados;
        }
        
    }
}

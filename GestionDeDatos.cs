using System;

namespace esencia_logica
{
    public class GestionDeDatos
    {
        static private Libreria libreria = new Libreria();
        public Func<int,Func<int,bool>> numeroContieneEstosDigitos = (numeroDigitos)=> (numero)=> determinarSiTiene(numero,numeroDigitos);
        static private bool determinarSiTiene(int numero,int cantidadDigitos){
            bool tieneDosDigitos = libreria.determinarSiTiene(numero,cantidadDigitos);
            if(!tieneDosDigitos){
                Console.WriteLine($"El numero {numero} no tiene {cantidadDigitos}  digitos, por favor ingrese un numero que tenga un tamaño de {cantidadDigitos}  digitos.");
            }
            return   libreria.determinarSiTiene(numero,cantidadDigitos);
        }
        public int[] inputInt(int digitosPedir,Func<int, bool>[] funciones){
            int[] numerosIngresados = new int[digitosPedir];
            for (int numeroIngresado = 0; numeroIngresado < digitosPedir; numeroIngresado++)
            {
                bool noPasar = true;
                int[] numeroRevisar ;
                do
                {
                    numeroRevisar =  pedirDato(numeroIngresado);
                    noPasar =  libreria.every(numeroRevisar,funciones);
                } while (!noPasar);
                numerosIngresados[numeroIngresado] = numeroRevisar[0];
            }
            return numerosIngresados;
        }
        public int[] inputInt(int digitosPedir,Func<int, bool> funcion){
            int[] numerosIngresados = new int[digitosPedir];
            for (int numeroIngresado = 0; numeroIngresado < digitosPedir; numeroIngresado++)
            {
                bool noPasar = true;
                int[] numeroRevisar ;
                do
                {
                    numeroRevisar =  pedirDato(numeroIngresado);
                    noPasar =  libreria.every(numeroRevisar,funcion);
                } while (!noPasar);
                numerosIngresados[numeroIngresado] = numeroRevisar[0];

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
        public int[]  pedirDato(int orden){
                Console.WriteLine("Introduzca el numero "+(orden+1));
                int numeroIngresar=Convert.ToInt32(Console.ReadLine());
                int[] numeroRevisar = {numeroIngresar};
                return numeroRevisar;
        }
        
    }
}

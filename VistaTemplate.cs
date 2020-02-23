using System;

namespace esencia_logica
{
    public class VistaTemplate
    {
        public Libreria libreria = new Libreria();
        public  void determinarSiEsNegativo(int numero){
            if( libreria.determinarSiEsNegativo(numero)){
                Console.WriteLine("El numero {0} si es negativo ",numero);
            }else{
                Console.WriteLine("El numero {0} no es negativo ",numero);
            }
        }
        public void mostrarSiEsPrimo(int numero){
            if(libreria.saberSiEsPrimo(numero)){
                Console.WriteLine("El numero  {0} es primo.",numero);
            }else{
                Console.WriteLine("El numero  {0} no es primo.",numero);
            }
        }

    }
}

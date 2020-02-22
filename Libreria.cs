using System;

namespace esencia_logica
{
    public class Libreria
    {
        public int ultimoDigito(int numero){
            return numero%10;
        }
        public bool numeroEsPar(int numero){
            return numero%2==0;
        }
        public bool every(int[] numeros,Func<int, bool> funcion1){
            bool cumple = true;
            for (int numero = 0; numero < numeros.Length; numero++)
            {
                if(funcion1(numeros[numero]) != true){
                    cumple = false;
                    break;
                }
            }
            return cumple;
        }
        public bool numeroTerminadoEn(int numeroIngresar,int numeroTerminado){
            return   ultimoDigito(numeroIngresar) ==numeroTerminado;
        }
        public int contarDigitos(int numero){
            int contador_digitos = 0;
            do
            {
            numero = numero/10;
            contador_digitos++;
            // Console.WriteLine("numero:"+numero+" contador_digitos"+contador_digitos);
            } while (numero > 0);
            return contador_digitos;
        }
        public bool determinarSiTiene(int numeroIngresar,int numeroDigitosEsperados){
            return contarDigitos(numeroIngresar) == numeroDigitosEsperados;
        }
        public bool determinarSiEsNegativo(int numeroIngresar){
            return numeroIngresar <0;
        }
        public int[] digitosDelNumero(int numeroIngresar){
            int contador_digitos = contarDigitos(numeroIngresar);
            int [] coleccionadorDigitos = new int[contador_digitos];
            for (int digito = 0; digito < contador_digitos; digito++)
            {
                coleccionadorDigitos[digito]=numeroIngresar%10;
                numeroIngresar = numeroIngresar/10;
                // Console.WriteLine("numero:{0} coleccionadorDigitos[digito] {1}",numeroIngresar,coleccionadorDigitos[digito]);                 
            }
            return coleccionadorDigitos;
        }
        public int sumar( int [] numeros){
            int sumando = 0;
            foreach (int numero in numeros)
            {
                sumando += numero;
            }
            return sumando;
        }
    }
}

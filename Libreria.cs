using System;
using System.Collections.Generic;

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
        public int[] numerosIguales(int[] numeros){
            List<int> coleccion = new List<int>();
            foreach (int numero1 in numeros)
            {
                int repeticiones = 0;
                foreach (int numero2 in numeros)
                {
                    if(numero1 == numero2){
                        repeticiones++;
                        if(repeticiones > 1){
                            coleccion.Add(numero1);
                        }
                    }
                }
            }
            return coleccion.ToArray();
        }
        public int[] mapConvertir(int[] numeros,Func<int, int> funcion){
            List<int> numerosConertidos = new List<int>();
            foreach (var numero in numeros)
            {
                numerosConertidos.Add(funcion(numero));
            }
            return numerosConertidos.ToArray();
        }
        public int[][] mapConvertir(int[] numeros,Func<int, int[]> funcion){
            List<int[]> numerosConertidos = new List<int[]>();
            foreach (var numero in numeros)
            {
                numerosConertidos.Add(funcion(numero));
            }
            return numerosConertidos.ToArray();
        }
        public int countIf(int[] numeros,Func<int, bool> funcion){
            int  conteo = 0;
            for (int numero = 0; numero < numeros.Length; numero++)
            {
                if(funcion(numeros[numero]) == true){
                    conteo++;
                }
            }
            return conteo;            
        }
        public bool some(int[] numeros,Func<int,int, bool> funcion){
            bool  cumple = false;
            for (int numero = 0; numero < numeros.Length; numero++)
            {
                if(funcion(numeros[numero],numero) == true){
                    cumple = true;
                    break;
                }
            }
            return cumple;            
        }
        public bool some(int[] numeros,Func<int, bool> funcion){
            bool  cumple = false;
            for (int numero = 0; numero < numeros.Length; numero++)
            {
                if(funcion(numeros[numero]) == true){
                    cumple = true;
                    break;
                }
            }
            return cumple;            
        }
        public int finIndex(int[] numeros,Func<int, bool> funcion ){
            int  indice = -1;            
            for (int numero = 0; numero < numeros.Length; numero++)
            {
                if(funcion(numeros[numero]) == true){
                    indice = numero;
                    break;
                }
            }
            return indice;            
        }
        public int fin(int[] numeros,Func<int, bool> funcion ){
          int indice =  finIndex(numeros,funcion);
          return numeros[indice];
        }
        public int[] filter(int[] numeros,Func<int, bool> funcion){
            List<int> coleccion = new List<int>();
            foreach (int numero in numeros)
            {
                if(funcion(numero)){
                    coleccion.Add(numero);
                }              
            }
            return coleccion.ToArray();
        }
        public int[][] filter(int[][] numeros,Func<int[], bool> funcion){
            List<int[]> coleccion = new List<int[]>();
            foreach (int[] numero in numeros)
            {
                if(funcion(numero)){
                    coleccion.Add(numero);
                }              
            }
            return coleccion.ToArray();
        }
        public bool every(int[] numeros,Func<int, bool>[] funciones){
            bool cumple = true;
            for(int funcion = 0;funcion < funciones.Length;funcion++)
            {
                for (int numero = 0; numero < numeros.Length; numero++)
                {
                    if(funciones[funcion](numeros[numero]) != true){
                        cumple = false;
                        goto salida;
                    }
                }
            }
            salida:
            return cumple;
        }
        public bool every(int[] numeros,Func<int, bool> funcion){
            bool cumple = true;
            for (int numero = 0; numero < numeros.Length; numero++)
            {
                if(funcion(numeros[numero]) != true){
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
            numero = numero<0?numero*-1:numero;
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
        public int sumarSi(int[] numeros,Func<int,int, bool> funciones){
            int sumando = 0;
            for (int indice = 0; indice < numeros.Length; indice++)
            {
                if(funciones(numeros[indice],indice)){
                    sumando += numeros[indice];            
                }
            }
            return sumando;
        }
        public int sumarSi(int[] numeros,Func<int, bool> funciones){
            int sumando = 0;
            foreach (int numero in numeros)
            {
                if(funciones(numero)){
                    sumando += numero;            
                }
            }
            return sumando;
        }
        public float div( int [] numeros,bool orden = true){
            float dividido = 0;
            if(orden){
                for (int indice = 0; indice < numeros.Length; indice++)
                {
                    dividido /= numeros[indice];            
                }
            }else{
                for (int indice = numeros.Length-1; indice >= 0; indice--)
                {
                    dividido /= numeros[indice];            
                }
            }
            return dividido;
        }
        public int sumar( int [] numeros){
            int sumando = 0;
            foreach (int numero in numeros)
            {
                sumando += numero;
            }
            return sumando;
        }
        public int sumar( int [][] numeros){
            int sumando = 0;
            foreach (int[] numero in numeros)
            {
                sumando += sumar(numero);
            }
            return sumando;
        }
        public bool elNumeroEsMenorque(int numeroIngresar,int menorQueEsteNumero){
            bool esMenor = false;
            if(numeroIngresar < menorQueEsteNumero){
                esMenor = true;
            }else{
                Console.WriteLine("El numero {0} ingresado es mayor que {1}",numeroIngresar,menorQueEsteNumero);
            }
            return esMenor;
        }
        public bool saberSiEsPrimo(int numeroIngresar){
            bool esPrimo = false;
            int conteoDivisores = 0;
            numeroIngresar = numeroIngresar<0? numeroIngresar*-1:numeroIngresar;
            for (int divisor = 1; divisor <= numeroIngresar; divisor++)
            {
                if(numeroIngresar%divisor == 0){
                    conteoDivisores++;
                }
                if(conteoDivisores > 3){
                    break;
                }
            }
            if(conteoDivisores <=2){
                esPrimo = true;
            }
            return esPrimo;
        }
        public bool esMultiplo(int numeroIngresado1,int numeroIngresado2){
            int dividendo= Math.Max(numeroIngresado1,numeroIngresado2);
            int divisor= Math.Min(numeroIngresado1,numeroIngresado2);
            return dividendo%divisor == 0;
        }
        public int[] divisoresDe(int  numero){
            List<int> numerosDivisores = new List<int>();
            for (int divisor = 0; divisor < numero; divisor++)
            {                
                if(numero%divisor == 0){
                    numerosDivisores.Add(divisor);
                }
            }
            return numerosDivisores.ToArray();
        }
        public int[] factoresPrimosDe(int numero){
            List<int> factores = new List<int>();
            int divisor = 2;
            do
            {              
                if(saberSiEsPrimo(divisor)){
                    if(numero%divisor == 0){
                        Console.WriteLine("numero:"+numero);  
                        Console.WriteLine("divisor:"+divisor);
                        factores.Add(divisor);
                        numero /= divisor;
                    }else{
                        divisor++;
                    }
                } else{
                    divisor++;
                }    
            } while (numero >1);
        
            return factores.ToArray();           
        }
        public int[] factoresPrimosDe(int[] numeros){
            List<int> factores = new List<int>();
            int divisor = 2;
            while (some(numeros,(numero)=>numero >1) ){
                    
                if(saberSiEsPrimo(divisor) && some(numeros,(numero)=>numero%divisor == 0)){

                    factores.Add(divisor);
                    numeros = mapConvertir(numeros,(numero)=> numero%divisor == 0? numero / divisor:numero);
                }else{
                    divisor++;
                }    
            }        
            return factores.ToArray();           
        }
        public int reduce(int[] numeros,Func<int,int ,int> funcion){
            int acumulado = numeros[0];
            for (int numero = 1; numero < numeros.Length; numero++)
            {
                acumulado = funcion(acumulado,numeros[numero]);               
            }
            return acumulado;
        }
        public int[] reduce(int[][] numeros,Func<int[],int[] ,int[]> funcion){
            int[] acumulado = numeros[0];
            for (int numero = 1; numero < numeros.Length; numero++)
            {
                acumulado = funcion(acumulado,numeros[numero]);               
            }
            return acumulado;
        }
        public int minimoComunMultiplo(int[] numeros){
            List<int> colecionfactores = new List<int>();
            colecionfactores.AddRange(factoresPrimosDe(numeros));
            Console.WriteLine("colecionfactores.ToArray()"+colecionfactores.ToArray());
            return reduce(colecionfactores.ToArray(),(int a,int b)=>a*b);
        }
        public int encontrarNumeroMayor(int[] numeros){
            int numeroMayor = numeros[0];
            foreach (int numero in numeros)
            {
                numeroMayor = Math.Max(numero,numeroMayor);                
            }
            return numeroMayor;
        }
        public void DisplayValues(int[] numeros)  
        {
            for ( int i = 0 ;i < numeros.Length;i++ )  {
                Console.WriteLine( "   [{0}] : {1}", i, numeros[i] );
            }
            Console.WriteLine();
        }
    }
}

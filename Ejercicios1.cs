using System;
using System.Collections.Generic;

namespace esencia_logica
{
     class Ejercicios1:PadreEjercicios
    {

        /*
1. Leer un número entero y determinar si es un número terminado en 4.*/
    private void determinarTerminadoEn4(){
        Console.WriteLine("1. Leer un número entero y determinar si es un número terminado en 4.");
        int[] numero = gestionDeDatos.inputInt(1);
        if(libreria.numeroTerminadoEn(numero[0],4)){
            Console.WriteLine("El numero termina en 4");
        }else{
            Console.WriteLine("El numero no termina en 4");
        }
    }
    public override void ejercicio1(){
        determinarTerminadoEn4();
    }
/*
2. Leer un número entero y determinar si tiene 3 dígitos.*/
    private void determinarNumeroEnteroTiene3Digitos(){
        Console.WriteLine("2. Leer un número entero y determinar si tiene 3 dígitos.");
        int[] numero = gestionDeDatos.inputInt(1);
        // int conteoDigitos =  libreria.contarDigitos(numero[0]);
        // Console.WriteLine("tiene  {0} digitos ",conteoDigitos);
        if(libreria.determinarSiTiene(numero[0],3)){
            Console.WriteLine("El numero {0} si contiene 3 digitos",numero[0]);
        }else{
            Console.WriteLine("El numero {0} no contiene 3 digitos",numero[0]);
        }
    }
   public override void ejercicio2(){
        determinarNumeroEnteroTiene3Digitos();
    }    
/*
3. Leer un número entero y determinar si es negativo.*/

    public void determinarSiEsNegativo(){
        Console.WriteLine("3. Leer un número entero y determinar si es negativo.");
        int numero = gestionDeDatos.inputInt(1)[0];
        vistaTemplate.determinarSiEsNegativo(numero); 
    }
    public override void ejercicio3(){
        determinarSiEsNegativo();
    } 
/*
4. Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos.
*/
    private void cuantoEsIgualSumaDigitos(){
        Console.WriteLine("4. Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos.");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(2))[0];
        int[] digitos =  libreria.digitosDelNumero(numero);
        int sumaDeNumeros = libreria.sumar(digitos);
        Console.WriteLine("La suma de sus numeros es {0}",sumaDeNumeros);
    }
    public override void ejercicio4(){
        cuantoEsIgualSumaDigitos();
    }

/*
5. Leer un número entero de dos dígitos y determinar si ambos dígitos son pares.
*/
    public void determinarAmbosDigitosPares(){
        Console.WriteLine("5. Leer un número entero de dos dígitos y determinar si ambos dígitos son pares.");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(2))[0];
        int[] digitos =  libreria.digitosDelNumero(numero);
        bool digitosSonPares =  libreria.every(digitos,libreria.numeroEsPar);
        if(digitosSonPares){
            Console.WriteLine("todos los dígitos de {0} son pares.",numero);
        }else{
            Console.WriteLine("algunos de los dígitos de {0} no son pares.",numero);
        }
    }
    public override void ejercicio5(){
        determinarAmbosDigitosPares();
    }
/*
6. Leer un número entero de dos dígitos menor que 20 y determinar si es primo.*/
    public void numeroMenor20DeterminarSiEsPrimo(){
        Console.WriteLine("6. Leer un número entero de dos dígitos menor que 20 y determinar si es primo.");
        Func<int, bool>[] condicion = {(int numero)=> gestionDeDatos.numeroContieneEstosDigitos(2)(numero),(int numero)=> libreria.elNumeroEsMenorque(numero,20)};
        int numero = gestionDeDatos.inputInt(1,condicion)[0];
        vistaTemplate.mostrarSiEsPrimo(numero);
    }
    public override void ejercicio6(){
        numeroMenor20DeterminarSiEsPrimo();
    }
/*
7. Leer un número entero de dos dígitos y determinar si es primo y además si es negativo.*/
    public void determinarSiEsPrimoYNegativo(){
        Console.WriteLine("7. Leer un número entero de dos dígitos y determinar si es primo y además si es negativo.");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(2))[0];
        vistaTemplate.determinarSiEsNegativo(numero);
        vistaTemplate.mostrarSiEsPrimo(numero);
    }
    public override void ejercicio7(){
        determinarSiEsPrimoYNegativo();
    }
/*
8. Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos.*/
    public void siDosDigitosSonPrimos(){
        Console.WriteLine("8. Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos.");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(2))[0];
        if(libreria.every(libreria.digitosDelNumero(numero),libreria.saberSiEsPrimo)){
            Console.WriteLine("Todos sus digitos son primos");
        }else{
            Console.WriteLine("Alguno de sus digitos no son primos");
        }
    }
    public override void ejercicio8(){
        siDosDigitosSonPrimos();
    }
/*
9. Leer un número entero de dos dígitos y determinar si un dígito es múltiplo del otro.*/
    public void unDigitoMultiploDeOtro(){
        Console.WriteLine("9. Leer un número entero de dos dígitos y determinar si un dígito es múltiplo del otro.");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(2))[0]; 
        int[] digitos = libreria.digitosDelNumero(numero);
        int multipoDelOtro = libreria.minimoComunMultiplo(digitos);
        Console.WriteLine("minimoComunMultiplo:"+multipoDelOtro);
        if(libreria.some(digitos,(numero)=> numero==multipoDelOtro)){
            Console.WriteLine("Un numero es multiplo del otro");
        }else{
            Console.WriteLine("Ningun numero es multiplo del otro");
        }
    }
    public override void ejercicio9(){
        unDigitoMultiploDeOtro();
    }
/*
10. Leer un número entero de dos dígitos y determinar si los dos dígitos son iguales.*/
    public void determinarSiLosDosDigitosSonIguales(){
        Console.WriteLine("10. Leer un número entero de dos dígitos y determinar si los dos dígitos son iguales.");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(2))[0]; 
        int[] digitos = libreria.digitosDelNumero(numero);
        int [] numeroIguales = libreria.numerosIguales(digitos);
        foreach (int digito in numeroIguales)
        {
            Console.WriteLine($"digito {digito}");        
        }
        if(numeroIguales.Length > 0){
            Console.WriteLine("Sus digitos son iguales");
        }else{
            Console.WriteLine("Sus digitos no son iguales");
        }       
    }
    public override void ejercicio10(){
        determinarSiLosDosDigitosSonIguales();
    }
/*
11. Leer dos números enteros y determinar cuál es el mayor.*/
    public void dosNumerosEnterosCualEsMayor(){
        Console.WriteLine("11. Leer dos números enteros y determinar cuál es el mayor.");
        int[] numeros = gestionDeDatos.inputInt(2); 
        int numeroMayor =  libreria.encontrarNumeroMayor(numeros);
        Console.WriteLine("Numero mayor es "+numeroMayor);
    }
    public override void ejercicio11(){
        dosNumerosEnterosCualEsMayor();
    }  
/*
12. Leer dos números enteros de dos dígitos y determinar si tienen dígitos comunes.*/
    public void determinarSiDosNUmerosTienenDigitosComunes(){
        Console.WriteLine("12. Leer dos números enteros de dos dígitos y determinar si tienen dígitos comunes.");
        int[] numeros = gestionDeDatos.inputInt(2,gestionDeDatos.numeroContieneEstosDigitos(2));
        int[][] grupoDigitos = libreria.mapConvertir(numeros,(numero)=>libreria.digitosDelNumero(numero));
        List<int> coleccion = new List<int>();
        foreach (int[] numerosDigitos1 in grupoDigitos)
        {
            foreach (int[] numerosDigitos2 in libreria.filter(grupoDigitos,(digitos)=>!digitos.Equals(numerosDigitos1)))
            {
               coleccion.AddRange(libreria.filter( numerosDigitos1,(digito1)=>libreria.some( numerosDigitos2 ,(digito2) => digito1 == digito2)));         
            }
        }
        coleccion.ForEach(a => Console.WriteLine(" coleccion: {0}",a));
        if(coleccion.ToArray().Length > 1){
            Console.WriteLine("Contiene digitos comunes ");
        }else{
            Console.WriteLine("No contiene digitos comunes ");
        }
    }
    public override void ejercicio12(){
        determinarSiDosNUmerosTienenDigitosComunes();
    }  
/*
13. Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina
un número par.*/
    public void leerDosNumerosSumarDecirSiEsPar(){
        Console.WriteLine("13. Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.");
        int[] numeros = gestionDeDatos.inputInt(2,gestionDeDatos.numeroContieneEstosDigitos(2));
        if(libreria.numeroEsPar(libreria.sumar(numeros))){
            Console.WriteLine("La suma de sus digitos es par");
        }else{
            Console.WriteLine("La suma de sus digitos no es par");
        }
    }
    public override void ejercicio13(){
        leerDosNumerosSumarDecirSiEsPar();
    }  
/*
14. Leer dos números enteros de dos dígitos y determinar a cuánto es igual la suma de todos los dígitos.*/
    public void laSumaDeSusDigitosEs(){
        Console.WriteLine("14. Leer dos números enteros de dos dígitos y determinar a cuánto es igual la suma de todos los dígitos.");
        int[] numeros = gestionDeDatos.inputInt(2,gestionDeDatos.numeroContieneEstosDigitos(2));
        int[][] grupoDigitos = libreria.mapConvertir(numeros,(numero)=>libreria.digitosDelNumero(numero));
        int sumarDigitos = libreria.sumar(grupoDigitos);
        Console.WriteLine($"La suma de sus digitos es {sumarDigitos}");             
    }
    public override void ejercicio14(){
        laSumaDeSusDigitosEs();
    } 
/*
15. Leer un número entero de tres dígitos y determinar a cuánto es igual la suma de sus dígitos.*/

    public override void ejercicio15(){
        Console.WriteLine("15. Leer un número entero de tres dígitos y determinar a cuánto es igual la suma de sus dígitos.");
        int[] numeros = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(3));
        int[][] grupoDigitos = libreria.mapConvertir(numeros,(numero)=>libreria.digitosDelNumero(numero));
        int sumarDigitos = libreria.sumar(grupoDigitos);
        Console.WriteLine($"La suma de sus digitos es {sumarDigitos}");  
    } 
/*
16. Leer un número entero de tres dígitos y determinar si al menos dos de sus tres dígitos son iguales.*/
    public override void ejercicio16(){
        Console.WriteLine("16. Leer un número entero de tres dígitos y determinar si al menos dos de sus tres dígitos son iguales.");
            int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(5))[0]; 
            int[] digitos = libreria.digitosDelNumero(numero);
            int [] numeroIguales = libreria.numerosIguales(digitos);
            foreach (int digito in numeroIguales)
            {
                Console.WriteLine($"digito {digito}");        
            }
            if(numeroIguales.Length > 1){
                Console.WriteLine("Sus digitos son iguales");
            }else{
                Console.WriteLine("Sus digitos no son iguales");
            }    
    }
/*
17. Leer un número entero de tres dígitos y determinar en qué posición está el mayor dígito.
18. Leer un número entero de tres dígitos y determinar si algún dígito es múltiplo de los otros.
19. Leer tres números enteros y determinar cuál es el mayor. Usar solamente dos variables.
20. Leer tres números enteros y mostrarlos ascendentemente.La Esencia de la Lógica de Programación – Omar Ivan Trejos Buriticá
139
21. Leer tres números enteros de dos dígitos cada uno y determinar en cuál de ellos se encuentra
el mayor dígito.
22. Leer un número entero de tres dígitos y determinar si el primer dígito es igual al último.
23. Leer un número entero de tres dígitos y determinar cuántos dígitos primos tiene.
24. Leer un número entero de tres dígitos y determinar cuántos dígitos pares tiene.
25. Leer un número entero de tres dígitos y determinar si alguno de sus dígitos es igual a la suma
de los otros dos.
26. Leer un número entero de cuatro dígitos y determinar a cuanto es igual la suma de sus dígitos.
27. Leer un número entero de cuatro dígitos y determinar cuántos dígitos pares tiene.
28. Leer un número entero menor que 50 y positivo y determinar si es un número primo.
29. Leer un número entero de cinco dígitos y determinar si es un número capicúo. Ej. 15651,
59895.
30. Leer un número entero de cuatro dígitos y determinar si el segundo dígito es igual al penúltimo.
31. Leer un número entero y determina si es igual a 10.
32. Leer un número entero y determinar si es múltiplo de 7.
33. Leer un número entero y determinar si termina en 7.
34. Leer un número entero menor que mil y determinar cuántos dígitos tiene.
35. Leer un número entero de dos dígitos, guardar cada dígito en una variable diferente y luego
mostrarlas en pantalla.
36. Leer un número entero de 4 dígitos y determinar si tiene mas dígitos pares o impares.
37. Leer dos números enteros y determinar cuál es múltiplo de cuál.140
Capítulo 7 - Decisiones
38. Leer tres números enteros y determinar si el último dígito de los tres números es igual.
39. Leer tres números enteros y determina si el penúltimo dígito de los tres números es igual.
40. Leer dos números enteros y si la diferencia entre los dos es menor o igual a 10 entonces
mostrar en pantalla todos los enteros comprendidos entre el menor y el mayor de los números
leídos.
41. Leer dos números enteros y determinar si la diferencia entre los dos es un número primo.
42. Leer dos números enteros y determinar si la diferencia entre los dos es un número par.
43. Leer dos números enteros y determinar si la diferencia entre los dos es un número divisor
exacto de alguno de los dos números.
44. Leer un número entero de 4 dígitos y determinar si el primer dígito es múltiplo de alguno de los
otros dígitos.
45. Leer un número entero de 2 dígitos y si es par mostrar en pantalla la suma de sus dígitos, si es
primo y menor que 10 mostrar en pantalla su último dígito y si es múltiplo de 5 y menor que 30
mostrar en pantalla el primer dígito.
46. Leer un número entero de 2 dígitos y si terminar en 1 mostrar en pantalla su primer dígito, si
termina en 2 mostrar en pantalla la suma de sus dígitos y si termina en 3 mostrar en pantalla el
producto de sus dos dígitos.
47. Leer dos números enteros y si la diferencia entre los dos números es par mostrar en pantalla la
suma de los dígitos de los números, si dicha diferencia es un número primo menor que 10
entonces mostrar en pantalla el producto de los dos números y si la diferencia entre ellos
terminar en 4 mostrar en pantalla todos los dígitos por separado.
48. Leer un número entero y si es menor que 100 determinar si es primo.
49. Leer un número entero y si es múltiplo de 4 determinar si su último dígito es primo.
50. Leer un número entero y si es múltiplo de 4 mostrar en pantalla su mitad, si es múltiplo de 5
mostrar en pantalla su cuadrado y si es múltiplo e 6 mostrar en pantalla su primer dígito.
Asumir que el número no es mayor que 100.
        */
    }
}

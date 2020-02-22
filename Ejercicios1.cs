using System;

namespace esencia_logica
{
     class Ejercicios1:PadreEjercicios
    {

        /*
1. Leer un número entero y determinar si es un número terminado en 4.*/
    private void determinarTerminadoEn4(){
        Console.WriteLine("1. Leer un número entero y determinar si es un número terminado en 4.");
        int[] numero = gestionDeDatos.inputInt(1,0);
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
        int[] numero = gestionDeDatos.inputInt(1,0);
        int conteoDigitos =  libreria.contarDigitos(numero[0]);
        Console.WriteLine("tiene  {0} digitos ",conteoDigitos);
        if(libreria.determinarSiTiene(conteoDigitos,3)){
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
        int numero = gestionDeDatos.inputInt(1,0)[0];
        if( libreria.determinarSiEsNegativo(numero)){
            Console.WriteLine("El numero {0} si es negativo ",numero);
        }else{
            Console.WriteLine("El numero {0} no es negativo ",numero);
        }
    }
    public override void ejercicio3(){
        determinarSiEsNegativo();
    } 
/*
4. Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos.
*/
    private void cuantoEsIgualSumaDigitos(){
        Console.WriteLine("4. Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos.");
        int numero = gestionDeDatos.inputInt(1,2)[0];
        int[] digitos =  libreria.digitosDelNumero(numero);
        int sumaDeNumeros = libreria.sumar(digitos);
        Console.WriteLine("La suma de sus numeros es {0}",sumaDeNumeros);
    }
    public override void ejercicio4(){
        cuantoEsIgualSumaDigitos();
    }

/*
5. Leer un número entero de dos dígitos y determinar si ambos dígitos son pares.
6. Leer un número entero de dos dígitos menor que 20 y determinar si es primo.
7. Leer un número entero de dos dígitos y determinar si es primo y además si es negativo.
8. Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos.
9. Leer un número entero de dos dígitos y determinar si un dígito es múltiplo del otro.
10. Leer un número entero de dos dígitos y determinar si los dos dígitos son iguales.
11. Leer dos números enteros y determinar cuál es el mayor.
12. Leer dos números enteros de dos dígitos y determinar si tienen dígitos comunes.
13. Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina
un número par.
14. Leer dos números enteros de dos dígitos y determinar a cuánto es igual la suma de todos los
dígitos.
15. Leer un número entero de tres dígitos y determinar a cuánto es igual la suma de sus dígitos.
16. Leer un número entero de tres dígitos y determinar si al menos dos de sus tres dígitos son
iguales.
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

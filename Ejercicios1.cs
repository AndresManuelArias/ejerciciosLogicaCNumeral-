using System;
using System.Collections.Generic;
using System.Linq;



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
            int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(3))[0]; 
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
17. Leer un número entero de tres dígitos y determinar en qué posición está el mayor dígito.*/
    public override void ejercicio17(){
        Console.WriteLine("17. Leer un número entero de tres dígitos y determinar en qué posición está el mayor dígito.");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(3))[0]; 
        int[] digitos = libreria.digitosDelNumero(numero);
        int numeroMayor = libreria.encontrarNumeroMayor(digitos);
        int indiceNumeroMayor = libreria.finIndex(digitos,(digito)=> digito ==numeroMayor);
        Console.WriteLine($"Indice numero mayor es {indiceNumeroMayor}");

    }
/*
18. Leer un número entero de tres dígitos y determinar si algún dígito es múltiplo de los otros.*/
    public override void ejercicio18(){
        Console.WriteLine("18. Leer un número entero de tres dígitos y determinar si algún dígito es múltiplo de los otros.");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(3))[0]; 
        int[] digitos = libreria.digitosDelNumero(numero);
        int multipoDelOtro = libreria.minimoComunMultiplo(digitos);
        Console.WriteLine("minimoComunMultiplo:"+multipoDelOtro);
        if(libreria.some(digitos,(numero)=> numero==multipoDelOtro)){
            Console.WriteLine("Un numero es multiplo del otro");
        }else{
            Console.WriteLine("Ningun numero es multiplo del otro");
        }
    }
/*
19. Leer tres números enteros y determinar cuál es el mayor. Usar solamente dos variables.*/
    public override void ejercicio19(){
        Console.WriteLine("19. Leer tres números enteros y determinar cuál es el mayor. Usar solamente dos variables.");
        int[] numeros = gestionDeDatos.inputInt(3); 
        int numeroMayor =  libreria.encontrarNumeroMayor(numeros);
        Console.WriteLine("Numero mayor es "+numeroMayor);
    }
 /*
20. Leer tres números enteros y mostrarlos ascendentemente.*/
    public override void ejercicio20(){
        Console.WriteLine("20. Leer tres números enteros y mostrarlos ascendentemente.");
        int[] numeros = gestionDeDatos.inputInt(3);
        Array.Sort(numeros);
        Console.WriteLine( "numeros ordenados");
        libreria.DisplayValues(numeros);
    }

/*
21. Leer tres números enteros de dos dígitos cada uno y determinar en cuál de ellos se encuentra el mayor dígito.*/
    public override void ejercicio21(){
        Console.WriteLine("21. Leer tres números enteros de dos dígitos cada uno y determinar en cuál de ellos se encuentra el mayor dígito.");
        int[] numeros = gestionDeDatos.inputInt(3,gestionDeDatos.numeroContieneEstosDigitos(2));
        int[][] todosDigitos = libreria.mapConvertir(numeros,(numero)=> libreria.digitosDelNumero(numero) );
        int[] reducer = libreria.reduce(todosDigitos,(acumulado, digitos)=> acumulado.Concat(digitos).ToArray());
        libreria.DisplayValues(reducer);
        int numeroMayor =  libreria.encontrarNumeroMayor(reducer);
        int quienTieneDigitoMayor =  libreria.fin(numeros,(numero)=>libreria.some(libreria.digitosDelNumero(numero),(digito)=>digito == numeroMayor));
        Console.WriteLine($"el que tiene el digito mayor es {quienTieneDigitoMayor}");
    }
/*
22. Leer un número entero de tres dígitos y determinar si el primer dígito es igual al último.*/
    public override void ejercicio22(){
        Console.WriteLine("22. Leer un número entero de tres dígitos y determinar si el primer dígito es igual al último.");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(3))[0];
        int[] digito = libreria.digitosDelNumero(numero);
        if(digito[0] == digito[2]){
            Console.WriteLine("Los numero son iguales.");
        }else{
            Console.WriteLine("Los numero son diferentes.");

        }
    }

/*
23. Leer un número entero de tres dígitos y determinar cuántos dígitos primos tiene.*/
    public override void ejercicio23(){
        Console.WriteLine("23. Leer un número entero de tres dígitos y determinar cuántos dígitos primos tiene.");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(3))[0];
        int[] digitos = libreria.digitosDelNumero(numero);
        int conteoPrimos = libreria.countIf(digitos, libreria.saberSiEsPrimo);
        Console.WriteLine($"el numero {numero} tiene {conteoPrimos} digitos primos");
    }
/*
24. Leer un número entero de tres dígitos y determinar cuántos dígitos pares tiene.*/
    public override void ejercicio24(){
         Console.WriteLine("24. Leer un número entero de tres dígitos y determinar cuántos dígitos pares tiene.");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(3))[0];
        int[] digitos = libreria.digitosDelNumero(numero);
        int conteoPares = libreria.countIf(digitos, libreria.numeroEsPar);
        Console.WriteLine($"el numero {numero} tiene {conteoPares} digitos pares");       
    }
/*
25. Leer un número entero de tres dígitos y determinar si alguno de sus dígitos es igual a la suma de los otros dos.*/
    public override void ejercicio25(){
         Console.WriteLine("25. Leer un número entero de tres dígitos y determinar si alguno de sus dígitos es igual a la suma de los otros dos.");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(3))[0];
        int[] digitos = libreria.digitosDelNumero(numero);
        if(libreria.some(digitos,(digito,indice)=>libreria.sumarSi(digitos, (d,i)=> i!=indice)==digito)){
            Console.WriteLine($"un digito es la suma de los otros digitos");       
        }else{
            Console.WriteLine($"ningun digito es la suma de los otros digitos");       
        }
    }
/*
26. Leer un número entero de cuatro dígitos y determinar a cuanto es igual la suma de sus dígitos.*/
    public override  void ejercicio26(){
        Console.WriteLine("26. Leer un número entero de cuatro dígitos y determinar a cuanto es igual la suma de sus dígitos.");
        int[] numeros = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(4));
        int[][] grupoDigitos = libreria.mapConvertir(numeros,(numero)=>libreria.digitosDelNumero(numero));
        int sumarDigitos = libreria.sumar(grupoDigitos);
        Console.WriteLine($"La suma de sus digitos es {sumarDigitos}"); 
    }
/*
27. Leer un número entero de cuatro dígitos y determinar cuántos dígitos pares tiene.*/
    public override void ejercicio27(){
        Console.WriteLine("27. Leer un número entero de cuatro dígitos y determinar cuántos dígitos pares tiene.");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(4))[0];
        int[] digitos = libreria.digitosDelNumero(numero);
        int conteoPares = libreria.countIf(digitos, libreria.numeroEsPar);
        Console.WriteLine($"el numero {numero} tiene {conteoPares} digitos pares");
    }
/*
28. Leer un número entero menor que 50 y positivo y determinar si es un número primo.*/
    public override void ejercicio28(){
        Console.WriteLine("28. Leer un número entero menor que 50 y positivo y determinar si es un número primo.");
        int numero = gestionDeDatos.inputInt(1,(numero)=>numero>=0 && numero<=50)[0];
        if(libreria.saberSiEsPrimo(numero)){
            Console.WriteLine("El numero es primo");
        }else{
            Console.WriteLine("El numero no es primo");
        }
    }
/*
29. Leer un número entero de cinco dígitos y determinar si es un número capicúo. Ej. 15651,59895.*/
    public override void ejercicio29(){
        Console.WriteLine("29. Leer un número entero de cinco dígitos y determinar si es un número capicúo. Ej. 15651,59895");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(5))[0];
        int[] digitos = libreria.digitosDelNumero(numero);
        int cantidadDigitos = digitos.Length-1;
        if(libreria.every(digitos,(digito)=>digito==digitos[cantidadDigitos--])){
            Console.WriteLine("El numero es capicúo");
        }else{
            Console.WriteLine("El numero no es capicúo");
        }
    }
/*
30. Leer un número entero de cuatro dígitos y determinar si el segundo dígito es igual al penúltimo.*/
    public override void ejercicio30(){
        Console.WriteLine("30. Leer un número entero de cuatro dígitos y determinar si el segundo dígito es igual al penúltimo.");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(4))[0];
        int[] digitos = libreria.digitosDelNumero(numero);
        int cantidadDigitos = digitos.Length-1; 
        if(digitos[1]==digitos[cantidadDigitos-1]){
            Console.WriteLine("El segundo digito es igual al penuntimo.");
        }else{
            Console.WriteLine("El segundo digito no es igual al penuntimo.");
        }
    }
/*

31. Leer un número entero y determina si es igual a 10.*/
    public override void ejercicio31(){
        Console.WriteLine("31. Leer un número entero y determina si es igual a 10.");
        int numero = gestionDeDatos.inputInt(1)[0];
        String resultado = numero==10?"igual a diez":"no es igual a diez";
        Console.WriteLine($"el numero ingresado {resultado}");
      
    }

/*
32. Leer un número entero y determinar si es múltiplo de 7.*/
    public override void ejercicio32(){
        Console.WriteLine("32. Leer un número entero y determinar si es múltiplo de 7.");
        int numero = gestionDeDatos.inputInt(1)[0];
        String resultado = numero%7==0?"es multiplo de 7":"no es multiplo de 7";
        Console.WriteLine($"el numero ingresado {resultado}");
      
    }
/*
33. Leer un número entero y determinar si termina en 7.*/
    public override void ejercicio33(){
        Console.WriteLine("33. Leer un número entero y determinar si termina en 7.");
        int numero = gestionDeDatos.inputInt(1)[0];
        int[] digitos = libreria.digitosDelNumero(numero);
        String resultado = digitos[0] == 7?"termina en 7":"no termina en 7";
        Console.WriteLine($"el numero ingresado {resultado}");
      
    }
/*
34. Leer un número entero menor que mil y determinar cuántos dígitos tiene.*/
    public override void ejercicio34(){
        Console.WriteLine("34. Leer un número entero menor que mil y determinar cuántos dígitos tiene.");
        int numero = gestionDeDatos.inputInt(1,(n)=> n<1000 &&  n>=0)[0];
        int[] digitos = libreria.digitosDelNumero(numero);
        int numeroDigitos = digitos.Length;
        Console.WriteLine($"el numero ingresado tiene {numeroDigitos} digitos");
      
    }
/*
35. Leer un número entero de dos dígitos, guardar cada dígito en una variable diferente y luego
mostrarlas en pantalla.*/
    public override void ejercicio35(){
        Console.WriteLine("35. Leer un número entero de dos dígitos, guardar cada dígito en una variable diferente y luego mostrarlas en pantalla.");
        int[] numeros = gestionDeDatos.inputInt(2);
        foreach (int numero in numeros)
        {
            int[] digitos = libreria.digitosDelNumero(numero);
            Console.WriteLine("Los digitos del numero son");
            libreria.DisplayValues(digitos);
        }
      
    }
/*
36. Leer un número entero de 4 dígitos y determinar si tiene mas dígitos pares o impares.*/
    public override void ejercicio36(){     
        Console.WriteLine("36. Leer un número entero de 4 dígitos y determinar si tiene mas dígitos pares o impares.");
        int numero = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(4))[0];
        int[] digitos = libreria.digitosDelNumero(numero);
        int contarPares = libreria.countIf(digitos,(digito)=> libreria.numeroEsPar(digito));
        int contarImpares = libreria.countIf(digitos,(digito)=> !libreria.numeroEsPar(digito));
        if(contarPares > contarImpares ){
            Console.WriteLine("contiene mas pares que impares");
        }else if(contarPares < contarImpares ){
            Console.WriteLine("contiene mas impares que pares");
        }else{
            Console.WriteLine("Contiene la misma cantidad de pares e impares");
        }
    }
/*
37. Leer dos números enteros y determinar cuál es múltiplo de cuál.*/
    public override void ejercicio37(){     
        Console.WriteLine("37. Leer dos números enteros y determinar cuál es múltiplo de cuál.");
        int[] numero = gestionDeDatos.inputInt(2);
        if(numero[0]%numero[1] == 0){
            Console.WriteLine($"El numero {numero[0]} es multiplo de el numero {numero[1]}.");
        }else if(numero[1]%numero[0] == 0){
            Console.WriteLine($"El numero {numero[1]} es multiplo de el numero {numero[0]}.");
        }
    }
 /*
38. Leer tres números enteros y determinar si el último dígito de los tres números es igual.*/
    public override void ejercicio38(){     
        Console.WriteLine("38. Leer tres números enteros y determinar si el último dígito de los tres números es igual.");
        int[] numeros = gestionDeDatos.inputInt(3);
        int ultimoDigito = libreria.digitosDelNumero(numeros[0])[0];
        if(libreria.every(numeros,(numero)=> libreria.digitosDelNumero(numero)[0] == ultimoDigito)){
            Console.WriteLine("El ultimo de digito de los tres digitos es igual");
        }else{
            Console.WriteLine("El ultimo de digito de los tres digitos no es igual");
        }
    }
/*
39. Leer tres números enteros y determina si el penúltimo dígito de los tres números es igual.*/ 
    public override void ejercicio39(){     
        Console.WriteLine("39. Leer tres números enteros y determina si el penúltimo dígito de los tres números es igual.");
        int[] numeros = gestionDeDatos.inputInt(3);
        int cantidadDigitos = libreria.digitosDelNumero(numeros[0]).Length;
        int penUltimoDigito = libreria.digitosDelNumero(numeros[0])[cantidadDigitos>1?1:0];
        if(libreria.every(numeros,(numero)=> 
            libreria.digitosDelNumero(numero)[libreria.digitosDelNumero(numeros[0]).Length>1?1:0] == penUltimoDigito)){
            Console.WriteLine("El penultimo de digito de los tres digitos es igual");
        }else{
            Console.WriteLine("El penultimo de digito de los tres digitos no es igual");
        }
    }
/*
40. Leer dos números enteros y si la diferencia entre los dos es menor o igual a 10 entonces
mostrar en pantalla todos los enteros comprendidos entre el menor y el mayor de los números
leídos.*/
    public override void ejercicio40(){     
        Console.WriteLine("40. Leer dos números enteros y si la diferencia entre los dos es menor o igual a 10 entonces mostrar en pantalla todos los enteros comprendidos entre el menor y el mayor de los números leídos.");
        int[] numeros = gestionDeDatos.inputInt(2);
        int diferencia = Math.Abs(numeros[0]-numeros[1]);
        if(diferencia <= 10){
            int menor = libreria.reduce(numeros,Math.Min);
            int mayor = libreria.reduce(numeros,Math.Max);
            for ( ; menor <= mayor; menor++)
            {
                Console.WriteLine("imprimiendo "+menor);
            }
        }
    }
/*
41. Leer dos números enteros y determinar si la diferencia entre los dos es un número primo.*/
    public override void ejercicio41(){     
        Console.WriteLine("41. Leer dos números enteros y determinar si la diferencia entre los dos es un número primo.");
        int[] numeros = gestionDeDatos.inputInt(2);
        int diferencia =  Math.Abs(numeros[0]-numeros[1]);
        string resultado =  libreria.saberSiEsPrimo(diferencia)?$"la diferencia {diferencia} es un numero primo":$"la diferencia {diferencia} no es un numero primo";
        Console.WriteLine(resultado);
    }
/*
42. Leer dos números enteros y determinar si la diferencia entre los dos es un número par.*/
    public override void ejercicio42(){     
        Console.WriteLine("42. Leer dos números enteros y determinar si la diferencia entre los dos es un número par.");
        int[] numeros = gestionDeDatos.inputInt(2);
        int diferencia =  Math.Abs(numeros[0]-numeros[1]);
        string resultado =  libreria.numeroEsPar(diferencia)?$"la diferencia {diferencia} es un numero par":$"la diferencia {diferencia} no es un numero par";
        Console.WriteLine(resultado);
    }
/*43. Leer dos números enteros y determinar si la diferencia entre los dos es un número divisor
exacto de alguno de los dos números.*/
    public override void ejercicio43(){     
        Console.WriteLine("43. Leer dos números enteros y determinar si la diferencia entre los dos es un número divisor exacto de alguno de los dos números.");
        int[] numeros = gestionDeDatos.inputInt(2);
        int diferencia =  Math.Abs(numeros[0]-numeros[1]);
        string resultado =  libreria.some(numeros,(numero)=> numero==diferencia)?$"la diferencia {diferencia} es un multiplo de alguno de los dos números":$"la diferencia {diferencia} no es un multiplo de alguno de los dos números";
        Console.WriteLine(resultado);
    }
/*
44. Leer un número entero de 4 dígitos y determinar si el primer dígito es múltiplo de alguno de los
otros dígitos.*/
    public override void ejercicio44(){
        Console.WriteLine("44. Leer un número entero de 4 dígitos y determinar si el primer dígito es múltiplo de alguno de los otros dígitos.");
        int[] numeros = gestionDeDatos.inputInt(2,gestionDeDatos.numeroContieneEstosDigitos(4)); 
        int[][] grupoDigitos = libreria.mapConvertir(numeros,(numero)=>libreria.digitosDelNumero(numero).Reverse().ToArray());
        int [] digitos = libreria.reduce(grupoDigitos,(numeros1,numeros2)=> numeros1.Concat(numeros2).ToArray());
        int primerDigito = digitos[0];
        int[] digitosSinPrimerNumero = digitos.Skip(1).ToArray();
        libreria.DisplayValues(digitosSinPrimerNumero);
        if(Array.Exists(digitosSinPrimerNumero,(numero)=> numero%primerDigito==0)){
            Console.WriteLine($"el primer digito {primerDigito} es multiplo del otro");
        }else{
            Console.WriteLine($"el primer digito {primerDigito} no es multiplo del otro");
        }
    }
/*

45. Leer un número entero de 2 dígitos y si es par mostrar en pantalla la suma de sus dígitos, si es
primo y menor que 10 mostrar en pantalla su último dígito y si es múltiplo de 5 y menor que 30
mostrar en pantalla el primer dígito.*/
    public override void ejercicio45(){
        Console.WriteLine("45. Leer un número entero de 2 dígitos y si es par mostrar en pantalla la suma de sus dígitos, si es primo y menor que 10 mostrar en pantalla su último dígito y si es múltiplo de 5 y menor que 30 mostrar en pantalla el primer dígito.");
        int[] numeros = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(2)); 
        int[] digitos = libreria.digitosDelNumero(numeros[0]).Reverse().ToArray();        
        if(Array.TrueForAll(numeros,libreria.numeroEsPar)){
            Console.WriteLine($"La suma de sus digitos es {digitos.Sum()}");
        }else if(Array.TrueForAll(numeros,(numero)=>libreria.saberSiEsPrimo(numero)&&numero<10)){
            Console.WriteLine($"su ultimo digito es {digitos[digitos.Length-1]}");
        }else if(Array.TrueForAll(numeros,(numero)=> numero%5 ==0 &&numero<30))
        {
            // es múltiplo de 5 y menor que 30 mostrar en pantalla el primer dígito
            Console.WriteLine($"su primer digito es {digitos[0]}");
        }
    }
/*46. Leer un número entero de 2 dígitos y si terminar en 1 mostrar en pantalla su primer dígito, si
termina en 2 mostrar en pantalla la suma de sus dígitos y si termina en 3 mostrar en pantalla el
producto de sus dos dígitos.*/
    public override void ejercicio46(){
        Console.WriteLine("46. Leer un número entero de 2 dígitos y si terminar en 1 mostrar en pantalla su primer dígito, si termina en 2 mostrar en pantalla la suma de sus dígitos y si termina en 3 mostrar en pantalla el producto de sus dos dígitos.");
        int[] numeros = gestionDeDatos.inputInt(1,gestionDeDatos.numeroContieneEstosDigitos(2));
        int[][] grupoDigitos = numeros.Select(numero => libreria.digitosDelNumero(numero).Reverse().ToArray()).ToArray();
        foreach(int[] digito in grupoDigitos){
            libreria.DisplayValues(digito);
            switch (digito[digito.Length-1])
            {               
                case 1:
                    Console.WriteLine($"Su primer digito es {digito[0]}");
                break;
                case 2:
                    Console.WriteLine($"La suma de sus digitos es {digito.Sum()}");
                break;
                case 3:
                    Console.WriteLine($"El producto de sus digitos es {libreria.reduce(digito,(a,b)=>a*b) }");
                break;
                default:
                    Console.WriteLine($"Su ultimo digito es {digito[digito.Length-1]}");
                break;
            }
        }

    }
/*
47. Leer dos números enteros y si la diferencia entre los dos números es par mostrar en pantalla la
suma de los dígitos de los números, si dicha diferencia es un número primo menor que 10
entonces mostrar en pantalla el producto de los dos números y si la diferencia entre ellos
terminar en 4 mostrar en pantalla todos los dígitos por separado.
*/
    public override void ejercicio47(){
        Console.WriteLine("47. Leer dos números enteros y si la diferencia entre los dos números es par mostrar en pantalla la suma de los dígitos de los números, si dicha diferencia es un número primo menor que 10 entonces mostrar en pantalla el producto de los dos números y si la diferencia entre ellos terminar en 4 mostrar en pantalla todos los dígitos por separado.");
        int[] numeros = gestionDeDatos.inputInt(2);
        int diferencia = libreria.reduce(numeros,(a,b)=> Math.Abs(Math.Abs(a)-Math.Abs(b)));
        if(libreria.numeroEsPar(diferencia)){
            int[][] grupoDigitos = numeros.Select(numero => libreria.digitosDelNumero(numero).Reverse().ToArray()).ToArray();
            int sumaDigitos = libreria.sumar(grupoDigitos);
            Console.WriteLine($"La suma de sus digitos es {sumaDigitos}");
        }
        if(libreria.saberSiEsPrimo(diferencia) && diferencia < 10){
            Console.WriteLine($"El producto de sus numeros es {libreria.reduce(numeros,(a,b)=>a*b) }");
        }
        if(diferencia%10==4){
            int[] digitos = libreria.digitosDelNumero(diferencia);
            libreria.DisplayValues(digitos);
        }   

    }
/*48. Leer un número entero y si es menor que 100 determinar si es primo.
49. Leer un número entero y si es múltiplo de 4 determinar si su último dígito es primo.
50. Leer un número entero y si es múltiplo de 4 mostrar en pantalla su mitad, si es múltiplo de 5
mostrar en pantalla su cuadrado y si es múltiplo e 6 mostrar en pantalla su primer dígito.
Asumir que el número no es mayor que 100.
        */
    }
}

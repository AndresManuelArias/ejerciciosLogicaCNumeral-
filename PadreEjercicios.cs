using System;

namespace esencia_logica
{
    public abstract class  PadreEjercicios
    {
        public GestionDeDatos gestionDeDatos = new GestionDeDatos();
        public Libreria libreria = new Libreria();
        public VistaTemplate vistaTemplate = new VistaTemplate();
        public void menu(){
            bool noPasar = false;
            do {
                noPasar = false;
                Console.WriteLine("Seleccione un ejercicio escribiendo un numero del 1 al 50");
                int numeroEscrito = Convert.ToInt32(Console.ReadLine());

                switch (numeroEscrito)
                {
                    case 1:
                        ejercicio1();
                    break;
                    case 2:
                        ejercicio2();
                    break;
                    case 3:
                        ejercicio3();
                    break;
                    case 4:
                        ejercicio4();
                    break;
                    case 5:
                        ejercicio5();
                    break; 
                    case 6:
                        ejercicio6();
                    break;  
                    case 7:
                        ejercicio7();
                    break; 
                    case 8:
                        ejercicio8();
                    break;
                    case 9:
                        ejercicio9();
                    break;  
                    case 10:
                        ejercicio10();
                    break;
                    case 11:
                        ejercicio11();
                    break;
                    case 12:
                        ejercicio12();
                    break; 
                    case 13:
                        ejercicio13();
                    break; 
                    case 14:
                        ejercicio14();
                    break;
                    case 15:
                        ejercicio15();
                    break;   
                    case 16:
                        ejercicio16();
                    break;   
                    case 17:
                        ejercicio17();
                    break;
                    case 18:
                        ejercicio18();
                    break;
                    case 19:
                        ejercicio19();
                    break;  
                    case 20:
                        ejercicio20();
                    break;  
                    case 21:
                        ejercicio21();
                    break;
                    case 22:
                        ejercicio22();
                    break; 
                    case 23:
                        ejercicio23();
                    break;  
                    case 24:
                        ejercicio24();
                    break;  
                    case 25:
                        ejercicio25();
                    break;  
                    case 26:
                        ejercicio26();
                    break;  
                    case 27:
                        ejercicio27();
                    break;  
                    case 28:
                        ejercicio28();
                    break;
                    case 29:
                        ejercicio29();
                    break;
                    case 30:
                        ejercicio30();
                    break; 
                    case 31:
                        ejercicio31();
                    break;  
                    case 32:
                        ejercicio32();
                    break; 
                    case 33:
                        ejercicio33();
                    break;
                    case 34:
                        ejercicio34();
                    break; 
                    case 35:
                        ejercicio35();
                    break; 
                    case 36:
                        ejercicio36();
                    break;
                    case 37:
                        ejercicio37();
                    break; 
                    case 38:
                        ejercicio38();
                    break; 
                    case 39:
                        ejercicio39();
                    break;
                    case 40:
                        ejercicio40();
                    break;   
                    default:
                        Console.WriteLine("El dato escrito no se encuentra en la lista");
                        noPasar = true;
                    break;
                }
            }while(noPasar);
        }
        public abstract void ejercicio1();
        public abstract void ejercicio2();
        public abstract void ejercicio3();
        public abstract void ejercicio4();
        public abstract void ejercicio5();
        public abstract void ejercicio6();
        public abstract void ejercicio7();
        public abstract void ejercicio8();
        public abstract void ejercicio9();
        public abstract void ejercicio10();
        public abstract void ejercicio11();
        public abstract void ejercicio12();
        public abstract void ejercicio13();
        public abstract void ejercicio14();
        public abstract void ejercicio15();
        public abstract void ejercicio16();
        public abstract void ejercicio17();
        public abstract void ejercicio18();
        public abstract void ejercicio19();
        public abstract void ejercicio20();
        public abstract void ejercicio21();
        public abstract void ejercicio22();
        public abstract void ejercicio23();
        public abstract void ejercicio24();
        public abstract void ejercicio25();
        public abstract void ejercicio26();
        public abstract void ejercicio27();
        public abstract void ejercicio28();
        public abstract void ejercicio29();
        public abstract void ejercicio30();
        public abstract void ejercicio31();
        public abstract void ejercicio32();
        public abstract void ejercicio33();
        public abstract void ejercicio34();
        public abstract void ejercicio35();
        public abstract void ejercicio36();
        public abstract void ejercicio37();
        public abstract void ejercicio38();
        public abstract void ejercicio39();
        public abstract void ejercicio40();

    }
}

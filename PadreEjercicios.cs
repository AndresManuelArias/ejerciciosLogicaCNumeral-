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

    }
}

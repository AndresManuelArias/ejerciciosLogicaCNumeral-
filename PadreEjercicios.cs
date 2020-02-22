using System;

namespace esencia_logica
{
    public abstract class  PadreEjercicios
    {
        public GestionDeDatos gestionDeDatos = new GestionDeDatos();
        public Libreria libreria = new Libreria();
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

    }
}

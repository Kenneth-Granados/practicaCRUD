using System;

namespace Fundamentos
{
    public class TablaMult
    {
        int [] valores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
        int mult;
        public void Menu(){
            try {int menu;
            do
            {
                Console.WriteLine("\tBienvenido");
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("1. Una tabla en especifico");
                Console.WriteLine("2. Todas las tablas");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                            PrimeraOpcion();  
                            // Salida();  
                        break;
                    case 2:
                            SegundaOpcion();
                            // Salida(); 
                        break;
                    default:
                            Console.WriteLine("Debe de seleccionar entre las opciones presentadas");
                        break;
                }
                
            } while (Salida() != 2 );
            
            }catch (Exception e){
                    Console.WriteLine(e.Message);
            }
        }

        private int Salida(){
            int resp ;
            try
            {
                do{
                    
                    System.Console.WriteLine("\tDesea Continuar");
                    System.Console.WriteLine("1. Si");
                    System.Console.WriteLine("2. No");
                    resp = int.Parse(Console.ReadLine());
                    switch (resp)
                    {
                        case 1:
                            Console.WriteLine("Volvera al menu principal");
                            Menu();
                            break;
                        case 2:
                            Console.WriteLine("Adiós");
                            break;
                        default:
                            Console.WriteLine("Seleccione la opción correcta");
                            break;
                    }
                } while (resp != 2);

                return resp;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return resp = 0;
                
            }

        }


        private void PrimeraOpcion(){
            try {
            System.Console.WriteLine("Ingrese el valor de la  tabla que desea saber de 1 a 12");
            int num = int.Parse(Console.ReadLine());
            if ((Array.Exists(valores,x => x ==num )==true) )
            {
                
                for (int i = 0; i < valores.Length; i++)
                {
                    mult = valores[i] * num;
                    Console.WriteLine(valores[i] + " x " + num + " = "+mult);
                    // Console.Write("{0} x {1} = {3}",valores[i],num,mult);
                } 
            }
            } catch(FormatException ex){
                Console.WriteLine(ex.Message);

            }
        }

        private void SegundaOpcion(){
            for (int i = 0; i < valores.Length; i++)
            {
                
                for (int j = 1; j < 13; j++)
                {
                    mult = valores[i] * j;
                    // Console.Write("{0} x {1} = {3}",valores[i],j,mult);
                    Console.Write("|"+valores[i] + " x " + j + " = "+mult+"| ");
                    
                }
                Console.WriteLine("\n");
            }
            
        }

    }

}

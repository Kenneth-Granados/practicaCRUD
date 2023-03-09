using System;
using System.Diagnostics;

namespace Fundamentos
{
    class FechaPractica
    {
        public void CalculoSiglo( string fecha){
            Stopwatch sw = new Stopwatch();
            sw.Start();//Inicio medición
            string [] prueba = fecha.Split("/"); 
            int siglo = 0;
            int anio = int.Parse(prueba[2]);
            if ( anio % 100 == 0 )
            {
                siglo = anio / 100;
                Console.WriteLine("La fecha {0}, pertenece al siglo: {1}",fecha,siglo);
            } else { 
                siglo = (anio / 100) + 1 ;
                Console.WriteLine("La fecha {0}, pertenece al siglo: {1}",fecha,siglo); 
            }
            sw.Stop();
            Console.WriteLine("Tiempo = {0}",sw.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));
        }
    
        public void CalculoEntero(int [] arreglo){
            int mult = 0 , mult1 = 0 , mult2 = 0;

            for (int i = 0; i < arreglo.Length -1; i++)
            {
                if ( (arreglo[i] * arreglo[i+1] > mult ) )
                {
                    mult = arreglo[i] * arreglo[i+1];
                    mult1 = arreglo[i]; 
                    mult2 = arreglo[i+1];
                }
            }
            Console.WriteLine($"Los valores {mult1} y {mult2} producen el producto más grande el cual es: {mult}");
        }

        public void CalculoDecimal( int num){
            decimal resultado = 0;
            //string valor = "", fin = "";

            resultado = (decimal) Math.Pow( (3 + (Math.Sqrt(5))), num);
            System.Console.WriteLine(resultado);
            string [] separacion = resultado.ToString().Split(",");
            if (separacion[0].Length < 3)
            {
                // valor = "0" + separacion[0];
                // System.Console.WriteLine(valor + " if");
                separacion[0] = "0" + separacion[0];
                System.Console.WriteLine(separacion[0] + " if");
            } else {
                // valor = separacion[0];
                // System.Console.WriteLine(valor + " else");
                separacion[0] = separacion[0].Substring(separacion[0].Length - 3,3);
                System.Console.WriteLine(separacion[0] + " else");
            }

            // fin = (valor.Substring((valor.Length - 3), 3) );
            // System.Console.WriteLine(fin);
            // separacion[1] = separacion[1].Substring(2);
            // System.Console.WriteLine(separacion[1]);
        }


    }
}

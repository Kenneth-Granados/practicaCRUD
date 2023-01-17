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
    }
}

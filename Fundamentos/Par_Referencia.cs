using System;

namespace Fundamentos
{
    public class Par_Referencia
    {
        public int Agregar(int j){//se guarda una copia 
        j++;
        System.Console.WriteLine("Normal");
        return j;
       } 
        public int Agregar2(ref int j){//la valor de la variable se actualizara
        j++;
        System.Console.WriteLine("Referencia: ref tiene que estar inicializada primero");
        return j;
       } 
        public int Agregar3(out int j){// siempre se reiniciara la variable
        j=0;
        j++;
        System.Console.WriteLine("Referencia: out se inicializa en el metodo");
        return j;
       } 
        public int SumaParametros(params int[] numeros){// siempre se reiniciara la variable
        if (numeros.Length < 2 || numeros == null)
        {
            throw new ArgumentException("Se deben ingresar más de 2 valores");
        } else
        {
            int suma = 0;
            foreach (var numero in numeros)
            {
                suma += numero;
            }
            return suma;
        }
       } 
    }
}

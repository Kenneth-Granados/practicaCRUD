using System;

namespace Fundamentos
{
    public class Cadenas
    {
        public void Ejemplo1(){
            string oracion = "This sentence has five words.";
            // Extract the second word.
            int posicionInicial = oracion.IndexOf(" ") + 1;
            string palabra2 = oracion.Substring(posicionInicial,
                                            oracion.IndexOf(" ", posicionInicial) - posicionInicial);
            Console.WriteLine("Second word: " + palabra2);
            // The example displays the following output:
            //       Second word: sentence
        }

        public void Ejemplo2(){//Este código busca espacios en blanco o caracteres de puntuación en una cadena para determinar cuántas palabras contiene la cadena.
            string s1 = "This string consists of a single short sentence.";
            int nWords = 0;

            s1 = s1.Trim();      
            for (int ctr = 0; ctr < s1.Length; ctr++) {
            if (Char.IsPunctuation(s1[ctr]) | Char.IsWhiteSpace(s1[ctr]))
                nWords++;              
            }
            Console.WriteLine("The sentence\n   {0}\nhas {1} words.",
                            s1, nWords);      
            //Forma 2
            // s1 = s1.Trim();      
        // foreach (var ch in s1) {
        //    if (Char.IsPunctuation(ch) | Char.IsWhiteSpace(ch))
        //       nWords++;              
        // }
        // Console.WriteLine("The sentence\n   {0}\nhas {1} words.",
        //                   s1, nWords);                                                               
            // The example displays the following output:
            //       The sentence
            //          This string consists of a single short sentence.
            //       has 8 words.
        }
    
        public void Ejemplo3(string cadena){

            var palabras = cadena.Split(" ");
            Console.WriteLine("La oración : {0} , contiene {1} palabras.\nLas cuales son: ",cadena,palabras.Length);
            foreach (var palabra in palabras)
            {
                Console.WriteLine(palabra);
            } 

        }

    }

}

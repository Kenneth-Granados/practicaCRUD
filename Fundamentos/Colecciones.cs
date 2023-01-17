using System;
using System.Collections.Generic;

namespace Fundamentos
{
    class Colecciones//Genericas
    {
        public void Listas(){
            List<int> numerosList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
              numerosList.Add(i);  
            }

            numerosList.Insert(numerosList.Count - 1, 50); //añade un dato en sierta posición
            numerosList.Remove(3);//elimina el dato especificado
            numerosList.RemoveAt(0);//elimina el dato que se encuentre en dicha posición
            numerosList.RemoveRange(0,3);//elimina la cantidad de datos(3) que se encuentre apartir del indice(0)

            foreach (var item in numerosList)
            {
                Console.WriteLine(item);
            }
        }
        
        public void ListasLink(){
            LinkedList<int> numeros = new LinkedList<int>();
            
            for (int i = 1; i <= 10; i++)
            {
                //numeros.AddLast(i);//agrega al final de la lista
                numeros.AddFirst(i);//agrega al inicio de la lista

            }

            var primero = numeros.AddFirst(300);

            numeros.AddAfter(primero,200);//agrega despues del nodo(primero) el dato(200)
            numeros.AddBefore(primero,400);//agrega antes del nodo(primero) el dato(200)

            var nodo = numeros.First;
            
            while (nodo != null)
            {
                System.Console.WriteLine(nodo.Value);
                nodo = nodo.Next;
            }

            for (var nodo2 = numeros.Last; nodo2 != null; nodo2 = nodo2.Previous)
            {
                System.Console.WriteLine(nodo2.Value);
            }

            numeros.Remove(3);//elimina todos los numeros (3)
            numeros.RemoveFirst();//elimina el primer elemento
            numeros.RemoveLast();//elimina el último elemento


            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

        }

        public void Cola(){//primero en entrar primero en salir

        Queue<int> cola = new Queue<int>();

        for (int i = 1; i <= 10; i++)
        {
            cola.Enqueue(i);//encolar = agregar un dato
        }

        foreach (var item in cola)
        {
            System.Console.WriteLine(item);
        }

        var numero = cola.Dequeue();//desencola el primer elemento que se agrego
        System.Console.WriteLine("Extracción de numeros de la cola");
        while ( cola.Count > 0 )
        {
            numero = cola.Dequeue();
            System.Console.WriteLine(numero);
        }

        }

        public void Pila(){//primero en entrar último en salir
            Stack<int> cola = new Stack<int>();

            for (int i = 1; i <= 10; i++)
            {
                cola.Push(i);//apila = agregar un dato
            }

            foreach (var item in cola)
            {
                Console.WriteLine(item);
            }

            var numero = cola.Pop();//desapila el último elemento que se agrego
            System.Console.WriteLine("Extracción de numeros de la cola");
            while ( cola.Count > 0 )
            {
                numero = cola.Pop();
                System.Console.WriteLine(numero);
            }

        }
    
        public void Diccionario(){//colección llave, valor

            Dictionary<int,int> diccionario = new Dictionary<int, int>();

            for (int i = 1; i <= 10; i++)
            {
                diccionario.Add(i, i);
            }

            Dictionary<string,string> nombres = new Dictionary<string, string>();
            nombres.Add("PP","Primera Prueba");
            nombres.Add("SP","Segunda Prueba");

            foreach (var item in nombres)
            {
                string clave = item.Key;
                string nombre = item.Value;
                System.Console.WriteLine("La clave es: {0} y la nombre es: {1}",clave,nombre);
            }
            System.Console.WriteLine();

            nombres["PP"] = "Cambio prueba";//haciendo un cambio del valor mediantes la llave
            foreach (var item in nombres)
            {
                string clave = item.Key;
                string nombre = item.Value;
                System.Console.WriteLine("La clave es: {0} y la nombre es: {1}",clave,nombre);
            }
            Console.ReadLine();
        }

        public void ListaOrdenada(){

            SortedList<string,string> nombres = new SortedList<string, string>();
            nombres.Add("K","Kenneth");
            nombres.Add("A","Ashley");
            nombres.Add("E","Evelin");


            foreach (var item in nombres)
            {
                string clave = item.Key;
                string nombre = item.Value;
                System.Console.WriteLine("La clave es: {0} y la nombre es: {1}",clave,nombre);
            }
            
            Console.ReadLine();
        }
        public void ListaConjunto(){

            HashSet<string> lisenciatura1 = new HashSet<string>();
            lisenciatura1.Add("Cocina");
            lisenciatura1.Add("Negocios");
            lisenciatura1.Add("Programación");
            HashSet<string> lisenciatura2 = new HashSet<string>( new string[] {"Programción", "BD", "Software", "Cocina"});

            foreach (var item in lisenciatura1)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine();

            //lisenciatura1.IntersectWith(lisenciatura2);//comparación
            //lisenciatura1.UnionWith(lisenciatura2);
            lisenciatura1.ExceptWith(lisenciatura2);
            foreach (var item in lisenciatura1)
            {
                System.Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public void Extra(){
            List<Cliente> clientes = new List<Cliente>{
                new Cliente {
                    Id = 1,
                    Nombre = "Ashley"
                
                },
                new Cliente {
                    Id = 2,
                    Nombre = "Kenneth"
                
                },
                new Cliente {
                    Id = 3,
                    Nombre = "Evelin"
                }
            };
            //Applicando expresion lamda
            // var cliente = clientes.Find((Cliente c) =>{//evalua cada elemento de la coleccion y devuelve verdad y falso
            //     return c.Id == 3;
            // });
            var cliente = clientes.Find( c => c.Id == 3); //cuando se tiene una unica expresión y cuando se tiene un unico paramtro se puede omitir los parentesis y rl tipo de deto

            if ( cliente != null)
            {
                System.Console.WriteLine(cliente.Nombre);
            } else
            {
                System.Console.WriteLine("Cliente no existe");
            }
        }

        // Expresion lamda 
        // (){
        //     return 1;
        // }

    }

    class Cliente
    {
        public int Id{ get ;set ;}
        public string Nombre{ get ;set ;}

    }
}

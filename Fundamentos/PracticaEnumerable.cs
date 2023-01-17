using System;
using System.Collections;
using System.Collections.Generic;

namespace Fundamentos
{
    class ClienteManager : IEnumerable
    {
        List<Cliente> clientes;
        public ClienteManager()
        {
           clientes = new List<Cliente>(){
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
        }

        public IEnumerator GetEnumerator()
        {
            // return clientes.GetEnumerator();
            // return new ClienteEnumerator(clientes);
            foreach (var cliente in clientes)
            {
                yield return cliente;
            }

        }
    }

    class ClienteEnumerator : IEnumerator
    {
        int position = -1;
        List<Cliente> clientes = null;
        
        public ClienteEnumerator(List<Cliente> _clientes)
        {
            clientes = _clientes;
        }
        public object Current { 
            get
            {
                try
                {
                    return clientes[position];
                }catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
            }

        public bool MoveNext()
        {
            position++;
            return (position < clientes.Count);
        }

        public void Reset()
        {
           position = -1;
        }
    }

    class EnumercionEjemplo<T> : IEnumerable<T>
    {
        List<T> datos = new List<T>();

        public EnumercionEjemplo(params T [] _datos)
        {
            foreach (var dato in _datos)
            {
                datos.Add(dato);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var dato in datos)
            {
                yield return dato;//yield indica el valor que debe ser retornado en cada valor
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}

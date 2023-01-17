using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using System;

namespace Fundamentos
{
    class LINQ
    {
        public void Practica(){

            var estudiantes = new[]
            {
                new
                {
                    EstudianteID = 1,
                    Nombre = "Héctor",
                    ApellidoPaterno = "Pérez",
                    Universidad = "Real de Brasil"
                },
                new
                {
                    EstudianteID = 2,
                    Nombre = "Ana",
                    ApellidoPaterno = "Nepomuceno",
                    Universidad = "Oxford"
                },
                new
                {
                    EstudianteID = 3,
                    Nombre = "Pedro",
                    ApellidoPaterno = "Sánchez",
                    Universidad = "Harvard"
                },
                new
                {
                    EstudianteID = 4,
                    Nombre = "José",
                    ApellidoPaterno = "Infante",
                    Universidad = "Harvard"
                },
                new
                {
                    EstudianteID = 5,
                    Nombre = "Regina",
                    ApellidoPaterno = "Bustamante",
                    Universidad = "Oxford"
                },
                new
                {
                    EstudianteID = 6,
                    Nombre = "Rodrigo",
                    ApellidoPaterno = "Jiménez",
                    Universidad = "Brooklyn"
                },
                new
                {
                    EstudianteID = 7,
                    Nombre = "Miguel",
                    ApellidoPaterno = "Hernández",
                    Universidad = "UNAM"
                },
                new
                {
                    EstudianteID = 8,
                    Nombre = "Marilyn",
                    ApellidoPaterno = "Monroe",
                    Universidad = "UNAM"
                },
                new
                {
                    EstudianteID = 9,
                    Nombre = "Leonardo",
                    ApellidoPaterno = "Estrada",
                    Universidad = "Brooklyn"
                },
                new
                {
                    EstudianteID = 10,
                    Nombre = "Ricardo",
                    ApellidoPaterno = "Rojas",
                    Universidad = "Real de Brasil"
                },
            };

            var universidades = new[]
            {
                new
                {
                    Universidad = "Real de Brasil",
                    Ciudad = "Brasilia",
                    Pais = "Brasil"
                },
                new
                {
                    Universidad = "Oxford",
                    Ciudad = "Oxford",
                    Pais = "Reino Unido"
                },
                new
                {
                    Universidad = "Harvard",
                    Ciudad = "Cambridge",
                    Pais = "Estados Unidos"
                },
                new
                {
                    Universidad = "Brooklyn",
                    Ciudad = "Nueva York",
                    Pais = "Estados Unidos"
                },
                new
                {
                    Universidad = "UNAM",
                    Ciudad = "Ciudad de México",
                    Pais = "México"
                },
            };
        
            // IEnumerable<string> nombreEstudiantes = 
            // estudiantes.Select(e => $"{e.Nombre} {e.ApellidoPaterno}" );
            // IEnumerable<NombreCompleto> nombreEstudiantes = 
            // estudiantes.Select(e => new NombreCompleto {
            //     Nombre = e.Nombre,
            //     Apellido = e.ApellidoPaterno
            // } );
            //porque la clase nombreCompleto no realiza muchas acciones
            // var nombreEstudiantes = 
            // estudiantes.Select(e => new {
            //     Nombre = e.Nombre,
            //     Apellido = e.ApellidoPaterno
            // } );

            var nombreEstudiantes = from nombres in estudiantes
                                    select new { nombres.Nombre, nombres.ApellidoPaterno};

            foreach (var nombre in nombreEstudiantes)
            {
                System.Console.WriteLine(nombre);
            }

            // var universidadesEU = universidades
            //     .Where(u => u.Pais == "Estados Unidos" )
            //     .Select(u => u.Universidad);

            var universidadesEU = from u in universidades //u es un alias
                                  where string.Equals(u.Pais,"Estados Unidos")
                                  select u.Universidad;
            foreach (var universidad in universidadesEU)
            {
                Console.WriteLine(universidad);
            }


            // IEnumerable<string> universidadesEU = universidades
            //         .OrderBy(u => u.Universidad)
            //         .OrderByDescending(u => u.Universidad)
            //         .ThenBy(u => u.Pais)//segundo valor para ordenar
            //         .Select(u => u.Universidad);
            // foreach (var universidad in universidadesEU)
            // {
            //     Console.WriteLine(universidad);
            // }

            var nombreUniversidades = from u in universidades
                                      orderby u.Universidad descending
                                      select u.Universidad;
            foreach (var universidad in nombreUniversidades)
            {
                Console.WriteLine(universidad);
            }
            // var universidadesPais = universidades
            //     .GroupBy(u => u.Pais);

             var universidadesPais = from u in universidades
                              group u by u.Pais;

            foreach (var grupo in universidadesPais)
            {
                Console.WriteLine($"Universidades: {grupo.Key} \t {grupo.Count()}");
                foreach (var universidad in grupo)
                {
                    Console.WriteLine($"\t {universidad.Universidad}");
                }
            }

            // int numUniversidades = universidades
            //     .Select(x => x.Universidad)
            //     .Count();
            // int numPaises = universidades.Select(x => x.Pais).Distinct().Count();
            int numUniversidades = (from u in universidades
                                   select u.Universidad).Count();
            int numPaises = (from u in universidades
                             select u.Pais).Distinct().Count();
            System.Console.WriteLine(numUniversidades);
            System.Console.WriteLine(numPaises);
            // var join = estudiantes 
            //     .Select(e => new {
            //         e.Nombre,
            //         e.ApellidoPaterno,
            //         e.Universidad
            //     }).Join(universidades, e => e.Universidad , u => u.Universidad,
            //             (e, u) => new { e.Nombre, e.ApellidoPaterno, u.Pais} );
            var join = from u in universidades
                       join e in estudiantes
                       on u.Universidad equals e.Universidad
                       select new { e.Nombre, e.ApellidoPaterno, u.Pais };

            foreach (var fila in join)
            {
                System.Console.WriteLine(fila);   
            }

            //var parte = estudiantes.Take(2);//obtine las primeras dos filas
            var parte = estudiantes.Skip(1).Take(2);//saltar el registro #1 | Skip
            foreach (var estudiante in parte)
            {
                System.Console.WriteLine(estudiante.Nombre);
            }
            var cualquiera = estudiantes.Any( x => x.Nombre.StartsWith("H"));//que cumpla con una coincidencia especifica en el ejemplo es que empicen con H gracias al metodo StartsWith y retorna un vlor booleano
            var Todos = estudiantes.All( x => x.Nombre != " ");//comprueba si todos los registros cumplen con la condición
            var primero = estudiantes.First(x => x.Nombre.StartsWith("H"));//devuelve el primer resultado que encuentre
            System.Console.WriteLine(primero);
            var primero1 = estudiantes.FirstOrDefault(x => x.Nombre.StartsWith("Z"));//cuando no contiene un elemento coincidente
            System.Console.WriteLine(primero1);

            var estudiantesNombre = estudiantes.
                    Select ( x => x.Nombre )//;
                    .ToList();//se crea una copia de la evaluación original | comentarlo para ver la dif
            foreach (var item in estudiantesNombre)
            {
                System.Console.WriteLine(item);
            }
            estudiantes[0] = new {
                    EstudianteID = 1,
                    Nombre = "Kenneth",
                    ApellidoPaterno = "Granados",
                    Universidad = "UNI"
            };
            foreach (var item in estudiantesNombre)
            {
                System.Console.WriteLine(item);
            }
        }

        // class NombreCompleto
        // {
        //     public string Nombre { get; set; }
        //     public string Apellido { get; set; }
        // }
    }
}

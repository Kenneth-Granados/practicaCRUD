
using System.Diagnostics;
namespace Fundamentos
{
    public partial class Program
    {
        public static void Main(string[] args){
        // Console.WriteLine("Hello, World!");
        // int i=0;
        // int j=0;
        // int a;
        // Par_Referencia c = new Par_Referencia();
        // System.Console.WriteLine(c.Agregar(i));
        // System.Console.WriteLine(i);
        // System.Console.WriteLine(c.Agregar(i));
        // System.Console.WriteLine(i);
        // System.Console.WriteLine(c.Agregar2(ref j));
        // System.Console.WriteLine(j);
        // System.Console.WriteLine(c.Agregar3(out a));
        // System.Console.WriteLine(a);
        // int suma = c.SumaParametros(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
        // System.Console.WriteLine(suma);

        // Enumeraciones enumeraciones = Enumeraciones.Usuario;

        // switch (enumeraciones)
        // {
        //     case Enumeraciones.Administrador:System.Console.WriteLine("Eres Admin");
        //         break;
        //     case Enumeraciones.Desarrollador:System.Console.WriteLine(enumeraciones);
        //         break;
        //     case Enumeraciones.Usuario:System.Console.WriteLine(enumeraciones.ToString());
        //         break;
        //     default: System.Console.WriteLine("No existe");
        //         break;
        // }

        // Estructuras? e = new Estructuras(2,4);
        // System.Console.WriteLine($"El valor de x es {e.Value.X} y el valor de y es: {e.Value.Y}");
        // System.Console.WriteLine("El calculo de las variables es: "+e.Value.Calcular());

        Cadenas cadenas = new Cadenas();
        // cadenas.Ejemplo1();
        cadenas.Ejemplo3("Prueba de separación de cadenas");
        
        // TablaMult tabla = new TablaMult();
        // tabla.Menu();

        //FileManager fileManager = new FileManager(@"C:\Users\PC-1\Documents\Practicas\practicaCSharpNotes\Fundamentos\Prueba.txt");
        // Colecciones c = new Colecciones();
        // c.Diccionario();

        // ClienteManager manager = new ClienteManager();
        //forma sencilla
        // foreach (Cliente cliente in manager)
        // {
        //     System.Console.WriteLine(cliente.Nombre);
        // }  

        // var enumerator = manager.GetEnumerator();
        // while (enumerator.MoveNext())
        // {
        //     System.Console.WriteLine(((Cliente)enumerator.Current).Nombre);
        // }
        // FechaPractica fp = new FechaPractica();
        // fp.CalculoSiglo("16/01/2000");
        // int [] arreglo = { 3, 6, -2, -5, 7, 3 };
        // fp.CalculoEntero(arreglo);
        // fp.CalculoDecimal(5);

        // CentralHub hub = new CentralHub();
        // SistemaAlarma alarma = new SistemaAlarma();
        // SistemaLuces luces = new SistemaLuces();
        // SistemasElectronicos electronicos = new SistemasElectronicos();
        // // hub.Add(luces.ApagarLuces);
        // hub.Add(() => luces.ApagarLuces(1));
        // hub.Add(alarma.EncenderAlarma);
        // hub.Add(electronicos.ApagarElectodomesticos);
        // // hub.IniciarProtocolo();

        Console.ReadLine();
        }
    }
}

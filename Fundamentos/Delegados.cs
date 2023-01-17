using System;

namespace Fundamentos
{

    class CentralHub
    {
        // SistemaAlarma alarma = new SistemaAlarma();
        // SistemaLuces luces = new SistemaLuces();
        // SistemasElectronicos electronicos = new SistemasElectronicos();
        Eventos control = new Eventos();
        //Inicializando un delegado
        // public delegate void IniciarProtocoloDelegete();
        // IniciarProtocoloDelegete iniciarProtocoloDelegete;//para hacerlos visibles al exterior forma 1 hacer ambas instancia de delegado publicas
        //forma 2 solo hacer publico lo que tenga delegate
        // public IniciarProtocoloDelegete IniciarProtocolo{ 
        //     get => iniciarProtocoloDelegete;
        //     set => iniciarProtocoloDelegete = value;
        //     }

        //public CentralHub()
        //{
            //iniciarProtocoloDelegete = new IniciarProtocoloDelegete( luces.ApagarLuces );//forma 2
            //añadiendo metodos al delegado
            // iniciarProtocoloDelegete += luces.ApagarLuces;//forma 1
            // iniciarProtocoloDelegete += alarma.EncenderAlarma;
            // iniciarProtocoloDelegete += electronicos.ApagarElectodomesticos;
            // //Eliinando metodos al delegado
            // iniciarProtocoloDelegete -= alarma.EncenderAlarma;
        //}
        //Forma 3
        // public void IniciarProtocolo(){
        //     iniciarProtocoloDelegete();
        // }
        // public void Add(IniciarProtocoloDelegete agregar) => iniciarProtocoloDelegete -= agregar;
        // public void Remove(IniciarProtocoloDelegete remover) => iniciarProtocoloDelegete -= remover;
        public void Add(Action agregar) => control.Eventos1 -= agregar;
        public void Remove(Action remover) => control.Eventos1 -= remover;


    }
    class SistemaLuces
    {
        public void ApagarLuces( int x ){
            Console.WriteLine("Sistemas Luces Apagados");
        }
    }
    class SistemaAlarma
    {
        public void EncenderAlarma(){
            Console.WriteLine("Alarma encendida");
        }
    }
    class SistemasElectronicos
    {
        public void ApagarElectodomesticos(){
            Console.WriteLine("Sistemas Electronicos Apagados");
        }
    }


}

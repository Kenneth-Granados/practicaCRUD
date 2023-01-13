using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos
{
    class FileManager
    {

        //FileStream reader = null;

        public FileManager(string filePath)
        {
            // try{
            // reader = File.Open(filePath, FileMode.Open);

            // byte [] b = new byte[1028];

            // UTF8Encoding temp = new UTF8Encoding();

            // while (reader.Read(b,0,b.Length) > 0)
            // {
            //     Console.WriteLine(temp.GetString(b));
            // }
            // } catch (Exception e){
            //     Console.WriteLine(e.Message);
            // } finally{
            //     reader.Close();//Es mejor cerrarlo implicitamente q usar destructores
            // }
            //Mejor forma para que los recursos siempre sean libeados
            using (FileStream reader = File.Open(filePath, FileMode.Open))
            {

                byte [] b = new byte[1028];

                UTF8Encoding temp = new UTF8Encoding();

                while (reader.Read(b,0,b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }
        }
    //Destructor (Cierre)
        // ~FileManager (){
        //     reader.Close();
        //     System.Diagnostics.Trace.WriteLine("Archivo cerrado");
        // }
        
    }
}
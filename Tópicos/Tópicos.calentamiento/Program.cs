using System;

namespace Tópicos.calentamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            DoJob();
            
            
        }

        private static void DoJob()
        {
            var laClase = new Job();
            laClase.Do();
        }
    }
}

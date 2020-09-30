using System;
using System.Collections.Generic;
using System.Text;

namespace Tópicos.calentamiento
{
    public class Job
    {
        public void Do()
        {
            Console.WriteLine("Hello World!");
            var lasHerramientas = new Topicos.Utilitarios.Message();
            var elMensaje = lasHerramientas.Say("HelloWorld!");
            Console.WriteLine(elMensaje);
        }

    }
}

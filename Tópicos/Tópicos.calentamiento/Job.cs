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
            lasHerramientas.MyProperty=89123;
            elMensaje= lasHerramientas.elMensaje;
            Console.WriteLine(elMensaje);
        }

            public void DoQuery()
        {
            var terminar = false;
            while (!terminar)
            {
                MostrarMenu();
                var laOpcion = CapturarOpcion();
                terminar = InvocarAccionCorrespondiente(laOpcion);
               
            }
        }

        private bool InvocarAccionCorrespondiente(string laOpcion)
        {
            var terminarPrograma = (laOpcion == "0");
            RealiceInvocacion(laOpcion);
            return terminarPrograma;
        }

        private void RealiceInvocacion(string laOpcion)
        {
            switch (laOpcion)
            {
                case "1": ConsultaPorIdDeProducto();
                    break;
                default:
                    break;
            }
        }

        private void ConsultaPorIdDeProducto()
        {
            var idDeProducto = CaptureIdDeProducto();
            if (idDeProducto != null)
            {

                var elServicio = new Topicos.NorthWind.BL.Services.Products();
                int elIdDeProductoNullable = (int)idDeProducto;
                var elProductoEncontrado = elServicio.ObtenerProductosporID(elIdDeProductoNullable);
                if(elProductoEncontrado == null)
                {
                    //Console.WriteLine(string.Format("El ID de producto {0}, no existe"),elIdDeProductoNullable.ToString());
                    Console.WriteLine($"El ID del Producto {elIdDeProductoNullable.ToString()} no existe");
                }
                else
                {
                    ImprimirDetalleDelProducto(elProductoEncontrado);
                }
            }
            
            
        }

        private void ImprimirDetalleDelProducto(Topicos.NorthWind.BaseDatos.Models.Products elProductoEncontrado)
        {
            Console.WriteLine($"Dettalle del Producto {elProductoEncontrado.ProductId.ToString()}.");
            Console.WriteLine($"Nombre  {elProductoEncontrado.ProductName.ToString()}.");
        }

        private object CaptureIdDeProducto()
        {
            Console.WriteLine("Digite el ID del Producto deseado: ");
            var elProductoString = System.Console.ReadLine();
            int elIdDelProducto = 0;
            int? elIdDeProductoNullable = null;
            if (! int.TryParse(elProductoString, out elIdDelProducto))
            {
                Console.WriteLine("El ID del producto digitado es erróneo");
            }
            else
            {
                elIdDeProductoNullable = (int?)elIdDelProducto;
            }
            return elIdDeProductoNullable;
        }

        private string CapturarOpcion()
        {
            var laOpcion = Console.ReadLine();
            return laOpcion;
        }

        public void MostrarMenu()
        {
            Console.WriteLine("Menú Principal");
            Console.WriteLine("..............");
            Console.WriteLine("1. Buscar Productos por ID");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Digite su Opción: ");


        }
    }
}

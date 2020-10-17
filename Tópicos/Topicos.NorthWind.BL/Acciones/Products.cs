using System;
using System.Collections.Generic;
using System.Text;

namespace Topicos.NorthWind.BL.Acciones
{
    internal class Products
    {
        public NorthWind.BaseDatos.Models.Products ObtenerProductosporID(int id)
        {

            NorthWind.BaseDatos.Models.Products elResultado;
            var elRepositorio = new Repositorio.Products();
            elResultado = elRepositorio.ObtenerProductosporID(id);
            return elResultado;

        }
    }
}

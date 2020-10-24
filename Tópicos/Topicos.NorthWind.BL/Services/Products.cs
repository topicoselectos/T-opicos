using System;
using System.Collections.Generic;
using System.Text;
using Topicos.NorthWind.BL.Interfaces;
using Topicos.NorthWind.BaseDatos.Models;

namespace Topicos.NorthWind.BL.Services
{
    public class Products : iProducts
    {
        public NorthWind.BaseDatos.Models.Products ObtenerProductosporID(int id)
        {
            NorthWind.BaseDatos.Models.Products elResultado;
            var laAccion = new Acciones.Products();
            elResultado = laAccion.ObtenerProductosporID(id);
            return elResultado;
        }

        public ICollection<NorthWind.BaseDatos.Models.Products> ObtenerProductosporNombreAprox(string nombreProducto)
        {
            throw new NotImplementedException();
        }

        public ICollection<BaseDatos.Models.Products> ObtenerProductosporRangoDePrecio(decimal? precioMinimo, decimal? precioMaximo)
        {
            throw new NotImplementedException();
        }
    }
}

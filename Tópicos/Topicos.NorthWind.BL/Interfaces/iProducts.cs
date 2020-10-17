using System;
using System.Collections.Generic;
using System.Text;
using Topicos.NorthWind.BaseDatos.Models;

namespace Topicos.NorthWind.BL.Interfaces
{
    interface iProducts
    {

        Products ObtenerProductosporID(int id);


        ICollection <Products>ObtenerProductosporNombreAprox(string nombreProducto);

        ICollection <Products> ObtenerProductosporRangoDePrecio(decimal? precioMinimo, decimal? precioMaximo);

    }
}

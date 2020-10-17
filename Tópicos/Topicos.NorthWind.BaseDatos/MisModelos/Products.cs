using System;
using System.Collections.Generic;
using System.Text;

namespace Topicos.NorthWind.BaseDatos.Models
{
    public partial class Products
    {
        public short? UnidadesDesabastecidas
        {
            get
            {
                short? elResultado = 0;
                if (UnitsInStock < ReorderLevel) //
                    elResultado = (short?)(UnitsInStock - ReorderLevel); //Para que traiga el valor correcto
                return elResultado;
            }
            set
            { }
        }

        public string SupplierName
        {
            get
            {
                string elResultado = string.Empty;
                if (Supplier != null)
                {
                    elResultado = Supplier.CompanyName; //Nos trae el Nombre de la compania
                }
                return elResultado;
            }
            set
            { }
        }

    }
}

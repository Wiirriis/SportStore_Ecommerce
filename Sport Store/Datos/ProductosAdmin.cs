using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 
namespace Sport_Store.Datos
{
    public class ProductosAdmin
    {
        public List<SP_TraerProductos_Result> consultarProductos()
        {
            using(ecommerceEntities contexto = new ecommerceEntities())
            {
                return contexto.SP_TraerProductos().ToList();
            }
        }
    }
}
using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class ClsDVenta
    {
        public List<tb_venta> UltimaVenta(){
        
            List<tb_venta> consultarultimaventa = new List<tb_venta>();
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                consultarultimaventa = bd.tb_venta.ToList();

            }

            return null;
        }
        public void save(tb_venta ventas)
        {
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                tb_venta venta = new tb_venta();

                venta.iDDocumento = ventas.iDDocumento;
                venta.iDCliente = ventas.iDCliente;
                venta.iDUsuario = venta.iDUsuario;
                venta.totalVenta = ventas.totalVenta;
                venta.fecha = ventas.fecha;

                bd.tb_venta.Add(venta);
                bd.SaveChanges();
            }
        }
    }
    

}

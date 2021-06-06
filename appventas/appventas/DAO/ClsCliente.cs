using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appventas.MODEL;

namespace appventas.DAO
{
    class ClsCliente
    {
        public List<tb_cliente> cargarDatosCliente()
        {

            List<tb_cliente> Lista;
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_cliente.ToList();

            }
            return Lista;
        }

        public void SaveDatosCliente(tb_cliente user)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {


                    tb_cliente userList = new tb_cliente();



                    userList.nombreCliente = user.nombreCliente;
                    userList.direccionCliente = user.direccionCliente;
                    userList.duiCliente = user.duiCliente;
                    db.tb_cliente.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }



        public void DeleteCliente(int iD)
        {

            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int Eliminar = Convert.ToInt32(iD);
                    tb_cliente userListCliente = db.tb_cliente.Where(x => x.iDCliente == Eliminar).Select(x => x).FirstOrDefault();
                    db.tb_cliente.Remove(userListCliente);
                    db.SaveChanges();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        public void updateCliente(tb_cliente user)
        {

            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int update = Convert.ToInt32(user.iDCliente);
                    tb_cliente userList = db.tb_cliente.Where(x => x.iDCliente == update).Select(x => x).FirstOrDefault();

                    userList.nombreCliente = user.nombreCliente;
                    userList.direccionCliente = user.direccionCliente;
                    userList.duiCliente = user.duiCliente;
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

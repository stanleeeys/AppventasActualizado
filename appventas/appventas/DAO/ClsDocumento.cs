using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appventas.MODEL;

namespace appventas.DAO
{
    class ClsDocumento
    {
        public List<tb_documento> cargarDatosDocumento()
        {

            List<tb_documento> Lista;
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_documento.ToList();

            }
            return Lista;
        }

        public void SaveDatosDocumento(tb_documento user)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {


                    tb_documento userListDocumento = new tb_documento();



                    userListDocumento.nombreDocumento = user.nombreDocumento;
                    db.tb_documento.Add(userListDocumento);
                    db.SaveChanges();

                    MessageBox.Show("Save");

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }



        public void DeleteDocumento(int iD)
        {

            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int Eliminar = Convert.ToInt32(iD);
                    tb_documento userListDocumento = db.tb_documento.Where(x => x.iDDocumento == Eliminar).Select(x => x).FirstOrDefault();
                    db.tb_documento.Remove(userListDocumento);
                    db.SaveChanges();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        public void updateDocumento(tb_documento user)
        {

            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int update = Convert.ToInt32(user.iDDocumento);
                    tb_documento userListDocumento = db.tb_documento.Where(x => x.iDDocumento == update).Select(x => x).FirstOrDefault();
                    userListDocumento.nombreDocumento = user.nombreDocumento;
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

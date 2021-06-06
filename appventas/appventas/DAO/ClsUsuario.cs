using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appventas.MODEL;

namespace appventas.DAO
{
    class ClsUsuario
    {
        public List<tb_usuario> cargarDatosUsuario()
        {

            List<tb_usuario> Lista;
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_usuario.ToList();

            }
            return Lista;
        }

        public void SaveDatosUsuario(tb_usuario user)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {


                    tb_usuario userListUsuario = new tb_usuario();



                    userListUsuario.email = user.email;
                    userListUsuario.contrasena = user.contrasena;
                    db.tb_usuario.Add(userListUsuario);
                    db.SaveChanges();

                    MessageBox.Show("Save");

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }



        public void DeleteUsuario(int iD)
        {

            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int Eliminar = Convert.ToInt32(iD);
                    tb_usuario userListUsuario = db.tb_usuario.Where(x => x.iDUsuario == Eliminar).Select(x => x).FirstOrDefault();
                    db.tb_usuario.Remove(userListUsuario);
                    db.SaveChanges();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        public void updateUsuario(tb_usuario user)
        {

            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int update = Convert.ToInt32(user.iDUsuario);
                    tb_usuario userListUsuario = db.tb_usuario.Where(x => x.iDUsuario == update).Select(x => x).FirstOrDefault();

                    userListUsuario.email = user.email;
                    userListUsuario.contrasena = user.contrasena;
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

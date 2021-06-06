using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appventas.MODEL;

namespace appventas.DAO
{
    class ClsAcceso
    {
        public int acceso(String usuario, String Password){
            int variabledeaccseso = 0;
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                var consulta = from user in bd.tb_usuario
                               where user.email == usuario && user.contrasena == Password
                               select user;
                if (consulta.Count() > 0)
                {
                    variabledeaccseso = 1;
                }
            }

            return variabledeaccseso;
        }

    }
}

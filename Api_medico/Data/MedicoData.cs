using Api_medico.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Api_medico.Data
{
    public class MedicoData
    {
        public static bool INSERTAR_MEDICO(Medico oMedico)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_INSERTAR_MEDICO '" + oMedico.id_medico + "','" + oMedico.nombres
           + "','" +
 oMedico.telefono + "','" + oMedico.correo + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }

        public static bool ACTUALIZAR_MEDICO(Medico oMedico)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_ACTUALIZAR_MEDICO '" + oMedico.id_medico + "','" + oMedico.nombres
           + "','" +
 oMedico.telefono + "','" + oMedico.correo + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }

        public static bool ELIMINAR_MEDICO(string id)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_ELIMINAR_MEDICO '" + id + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }

        public static List<Medico> LISTAR()
        {
            List<Medico> oListaMedico = new List<Medico>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_LISTAR_MEDICO '";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaMedico.Add(new Medico()
                    {
                        id_medico = dr["id_medico"].ToString(),
                        nombres = dr["Nombres"].ToString(),
                        telefono = dr["telefono"].ToString(),
                        correo = dr["correo"].ToString(),                       
                        fechaIngreso = Convert.ToDateTime(dr["fechaIngreso"].ToString())
                    });
                }
                return oListaMedico;
            }
            else
            {
            }
            return oListaMedico;

            }
           
        }
}
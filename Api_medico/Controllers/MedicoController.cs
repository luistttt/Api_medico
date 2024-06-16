using Api_medico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Api_medico.Data;

namespace Api_medico.Controllers
{
    public class MedicoController : ApiController
    {
        // GET api/<controller>
        public List<Medico> Get()
        {
            return MedicoData.LISTAR();
        }
        
        // POST api/<controller>
        public bool Post([FromBody] Medico oMedico)
        {
            return MedicoData.INSERTAR_MEDICO(oMedico);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Medico oMedico)
        {
            return MedicoData.ACTUALIZAR_MEDICO(oMedico);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return MedicoData.ELIMINAR_MEDICO(id);
        }
    }
}
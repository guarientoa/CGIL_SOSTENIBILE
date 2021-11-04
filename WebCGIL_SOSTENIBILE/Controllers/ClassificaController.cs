using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DB;

namespace WebCGIL_SOSTENIBILE.Controllers
{
	public class ClassificaController : ApiController
	{
		// GET api/<controller>
		[HttpGet()]
		public IHttpActionResult Get()
		{
			IHttpActionResult ret = null;
			using (var db = new CGIL_SOSTENIBILEContext())
			{
				var list = new List<Classifica>();
				list = db.Classificas.ToList();
				ret = Ok(list);
				return ret;
			}
		}
		[HttpGet()]
		public IHttpActionResult Get(int id)
		{
			IHttpActionResult ret;
			using (var db = new CGIL_SOSTENIBILEContext())
			{
				var struttura = db.Classificas.FirstOrDefault(a => a.NumeroClassifica == id);
				if (struttura == null)
					ret = NotFound();
				else
					ret = Ok(struttura);

				return ret;
			}
		}

		// POST api/<controller>
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
		}
	}
}
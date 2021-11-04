using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DB;

namespace WebCGIL_SOSTENIBILE.Controllers
{
	public class StruttureController : ApiController
	{
		// GET api/<controller>
		[HttpGet()]
		public IHttpActionResult Get()
		{
			IHttpActionResult ret = null;
			using (var db = new CGIL_SOSTENIBILEContext())
			{
				var list = new List<Strutture>();
				list = db.Struttures.ToList();
				ret = Ok(list);
				return ret;
			}
		}

		// GET api/<controller>/5
		public string Get(int id)
		{
			return "value";
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
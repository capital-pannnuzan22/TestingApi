using Animal_BL;
using Animal_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Testing.Controllers
{
    public class AnimalApiController : ApiController
    {
        [System.Web.Mvc.AcceptVerbs("GET", "POST")]
        [System.Web.Mvc.HttpGet]
        //[HttpPost]
        public IHttpActionResult GetAnimal([FromBody] AnimalModel animalModel)
        {
            AnimalBL animalBL = new AnimalBL();
            return Ok(animalBL.GetAnimal(animalModel));
        }

        [HttpPost]
        [ActionName("AnimalCUD")]
        public IHttpActionResult AnimalCUD([FromBody] AnimalModel animalModel)
        {
            AnimalBL animalBL = new AnimalBL();
            return Ok(animalBL.AnimalCUD(animalModel));
        }

        [System.Web.Mvc.AcceptVerbs("GET", "POST")]
        [System.Web.Mvc.HttpGet]
        public IHttpActionResult GetTestApi([FromBody] AnimalModel animalModel)
        {
            AnimalBL animalBL = new AnimalBL();
            return Ok(animalBL.GetTestApi(animalModel));
        }
    }
}

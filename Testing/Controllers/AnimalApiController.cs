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
        [HttpPost]
        [ActionName("GetAnimal")]
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
    }
}

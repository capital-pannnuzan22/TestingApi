using System.Web.Http;
using TestingBL;
using TestingModel;

namespace Testing.Controllers
{
    public class TestingAPIController : ApiController
    {

        [HttpPost]
        [ActionName("GetData")]
        public IHttpActionResult GetData([FromBody] Testing_Model testingmodel)
        {
            Testing_BL TestingBL = new Testing_BL();
            return Ok(TestingBL.TestingSelect(testingmodel));

        }

        [HttpPost]
        [ActionName("TestingCUD")]
        public IHttpActionResult TestingCUD([FromBody] Testing_Model animalModel)
        {
            Testing_BL TestingBL = new Testing_BL();
            return Ok(TestingBL.TestingCUD(animalModel));
        }

        //[HttpPost]
        //[ActionName("TestingInsert")]
        //public IHttpActionResult TestingInsert([FromBody] Testing_Model testingmodel)
        //{
        //    Testing_BL testingbl = new Testing_BL();
        //    return Ok(testingbl.TestingInsert(testingmodel));

        //}

        //[HttpPost]
        //[ActionName("TestingUpdate")]
        //public IHttpActionResult TestingUpdate([FromBody] Testing_Model testingmodel)
        //{
        //    Testing_BL testingbl = new Testing_BL();
        //    return Ok(testingbl.TestingUpdate(testingmodel));
        //}

        //[HttpPost]
        //[ActionName("TestingDelete")]
        //public IHttpActionResult TestingDelete([FromBody] Testing_Model testingmodel)
        //{
        //    Testing_BL testingbl = new Testing_BL();
        //    return Ok(testingbl.TestingDelete(testingmodel));
        //}
    }
}

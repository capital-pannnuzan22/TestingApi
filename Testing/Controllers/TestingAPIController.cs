using System.Web.Http;
using TestingBL;
using TestingModel;

namespace Testing.Controllers
{
    public class TestingAPIController : ApiController
    {

        [System.Web.Mvc.AcceptVerbs("GET", "POST")]
        [System.Web.Mvc.HttpGet]
        public IHttpActionResult GetData([FromBody] Testing_Model testingmodel)
        {
            Testing_BL TestingBL = new Testing_BL();
            return Ok(TestingBL.TestingSelect(testingmodel));

        }

        [HttpPost]
        [ActionName("TestingCUD")]
        public IHttpActionResult TestingCUD([FromBody] Testing_Model testingmodel)
        {
            Testing_BL TestingBL = new Testing_BL();
            return Ok(TestingBL.TestingCUD(testingmodel));
        }

        [System.Web.Mvc.AcceptVerbs("GET", "POST")]
        [System.Web.Mvc.HttpGet]
        public IHttpActionResult GetTestApi([FromBody] Testing_Model testingmodel)
        {
            Testing_BL TestingBL = new Testing_BL();
            return Ok(TestingBL.GetData(testingmodel));
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

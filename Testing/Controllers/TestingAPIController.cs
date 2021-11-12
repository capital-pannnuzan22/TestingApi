using System.Web.Http;
using TestingBL;
using TestingModel;

namespace Testing.Controllers
{
    public class TestingAPIController : ApiController
    {

        [HttpPost]
        [ActionName("GetData")]
        public IHttpActionResult TestingSelect([FromBody] Testing_Model testingmodel)
        {
            Testing_BL languageBL = new Testing_BL();
            return Ok(languageBL.TestingSelect(testingmodel));
        }

        [HttpPost]
        [ActionName("TestingInsert")]
        public IHttpActionResult TestingInsert([FromBody] Testing_Model testingmodel)
        {
            Testing_BL testingbl = new Testing_BL();
            return Ok(testingbl.TestingInsert(testingmodel));
        }

        [HttpPost]
        [ActionName("TestingUpdate")]
        public IHttpActionResult TestingUpdate([FromBody] Testing_Model testingmodel)
        {
            Testing_BL testingbl = new Testing_BL();
            return Ok(testingbl.TestingUpdate(testingmodel));
        }

        [HttpPost]
        [ActionName("TestingDelete")]
        public IHttpActionResult TestingDelete([FromBody] Testing_Model testingmodel)
        {
            Testing_BL testingbl = new Testing_BL();
            return Ok(testingbl.TestingDelete(testingmodel));
        }
    }
}

using System.Collections.Generic;
using System.Web.Http;
using LocationData;

namespace HelpingHearts.Controllers
{
    public class AedController : ApiController
    {
      // GET api/aed
      public IEnumerable<AEdLocation> Get()
      {
        return AedRepository.GetList();
      }

      // GET api/aed/5
      public AEdLocation Get(int id)
      {
        return default(AEdLocation);
      }

      // POST api/aed
      public void Post([FromBody]string value)
      {
      }

      // PUT api/aed/5
      public void Put(int id, [FromBody]string value)
      {
      }

      // DELETE api/aed/5
      public void Delete(int id)
      {
      }
    }
}

using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using JackstimetableService.DataObjects;
using JackstimetableService.Models;

namespace JackstimetableService.Controllers
{
    public class SchoolController : TableController<SchoolDto>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            var context = new JackstimetableContext();
            DomainManager = new EntityDomainManager<SchoolDto>(context, Request, Services);
        }

        // GET tables/School
        public IQueryable<SchoolDto> GetAllSchoolDto()
        {
            return Query(); 
        }

        // GET tables/School/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<SchoolDto> GetSchoolDto(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/School/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<SchoolDto> PatchSchoolDto(string id, Delta<SchoolDto> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/School
        public async Task<IHttpActionResult> PostSchoolDto(SchoolDto item)
        {
            SchoolDto current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/School/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteSchoolDto(string id)
        {
             return DeleteAsync(id);
        }

    }
}
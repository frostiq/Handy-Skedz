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
    public class SchoolTypeController : TableController<SchoolTypeDto>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            JackstimetableContext context = new JackstimetableContext();
            DomainManager = new EntityDomainManager<SchoolTypeDto>(context, Request, Services);
        }

        // GET tables/SchoolType
        public IQueryable<SchoolTypeDto> GetAllSchoolTypeDto()
        {
            return Query(); 
        }

        // GET tables/SchoolType/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<SchoolTypeDto> GetSchoolTypeDto(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/SchoolType/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<SchoolTypeDto> PatchSchoolTypeDto(string id, Delta<SchoolTypeDto> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/SchoolType
        public async Task<IHttpActionResult> PostSchoolTypeDto(SchoolTypeDto item)
        {
            SchoolTypeDto current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/SchoolType/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteSchoolTypeDto(string id)
        {
             return DeleteAsync(id);
        }

    }
}
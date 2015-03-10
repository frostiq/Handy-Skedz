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
    public class LocationsController : TableController<LocationDto>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            JackstimetableContext context = new JackstimetableContext();
            DomainManager = new EntityDomainManager<LocationDto>(context, Request, Services);
        }

        // GET tables/Locations
        public IQueryable<LocationDto> GetAllLocationDto()
        {
            return Query(); 
        }

        // GET tables/Locations/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<LocationDto> GetLocationDto(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Locations/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<LocationDto> PatchLocationDto(string id, Delta<LocationDto> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Locations
        public async Task<IHttpActionResult> PostLocationDto(LocationDto item)
        {
            LocationDto current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Locations/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteLocationDto(string id)
        {
             return DeleteAsync(id);
        }

    }
}
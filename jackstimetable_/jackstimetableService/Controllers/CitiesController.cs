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
    public class CitiesController : TableController<CityDto>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            JackstimetableContext context = new JackstimetableContext();
            DomainManager = new EntityDomainManager<CityDto>(context, Request, Services);
        }

        // GET tables/Cities
        public IQueryable<CityDto> GetAllCityDto()
        {
            return Query(); 
        }

        // GET tables/Cities/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<CityDto> GetCityDto(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Cities/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<CityDto> PatchCityDto(string id, Delta<CityDto> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Cities
        public async Task<IHttpActionResult> PostCityDto(CityDto item)
        {
            CityDto current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Cities/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteCityDto(string id)
        {
             return DeleteAsync(id);
        }

    }
}
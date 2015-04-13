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
    public class CountriesController : TableController<CountryDto>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            JackstimetableContext context = new JackstimetableContext();
            DomainManager = new EntityDomainManager<CountryDto>(context, Request, Services);
        }

        // GET tables/Country
        public IQueryable<CountryDto> GetAllCountryDto()
        {
            return Query().OrderBy(c => c.Name); 
        }

        // GET tables/Country/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<CountryDto> GetCountryDto(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Country/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<CountryDto> PatchCountryDto(string id, Delta<CountryDto> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Country
        public async Task<IHttpActionResult> PostCountryDto(CountryDto item)
        {
            CountryDto current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Country/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteCountryDto(string id)
        {
             return DeleteAsync(id);
        }

    }
}
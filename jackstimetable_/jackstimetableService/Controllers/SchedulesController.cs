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
    public class SchedulesController : TableController<ScheduleDto>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            var context = new JackstimetableContext();
            DomainManager = new EntityDomainManager<ScheduleDto>(context, Request, Services);
        }

        // GET tables/Schedule
        public IQueryable<ScheduleDto> GetAllScheduleDto()
        {
            return Query(); 
        }

        // GET tables/Schedule/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ScheduleDto> GetScheduleDto(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Schedule/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ScheduleDto> PatchScheduleDto(string id, Delta<ScheduleDto> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Schedule
        public async Task<IHttpActionResult> PostScheduleDto(ScheduleDto item)
        {
            ScheduleDto current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Schedule/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteScheduleDto(string id)
        {
             return DeleteAsync(id);
        }

    }
}
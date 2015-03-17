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
    public class StudyGroupDtoController : TableController<StudyGroupDto>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            JackstimetableContext context = new JackstimetableContext();
            DomainManager = new EntityDomainManager<StudyGroupDto>(context, Request, Services);
        }

        // GET tables/StudyGroupDto
        public IQueryable<StudyGroupDto> GetAllStudyGroupDto()
        {
            return Query(); 
        }

        // GET tables/StudyGroupDto/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<StudyGroupDto> GetStudyGroupDto(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/StudyGroupDto/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<StudyGroupDto> PatchStudyGroupDto(string id, Delta<StudyGroupDto> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/StudyGroupDto
        public async Task<IHttpActionResult> PostStudyGroupDto(StudyGroupDto item)
        {
            StudyGroupDto current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/StudyGroupDto/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteStudyGroupDto(string id)
        {
             return DeleteAsync(id);
        }

    }
}
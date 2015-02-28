using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using JackstimetableService.DataObjects;
using JackstimetableService.Models;
using Microsoft.WindowsAzure.Mobile.Service;

namespace JackstimetableService.Controllers
{
    public class UsersController : TableController<UserDto>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            var context = new JackstimetableContext();
            DomainManager = new EntityDomainManager<UserDto>(context, Request, Services);
        }

        // GET tables/Users
        public IQueryable<UserDto> GetAllUserDto()
        {
            return Query(); 
        }

        // GET tables/Users/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<UserDto> GetUserDto(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Users/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<UserDto> PatchUserDto(string id, Delta<UserDto> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Users
        public async Task<IHttpActionResult> PostUserDto(UserDto item)
        {
            UserDto current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Users/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteUserDto(string id)
        {
             return DeleteAsync(id);
        }

    }
}
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using SchoolExpress.WebService.Domain;
using SchoolExpress.WebService.Uows;

namespace SchoolExpress.WebService.Controllers.Api.Maintenances
{
    [RoutePrefix("api/maintenances/roles")]
    public class RolesMaintenanceApiController: MaintenanceApiController<Role>
    {
        public RolesMaintenanceApiController(ISchoolExpressUow uow) : base(uow)
        {
        }
        
        [Authorize(Roles = "api.maintenances.roles.get")]
        public override Task<HttpResponseMessage> Get(int page, int pageSize, string orderBy)
        {
            return base.Get(page, pageSize, orderBy);
        }

        [Authorize(Roles = "api.maintenances.roles.get")]
        public override Task<HttpResponseMessage> Get(int page, int pageSize, string orderBy, string where)
        {
            return base.Get(page, pageSize, orderBy, where);
        }
        
        [Authorize(Roles = "api.maintenances.roles.get")]
        public override Task<HttpResponseMessage> Get(int page, int pageSize, string orderBy, string where, string select)
        {
            return base.Get(page, pageSize, orderBy, where, select);
        }

        [Authorize(Roles = "api.maintenances.roles.get")]
        public override async Task<HttpResponseMessage> Get(object id)
        {
            return await base.Get(id);
        }


        [Authorize(Roles = "api.maintenances.roles.put")]
        public override async Task<HttpResponseMessage> Put(Role entity)
        {
            return await base.Put(entity);
        }


        [Authorize(Roles = "api.maintenances.roles.post")]
        public override async Task<HttpResponseMessage> Post(Role entity)
        {
            return await base.Post(entity);
        }
        
        [Authorize(Roles = "api.maintenances.roles.patch")]
        public override async Task<HttpResponseMessage> Patch([FromBody] string json)
        {
            return await base.Patch(json);
        }

        [Authorize(Roles = "api.maintenances.roles.delete")]
        public override async Task<HttpResponseMessage> Delete(object id)
        {
            return await base.Delete(id);
        }
    }
}
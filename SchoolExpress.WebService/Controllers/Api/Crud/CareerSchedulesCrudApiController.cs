﻿using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using SchoolExpress.WebService.Domain;
using SchoolExpress.WebService.Uows;
using SchoolExpress.WebService.Utils;

namespace SchoolExpress.WebService.Controllers.Api.Crud
{
    [Authorize]
    [RoutePrefix("api/crud/careerschedules")]
    public class CareerSchedulesCrudApiController : CrudApiController<CareerSchedule>
    {
        public CareerSchedulesCrudApiController(ISchoolExpressUow uow) : base(uow)
        {
        }

        [Authorize(Roles = "api.crud.careerschedules.get")]
        public override QueryResponse<CareerSchedule> Get(int page, int pageSize, string orderBy)
        {
            return base.Get(page, pageSize, orderBy);
        }

        [Authorize(Roles = "api.crud.careerschedules.get")]
        public override async Task<CareerSchedule> Get(object id)
        {
            return await base.Get(id);
        }


        [Authorize(Roles = "api.crud.careerschedules.put")]
        public override async Task<HttpResponseMessage> Put(CareerSchedule entity)
        {
            return await base.Put(entity);
        }


        [Authorize(Roles = "api.crud.careerschedules.post")]
        public override async Task<HttpResponseMessage> Post(CareerSchedule entity)
        {
            return await base.Post(entity);
        }

        [Authorize(Roles = "api.crud.careerschedules.delete")]
        public override async Task<HttpResponseMessage> Delete(object id)
        {
            return await base.Delete(id);
        }
    }
}
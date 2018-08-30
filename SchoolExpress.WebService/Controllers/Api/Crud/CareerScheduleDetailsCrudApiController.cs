﻿using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using SchoolExpress.WebService.Domain;
using SchoolExpress.WebService.Uows;
using SchoolExpress.WebService.Utils;

namespace SchoolExpress.WebService.Controllers.Api.Crud
{
    [Authorize]
    [RoutePrefix("api/crud/careerscheduledetails")]
    public class CareerScheduleDetailsCrudApiController : CrudApiController<CareerScheduleDetail>
    {
        public CareerScheduleDetailsCrudApiController(ISchoolExpressUow uow) : base(uow)
        {
        }

        [Authorize(Roles = "api.crud.careerscheduledetails.get")]
        public override QueryResponse<CareerScheduleDetail> Get(int page, int pageSize, string orderBy)
        {
            return base.Get(page, pageSize, orderBy);
        }

        [Authorize(Roles = "api.crud.careerscheduledetails.get")]
        public override async Task<CareerScheduleDetail> Get(object id)
        {
            return await base.Get(id);
        }


        [Authorize(Roles = "api.crud.careerscheduledetails.put")]
        public override async Task<HttpResponseMessage> Put(CareerScheduleDetail entity)
        {
            return await base.Put(entity);
        }

        [Authorize(Roles = "api.crud.careerscheduledetails.post")]
        public override async Task<HttpResponseMessage> Post(CareerScheduleDetail entity)
        {
            return await base.Post(entity);
        }

        [Authorize(Roles = "api.crud.careerscheduledetails.delete")]
        public override async Task<HttpResponseMessage> Delete(object id)
        {
            return await base.Delete(id);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common.Logging;
using SchoolExpress.Domain;
using SchoolExpress.Infrastructure.Contracts;

namespace SchoolExpress.WebService.Controllers.Api
{
    public abstract class BaseApiController<T> : ApiController where T : class, IEntity
    {
        protected readonly IUow Uow;
        protected ILog Log;

        protected BaseApiController(IUow uow)
        {
            Uow = uow;
            Log = LogManager.GetLogger(GetType());
            Console.Write(GetType());
        }

        [Route("")]
        public virtual IEnumerable<T> Get()
        {
            return Uow.GetGenericRepository<T>().GetAll();
        }

        [Route("{id:int}")]
        public virtual T Get(int id)
        {
            var entity = Uow.GetGenericRepository<T>().GetById(id);
            if (entity != null)
                return entity;
            throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
        }

        [Route("")]
        public virtual HttpResponseMessage Put(T entity)
        {
            Uow.GetGenericRepository<T>().Update(entity);
            Uow.Commit();
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }

        [Route("")]
        public virtual HttpResponseMessage Post(T entity)
        {
            Uow.GetGenericRepository<T>().Add(entity);
            Uow.Commit();
            var response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location =
                new Uri(Request.RequestUri.AbsoluteUri +
                        (entity.GetId() != null
                            ? "/" + string.Join("/", entity.GetId())
                            : ""));
            return response;
        }

        [Route("{id:int}")]
        public virtual HttpResponseMessage Delete(int id)
        {
            Uow.GetGenericRepository<T>().Delete(id);
            Uow.Commit();
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
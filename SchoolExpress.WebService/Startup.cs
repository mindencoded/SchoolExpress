﻿using System.Web.Http;
using System.Web.Http.Cors;
using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;

namespace SchoolExpress.WebService
{
    public class Startup
    {
        public static string ApiController = "ApiController";
        public static string ApiControllerId = "ApiControllerId";
        public static string ApiControllerAction = "ApiControllerAction";
        public static string ApiControllerActionId = "ApiControllerActionId";
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();

            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            config.MapHttpAttributeRoutes(new CustomDirectRouteProvider());

            config.Routes.MapHttpRoute(
                ApiController,
                "api/{controller}"
            );

            config.Routes.MapHttpRoute(
                ApiControllerId,
                "api/{controller}/{id}",
                null,
                new {id = @"^\d+$"}
            );

            config.Routes.MapHttpRoute(
                ApiControllerAction,
                "api/{controller}/{action}"
            );

            config.Routes.MapHttpRoute(
                ApiControllerActionId,
                "api/{controller}/{action}/{id}",
                null,
                new {id = @"^\d+$"}
            );


            config.DependencyResolver = new UnityResolver(UnityConfig.GetConfiguredContainer());

            var serializerSettings = config.Formatters.JsonFormatter.SerializerSettings;
            serializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            serializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;
            serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Filters.Add(new ValidationActionFilter()); 
            appBuilder.UseWebApi(config);

            appBuilder.UseFileServer(new FileServerOptions
            {
                RequestPath = new PathString(string.Empty),
                EnableDirectoryBrowsing = true,
                EnableDefaultFiles = true,
                DefaultFilesOptions = {DefaultFileNames = {"index.html"}},
                FileSystem = new PhysicalFileSystem("./wwwroot"),
                StaticFileOptions = {ContentTypeProvider = new CustomContentTypeProvider()}
            });
        }
    }
}
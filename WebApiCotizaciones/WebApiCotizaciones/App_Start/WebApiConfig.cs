﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiCotizaciones
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                 //name: "DefaultApi",
                 //routeTemplate: "api/{controller}/{id}",
                 //defaults: new { id = RouteParameter.Optional }
                 name: "DefaultApi",
                routeTemplate: "api/{controller}/{tipo}",
                defaults: new { tipo = RouteParameter.Optional  }
            );
        }
    }
}

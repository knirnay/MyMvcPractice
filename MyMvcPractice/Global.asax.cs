using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyMvcPractice
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //// What is the purpose of this SetInitializer?
            //// It is used to inialize our database. If you don't have database created already, it is going to create
            //// a database for you. Creates tables for you and populates them with some sample data. But, we already have
            //// database, tables and the data so, we don't want any intialization stratergy for our EcommerceContext object
            //// so, I am passing null, specifying that I don't want to have any database initialization stratergy.
            //// That is the importance of the following line.
            Database.SetInitializer<MyMvcPractice.Models.EcommerceContext>(null);
        }
    }
}

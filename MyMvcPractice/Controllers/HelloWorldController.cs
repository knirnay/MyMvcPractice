using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcPractice.Controllers
{
    public class HelloWorldController : Controller
    {
        /// <summary>
        /// Gets hello world string. This action method prints returned string on the browser.
        /// URL: http://localhost/MyMvcPractice/Helloworld/GetMessage
        /// </summary>
        /// <returns></returns>
        public string GetMessage()
        {
            return "Hellow world from MVC.";
        }

        /// <summary>
        /// Reads input parameter value and prints it on the browser window.
        /// URL: http://localhost/MyMvcPractice/Helloworld/ReadInputParameterValue/12
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string ReadInputParameterValue(int id)
        {
            return string.Concat(nameof(id), " = ", id);
        }

        /// <summary>
        /// Reads input parameter value and prints it on the browser window.Reads multiple input parameter and prints them on the browser window. The parameter name must match the QueryString in the URL.
        /// URL: http://localhost/MyMvcPractice/Helloworld/ReadMultipleParameterValue/12?name=nirnay
        /// Note: name parameter can also be read by using Request.QueryString["name"] which is what we typically do in aspx form. If it is used we don't need the name parameter to be passed in the below function.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public string ReadMultipleParameterValue(int id, string name)
        {
            return string.Concat(nameof(id), " = ", id, " ", nameof(name), " = ", name);
        }

        /// <summary>
        /// Renders view. The view was created by right clicking somewhere in the function and click on add view.
        /// For this example, the view is not strongly typed i.e it is created without any Model referenced to it.
        /// Note. Action method name should be same as name of the View since we just say return View() and it 
        /// will look for the view with the same name as of the action method. If you want to give different name
        /// of then need to add the ActionName attribute with that name of the view.
        /// </summary>
        /// <returns></returns>
        public ActionResult ListOfCountries()
        {
            // We can use dynamic property with the ViewBag. I named Countries but, in theory, we can give any valid name.
            // ViewBag uses the dynamic feature that was introduced in C# 4.0. It allows an object to have properties dynamically added to it.
            // ViewBag and ViewData are are a mechanism to pass data from controller to view.
            // Note: To pass data from the controller to the view it is always a good practice to use strongly typed view models.
            // We use @ symbol to switch between HTML and C# code.
            this.ViewBag.Countries = new List<string>
            {
                "US",
                "India",
                "UK",
                "Australia"
            };

            return View();
        }
    }
}
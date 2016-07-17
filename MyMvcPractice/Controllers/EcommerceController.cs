using MyMvcPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcPractice.Controllers
{
    public class EcommerceController : Controller
    {
        /// <summary>
        /// Gets the product category by hardcoding.
        /// The controller responds to URL request, gets data from the model and hand it over to the view.
        /// The view then renders data. In this example the model has hardcoded values, in reality they could
        /// be comming from database through entity or business objects.
        /// </summary>
        /// <returns></returns>
        public ActionResult GetProductCategoryByHardcoding()
        {
            //// We get hard code the product category information and then display it on the view by passing 
            //// the ProductCategory object to the view.
            ProductCategory productCategory = new ProductCategory();
            productCategory.CategoryId = 23;
            productCategory.Name = "Monitors";
            productCategory.ParentCategoryId = 11;
            return View(productCategory);
        }

        /// <summary>
        /// Gets the product category by entity framework.
        /// </summary>
        /// <param name="productCategoryId">The product category identifier.</param>
        /// <returns></returns>
        public ActionResult GetProductCategoryByEntityFramework(int categoryId)
        {
            //// Retrieves data from a database(Ecommerce) table ProductCategory using entity framework.
            //// Step 1: Install entity framework using nuget package.
            //// Step 2: Add ProductCategoryContext.cs file to the Models folder.
            //// Step 3: Add connection string to the web.config file in the root directory.

            //// Following line establishes connection to the database using connection string specified in the Web.config file.
            EcommerceContext context = new EcommerceContext();

            //// Below line will send the following query to the sql server
            /*exec sp_executesql N'SELECT TOP (2) 
                    [Extent1].[CategoryId] AS[CategoryId], 
                    [Extent1].[Name] AS[Name], 
                    [Extent1].[ParentCategoryId] AS[ParentCategoryId]
                    FROM[dbo].[ProductCategory] AS[Extent1]
                    WHERE[Extent1].[CategoryId] = @p__linq__0',N'@p__linq__0 int',@p__linq__0=23
            */
            //// Note that the query says TOP(2) even though we are using Single function. The reason behind it is,
            //// if there are more than 1 record in the database an exception would be thrown. If it only selects
            //// top(1), there would be no way to error out.
            return View(context.ProductCategories.Single(product => product.CategoryId == categoryId));
        }
    }
}
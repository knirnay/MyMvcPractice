using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyMvcPractice.Models
{
    /// <summary>
    /// The purpose of this class is to establish a connection to the database. DbContext
    /// base calss is going to do these all for us.
    /// 
    /// Having said that, the web.config file must need a ConnectionStrings tag and the name should
    /// exactly same as the class name. In this example our class name is EcommerceContext so, the
    /// name of the connectionstring in the web.config file is EcommerceContext.
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class EcommerceContext : DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyMvcPractice.Models
{
    /// <summary>
    /// The name of the entity should match the name of the table in the database if, it doesn't we must 
    /// need the Table Attribute with the correct table name as shown below. Once this is done, Entity Framework
    /// will map this entity to the physical table in the database.
    /// </summary>
    [Table("ProductCategory")]
    public class ProductCategory
    {
        /// <summary>
        /// Gets or sets the category identifier.
        /// This is the primary key on the table in the database hence, 
        /// it must be decorated with the Key attribute otherwise it will throw a runtime error.
        /// </summary>
        /// <value>
        /// The catedgory identifier.
        /// </value>
        [Key]
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the parent category identifier.
        /// </summary>
        /// <value>
        /// The parent category identifier.
        /// </value>
        public int? ParentCategoryId { get; set; }
    }
}
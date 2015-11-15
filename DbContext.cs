using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///  ADDing For using DbContext
/// </summary>
using System.Data.Entity;

namespace WebApplication9.Models
{
    public class SchoolContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public SchoolContext() : base() { }

        /// <remarks>
        /// Getting all the Results in the Form of DbSet
        /// </remarks>
        /// 

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}
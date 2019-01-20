using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BoilerplateWebERP.API.Models;

namespace BoilerplateWebERP.API.Data
{
    public class DataContext : DbContext
    {
        //Constructor to call DbContext
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //Calling Models to Populate the DB Table 
        public DbSet<Value> Values { get; set; }
    }
}
﻿using bau_rasa.web.Identity;
using bau_rasa.web.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace bau_rasa.web.Entity
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext() : base("dataConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<CartLine> CartLines { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Register> Register { get; set; }

    }
}
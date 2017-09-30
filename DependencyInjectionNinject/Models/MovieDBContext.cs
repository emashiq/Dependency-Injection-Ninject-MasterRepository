﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DependencyInjectionNinject.Models
{
    public class MovieDBContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
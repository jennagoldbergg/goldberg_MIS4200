﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using goldberg_MIS4200.Models;
using System.Data.Entity;

namespace goldberg_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<customer> Customer { get; set; }
    }
}
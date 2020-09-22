﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDwithWindowForm
{
    public class ModelContext : DbContext
    {

        public ModelContext(): base("name=conn")
        {
            //constructor
        }

        public DbSet<Employee> Employees { get; set; }



    }
}

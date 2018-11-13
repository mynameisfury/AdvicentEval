using AdvicentEval.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdvicentEval
{
    public class MyDbContext : DbContext
    {
        public IDbSet<College> Colleges { get; set; }
        public MyDbContext()
        {
        }
    }
}
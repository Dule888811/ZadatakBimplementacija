using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ZadatakBimplementacija.Models
{
    public class ZadatakImplementacijaB : DbContext
    {
        public DbSet<Proizvod> Proizvods { get; set; }
    }
}
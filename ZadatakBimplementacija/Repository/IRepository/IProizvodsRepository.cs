using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZadatakBimplementacija.Models;

namespace ZadatakBimplementacija.Repository.IRepository
{
    public interface IProizvodsRepository
    {
        IQueryable<Proizvod> Get();
    }
}
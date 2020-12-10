using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ZadatakBimplementacija.Models;
using ZadatakBimplementacija.Repository.IRepository;

namespace ZadatakBimplementacija.Repository
{
    public class ProizvodsRepository : BaseRepository, IProizvodsRepository
    {
        public ProizvodsRepository(Models.ZadatakImplementacijaB context) : base(context)
        {

        }

        public IQueryable<Proizvod> Get()
        {
            var proizvodi = from m in context.Proizvods
                           select m;
            if (proizvodi.Count() == 0)
            {
                return null;
            }
            return proizvodi;
        }
        public void AddProizvod(Proizvod Proizvod)
        {
            context.Proizvods.Add(Proizvod);
            base.SaveChanges();
        }

        public Proizvod GetById(int id)
        {
            return context.Proizvods.Find(id);
        }

        public void EditDocument(Proizvod Proizvod)
        {
            context.Entry(Proizvod).State = EntityState.Modified;
            base.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZadatakBimplementacija.Repository
{
    public class BaseRepository
    {
        protected readonly Models.ZadatakImplementacijaB context;

        public BaseRepository(Models.ZadatakImplementacijaB context)
        {
            this.context = context;
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}
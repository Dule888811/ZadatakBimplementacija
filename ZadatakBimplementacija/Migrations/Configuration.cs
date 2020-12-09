namespace ZadatakBimplementacija.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZadatakBimplementacija.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ZadatakBimplementacija.Models.ZadatakImplementacijaB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ZadatakBimplementacija.Models.ZadatakImplementacijaB context)
        {
            List<Proizvod> proizvodi = new List<Proizvod>();
            proizvodi.Add(new Proizvod()
            {
                naziv = "When Harry Met Sally",
                opis = "When Harry Met Sally",
                kategorija = "Romantic Comedy",
                proizvođač = "Romantic Comedy",
                dobavljač = "Romantic Comedy",
                cena = 7.99
            });
            proizvodi.Add(new Proizvod()
            {
                naziv = "When Harry Met Sally",
                opis = "When Harry Met Sally",
                kategorija = "Romantic Comedy",
                proizvođač = "Romantic Comedy",
                dobavljač = "Romantic Comedy",
                cena = 7.99
            });
            proizvodi.Add(new Proizvod()
            {
                naziv = "When Harry Met Sally",
                opis = "When Harry Met Sally",
                kategorija = "Romantic Comedy",
                proizvođač = "Romantic Comedy",
                dobavljač = "Romantic Comedy",
                cena = 7.99
            });
            proizvodi.Add(new Proizvod()
            {
                naziv = "When Harry Met Sally",
                opis = "When Harry Met Sally",
                kategorija = "Romantic Comedy",
                proizvođač = "Romantic Comedy",
                dobavljač = "Romantic Comedy",
                cena = 7.99
            });
            foreach (Proizvod proizvod in proizvodi)
                context.Proizvods.Add(proizvod);
                context.SaveChanges();
        }
    }
}

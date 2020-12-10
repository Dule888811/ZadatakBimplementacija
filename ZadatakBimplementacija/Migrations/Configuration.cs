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
          /*  context.Proizvods.AddOrUpdate( i => i.opis,
                new Proizvod
                {
                    naziv = "When Harry Met Sally",
                    opis = "When Harry",
                    kategorija = "Romantic Comedy",
                    proizvođač = "Romantic Comedy",
                    dobavljač = "Romantic Comedy",
                    cena = 7.99
                },
                   new Proizvod
                    {
                       naziv = "When Harry Met Sally",
                        opis = "When",
                        kategorija = "Romantic Comedy",
                        proizvođač = "Romantic Comedy",
                        dobavljač = "Romantic Comedy",
                        cena = 7.99
                    },
           new Proizvod
            {
               naziv = "When Harry Met Sally",
                opis = " Met Sally",
                kategorija = "Romantic Comedy",
                proizvođač = "Romantic Comedy",
                dobavljač = "Romantic Comedy",
                cena = 7.99
            },
           new Proizvod
            {
               naziv = "Sally",
                opis = "When Harry Met Sally",
                kategorija = "Romantic Comedy",
                proizvođač = "Romantic Comedy",
                dobavljač = "Romantic Comedy",
                cena = 7.99
            });

            context.SaveChanges();
            base.Seed(context); */
        }
        }
}
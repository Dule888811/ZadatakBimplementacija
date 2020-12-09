using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZadatakBimplementacija.Models
{
    public class Proizvod
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string naziv { get; set; }

       
        public string opis { get; set; }

        public string kategorija { get; set; }

        public string proizvođač { get; set; }


        public string dobavljač { get; set; }

        public double cena { get; set; }


    }
}
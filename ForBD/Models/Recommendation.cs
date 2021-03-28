using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForBD
{
    public class Recommendation
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Discipline))]
        public int DisciplineId { get; set; }

        [ForeignKey(nameof(Material))]
        public int MaterialId { get; set; }
        public int Amount { get; set; }

        public Discipline Discipline { get; set; }

        public Material Material { get; set; }
    }
}

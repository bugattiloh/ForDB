using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForBD.Models
{
    public class Recommendation
    {
        public int Id { get; set; }

        public int Amount { get; set; }
        
        [ForeignKey(nameof(Material))]
        public int MaterialId { get; set; }

        public Material Material { get; set; }

        [ForeignKey(nameof(Teacher))]
        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }

        [ForeignKey(nameof(Plan))]
        public int PlanId { get; set; }

        public Plan Plan { get; set; }
    }
}
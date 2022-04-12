using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForBD.Models
{
    public class MaterialPlan
    {
        [ForeignKey(nameof(EducationMaterial))]
        public int MaterialId { get; set; }

        [ForeignKey(nameof(Plan))]
        public int PlanId { get; set; }

        public Material EducationMaterial { get; set; }
        public Plan Plan { get; set; }
    }
}

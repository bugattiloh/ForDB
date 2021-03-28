using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForBD
{
    public class MaterialDiscipline
    {
        [ForeignKey(nameof(EducationMaterial))]
        public int MaterialId { get; set; }

        [ForeignKey(nameof(Discipline))]
        public int DisciplineId { get; set; }
        
        public Material EducationMaterial { get; set; }
        public Discipline Discipline { get; set; }
    }
}

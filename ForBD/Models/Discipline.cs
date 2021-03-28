using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForBD
{
    public class Discipline
    {
        public int DisciplineId { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public int Course { get; set; }

        [ForeignKey(nameof(MaterialDiscipline))]
        public int MaterialDisciplineId { get; set; }
        public MaterialDiscipline MaterialDiscipline { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ForBD
{
    public class MaterialDiscipline
    {
        public int MDID { get; set; }
        public ICollection<Material> EducationMaterials { get; set; }
        public ICollection<Discipline> Disciplines { get; set; }
    }
}

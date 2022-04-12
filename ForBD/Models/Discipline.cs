using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForBD.Models
{
    public class Discipline
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Specialty { get; set; }
        
        public int Course { get; set; }

        public ICollection<MaterialDiscipline> MaterialDisciplines { get; set; }
        
        
    }
}

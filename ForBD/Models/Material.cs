
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForBD
{
    public class Material
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Author { get; set; }
        
        public string Type { get; set; }

        public ICollection<MaterialDiscipline> MaterialDisciplines { get; set; }
    }
}

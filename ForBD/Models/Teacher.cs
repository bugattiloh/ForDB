using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForBD
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }


        [ForeignKey(nameof(Discipline))]
        public int DisciplineId { get; set; }

        public Discipline Discipline { get; set; }

    }
}

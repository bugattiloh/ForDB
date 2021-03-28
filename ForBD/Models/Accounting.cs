using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForBD
{
    public class Accounting
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Material))]
        public int MaterialId { get; set; }

        public Material Material { get; set; }

        public int InLibrary { get; set; }

        public int InDepartment { get; set; }

        public int Total { get; set; }

        [ForeignKey(nameof(Typography))]
        public int TypographyId { get; set; }

        public Typography Typography { get; set; }
    }
}
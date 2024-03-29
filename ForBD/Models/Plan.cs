﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForBD.Models
{
    public class Plan
    {
        public int Id { get; set; }

        public int ToLibrary { get; set; }
        
        public int ToDepartment { get; set; }

        public int Total { get; set; }

        public ICollection<Recommendation> Recommendations { get; set; }

        public ICollection<MaterialPlan> Materials { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.Data.SqlClient;

namespace ForBD.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Recommendation> Recommendations { get; set; }
        
        
    }
}
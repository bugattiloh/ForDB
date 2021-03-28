using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForBD
{
    public class Typography
    {
        public int Id { get; set; }

        public ICollection<Plan> Plans { get; set; }

        [ForeignKey(nameof(Accounting))]
        public int AccountingId { get; set; }

        public Accounting Accounting { get; set; }

        public string Stage { get; set; }
        
        public int Amount { get; set; }
    }
}

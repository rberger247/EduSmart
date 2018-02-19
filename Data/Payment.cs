using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduSmart.Data
{
    public class Payment
    {

        public int PaymentId { get; set; }
        [Required]
        public decimal Amount { get; set; }

        public DateTime DatePayed { get; set; }
    }
}

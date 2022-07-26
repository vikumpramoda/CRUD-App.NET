using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Seller
    {
        [Key]
        public int SellerId { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Email { get; set; }
        public string Fax { get; set; }
        public int Age { get; set; } = 0;
        public int Phone { get; set; } = 0;
    }
}

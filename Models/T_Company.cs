using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Models
{
    public class T_Company
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Lienversphoto { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Entities
{
    public class Apartment
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ApartmentId { get; set; }
        public byte Block { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public byte Floor { get; set; }
        public byte ApartmentNumber { get; set; }
        public string Owner { get; set; }
        public int ResidentId { get; set; }
    }
}

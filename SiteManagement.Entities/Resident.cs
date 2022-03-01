using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteManagement.Entities
{
    public class Resident
    {
        [Key,DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }
        public string TCNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string PlateNo { get; set; }
        public int ApartmentId { get; set; }
    }
}

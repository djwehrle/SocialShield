using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SocialShield.Models
{
    public class School
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [MaxLength(50)]
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(2)]
        public string State { get; set; }

        [Required]
        [MaxLength(5)]
        public string ZIP { get; set; }

        public virtual ICollection<UserSchool> UserSchools { get; set; }
    }
}
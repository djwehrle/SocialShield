using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SocialShield.Models
{
    public class User
    {
        [Key]
        public string ID { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public virtual ICollection<UserSchool> UserSchools { get; set; }
    }
}
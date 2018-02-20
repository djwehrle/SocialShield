using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialShield.Models
{
    public class UserSchool
    {
        [Key]
        [Column(Order = 0)]
        public string UserID { get; set; }

        public virtual User User { get; set; }

        [Key]
        [Column(Order = 1)]
        public string SchoolID { get; set; }

        public virtual School School { get; set; }
    }
}
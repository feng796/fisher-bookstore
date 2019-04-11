using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fisher.Bookstore.Models
{
    public class ApplicationUser
    {
        [NotMapped]
        [Required]
        [StringLength(100,MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password {get; set;}
        public object Email { get; internal set; }
        public object UserName { get; internal set; }
        public object Id { get; internal set; }
    }
}
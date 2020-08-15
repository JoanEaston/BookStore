using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage ="Name cannot be longer than 50 Characters")]
        [MinLength(2, ErrorMessage ="Name cannot be less than 2 Characters")]
        [Required]
        public String FirstName { get; set; }
        [MaxLength(50)]
        [MinLength(2)]
        [Required]
        public String LastName { get; set; }
        [EmailAddress]
        [Required]
        public String EmailAddress { get; set; }
        [Phone]
        [Required]
        public virtual List<PhoneNumber> PhoneNumbers { get; set; }
        public DateTime DateOfBirth { get; set; }
        [MaxLength(200)]
        [Required]
        public String HomeAddress { get; set; }
        public String Gender { get; set; }
        public virtual Comment Comment { get; set; }
        [MaxLength(200)]
        public String AvatarUrl { get; set; }
    }
}

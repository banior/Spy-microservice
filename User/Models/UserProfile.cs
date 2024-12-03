using System.ComponentModel.DataAnnotations;

namespace User.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string UserName { get; set; }

        [Required, MaxLength(255)]
        public string PasswordHash { get; set; }

        [Required, MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(255)]
        public string PhotoUrl { get; set; }

        [MaxLength(1000)]
        public string BioInfo { get; set; }

        public DateTime BirthDate { get; set; }

        [MaxLength(50)]
        public string Gender { get; set; }

        [MaxLength(255)]
        public string Location { get; set; }

        public DateTime CreatedAtDate { get; set; }

        [MaxLength(50)]
        public string Privacy { get; set; }

        [MaxLength(50)]
        public string Status { get; set; }

        public DateTime LastLoginTime { get; set; }

        public ICollection<UserFriend> Friends { get; set; }
    }
}

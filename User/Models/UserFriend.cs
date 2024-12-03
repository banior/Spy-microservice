using System.ComponentModel.DataAnnotations;

namespace User.Models
{
    public class UserFriend
    {
        [Key, Required]
        public int UserId { get; set; }
        public UserProfile User { get; set; }

        [Key, Required]
        public int FriendId { get; set; }
        public UserProfile Friend { get; set; }
    }
}
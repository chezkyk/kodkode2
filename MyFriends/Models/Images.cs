using System.ComponentModel.DataAnnotations;

namespace MyFriends.Models
{
    public class Images
    {
        [Key]
        public int Id { get; set; }
        public Friend friend { get; set; }

        [Display(Name = "MyImage")]
        public byte[] MyImage { get; set; }
    }
}

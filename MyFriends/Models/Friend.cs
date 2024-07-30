using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace MyFriends.Models
{
    public class Friend
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; } = string.Empty;


        [Display(Name = "LastName")]
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; } = string.Empty;


        [Display(Name = "PhoneNumber"), Phone(ErrorMessage = "PhoneNumber isn't valid")]
        public string PhoneNumber { get; set; }

        [Display(Name = "EmailAddress"), EmailAddress(ErrorMessage = "EmailAddress isn't valid")]
        public string EmailAddress { get; set; }

        public List<Images> images { get; set; }
        [Display(Name = "add image"), NotMapped]
        public IFormFile? setImage
        {
            get { return null; }
            set
            {
                if (value == null) return;
                AddImage(value);
            }
        }
        public Friend()
        {
            images = new List<Images>();
        }
        public void AddImage(byte[] img)
        {
            images.Add(new Images { MyImage = img, friend = this });
        }
        public void AddImage(IFormFile img)
        {
            MemoryStream stream = new MemoryStream();
            img.CopyTo(stream);
            AddImage(stream.ToArray());
        }










    }
}

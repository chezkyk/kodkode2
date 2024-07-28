using System.ComponentModel.DataAnnotations;

namespace MVCShoeShop.Models
{
    public class Friends
    {
        [Display(Name = "id")]
        [Required(ErrorMessage ="id is required")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "name is required")]
        public string Name { get; set; }

        [Display(Name = "age")]
        [Required(ErrorMessage = "age is required")]
        [Range(0,120)]
        public int Age { get; set; }
        public Friends() { }

        public Friends(int id, string name,int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}

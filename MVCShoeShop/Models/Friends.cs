namespace MVCShoeShop.Models
{
    public class Friends
    {
        public int Id { get; set; }
        public string Name { get; set; }
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

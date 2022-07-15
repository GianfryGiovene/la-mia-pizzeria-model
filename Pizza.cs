namespace LaMiaPizzeria
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public double Price { get; set; }

        public Pizza(string name, string description, string photoUrl, double price)
        {
            this.Name = name;
            this.Description = description;
            this.PhotoUrl = photoUrl;
            this.Price = price;
        }

    }
}

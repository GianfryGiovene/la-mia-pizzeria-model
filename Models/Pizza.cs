using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaMiaPizzeria.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public double Price { get; set; }
        public List<Ingrediente> IngredienteList { get; set; }

        public Pizza(string name, string description, string photoUrl, double price)
        {
            Name = name;
            Description = description;
            PhotoUrl = photoUrl;
            Price = price;
        }


        public void SetIngredienti(Ingrediente ingrediente1, Ingrediente ingrediente2, Ingrediente ingrediente3)
        {
            IngredienteList.Add(ingrediente1);
            IngredienteList.Add(ingrediente2);
            IngredienteList.Add(ingrediente3);
        }

        public void SetIngredienti(Ingrediente ingrediente1, Ingrediente ingrediente2)
        {
            IngredienteList.Add(ingrediente1);
            IngredienteList.Add(ingrediente2);
        }

        public void SetIngredienti(Ingrediente ingrediente1)
        {
            IngredienteList.Add(ingrediente1);
        }

    }
}

namespace WebApplication2.Models
{
    public class PanierFruit
    {
        public int Id { get; set; }
        public virtual ICollection<Fruit> Fruits { get; set; }
    }
}

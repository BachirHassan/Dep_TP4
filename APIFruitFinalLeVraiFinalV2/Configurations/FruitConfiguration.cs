using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Configurations
{
    public class FruitConfiguration : IEntityTypeConfiguration<Fruit>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Fruit> builder)
        {
            builder.ToTable("Fruit");

            builder.HasData(
                new Fruit
                {
                    Id = 4,
                    Nom = "Banane",
                    Couleur = "Jaune",
                    Origine = "Amérique du sud"
                },
                new Fruit
                {
                    Id = 5,
                    Nom = "Raisin",
                    Couleur = "Vert",
                    Origine = "Québec"
                },
                new Fruit
                {
                    Id = 6,
                    Nom = "Fraise",

                    Couleur = "Rouge",
                    Origine = "Californie"
                }
            );
        }
    }
}

using PetStore.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace PetStore.Data
{
    public static class DbInitializer
    {

        public static void Initialize(PetContext context)
        {
            context.Database.EnsureCreated();

            if (context.Pets.Any())
            {
                return;   // DB has been seeded
            }

            var pets = new Pet[]
            {
            new Pet{Name="Winnie",Description="Loves a big bowl of food! An independent dog with a lot of attitude but very sweet",Breed="Dachshund", Location="Kentucky",Price=100},
            new Pet{Name="Chica",Description="A loyal dog with a big heart.  Gets mad at times",Breed="Chihuahua", Location="Ohio",Price=200},
            new Pet{Name="Pipsqueak",Description="Found in a night box in Lake City.  He loves eating sausage and playing alligator",Breed="MaltiPoo", Location="Florida",Price=50},
            new Pet{Name="Rudy",Description="Loves going to the beach and chasing birds",Breed="MaltiPoo", Location="Michigan",Price=100},
            new Pet{Name="Mimi",Description="Shes",Breed="Chihuahua", Location="Michigan",Price=100},
            new Pet{Name="Bailey",Description="Loves people but does not want to be around other dogs",Breed="Lab", Location="Ohio",Price=50},
            new Pet{Name="Peanut",Description="This one has a lot of energy and kisses",Breed="Unknown", Location="Florida",Price=500},
            new Pet{Name="Hazel",Description="This one is squirmy and snuggly",Breed="Goldendoodle", Location="Georgia",Price=50},
            new Pet{Name="Midnight",Description="Does not like his tummy rubbed and likes to sneak out at night. Loves a good head rub",Breed="Unknown", Location="Florida",Price=50},
            new Pet{Name="Sasha",Description="Sweet and sassy",Breed="Ragdoll", Location="Iowa",Price=200},
            new Pet{Name="Ava",Description="Interested in the outside world.  Likes to have her own space",Breed="Uknown", Location="New York",Price=150 }
            };
            foreach (Pet p in pets)
            {
                context.Pets.Add(p);
            }
            context.SaveChanges();
        }
    }
}
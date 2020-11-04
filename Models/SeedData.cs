using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace greystore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Unicorn Cup",
                        Description = "Take your cute cup!",
                        Category = "Kitchen",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Pink Spoon",
                        Description = "Protective and fashionable",
                        Category = "Kitchen",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Pink Throw Pillow ",
                        Description = "FIFA-approved size and weight",
                        Category = "Bedroom",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Cheesecake Lover Tote Bag",
                        Description = "Shoulder Bag",
                        Category = "Fashion",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Large Makeup Brush Holder",
                        Description = "Flat-packed 35,000-seat stadium",
                        Category = "Fashion",
                        Price = 79500
                    },
                    new Product
                    {
                        Name = "Thinking Cap",
                        Description = "Improve brain efficiency by 75%",
                        Category = "Bedroom",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Unsteady Chair",
                        Description = "Secretly give your opponent a disadvantage",
                        Category = "Kitchen",
                        Price = 29.95m
                    },
                     new Product
                     {
                         Name = "Mobile Phone Light Clip Selfie LED ",
                         Description = "Auto Flash For Cell Phone Smartphone Round Portable Selfie Flashlight Makeup Mirror",
                         Category = "Fashion",
                         Price = 1200
                     },
                      new Product
                      {
                          Name = "Starbucks Inspired Cold Cup",
                          Description = "Coffee & Cannabis 20 oz. Starbucks Inspired Cold Cup",
                          Category = "Kitchen",
                          Price = 29.95m
                      },
                       new Product
                       {
                           Name = "Teddy Bear Plush Pug",
                           Description = "Children Toy, Plush Doll, Soft Plush Material",
                           Category = "Bedroom",
                           Price = 175
                       },
                        new Product
                        {
                            Name = "VERY BIG BED",
                            Description = "Not for children toy, if you know what I mean",
                            Category = "Bedroom",
                            Price = 2000000
                        }
                     );
                context.SaveChanges();
            }
        }
    }
}



namespace DataLayer.Persistence
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using DataLayer.Core.Model;


    public class DataSeeder : DropCreateDatabaseAlways<AmigooDbContext>
    {

        // Initialize Dummy Data for Test Purposes
        protected override void Seed(AmigooDbContext context)
        {

            SeedAccounts(context);

            SeedMenus(context);

            SeedMenuCategories(context);
        }

        private static void SeedMenus(AmigooDbContext context)
        {
            foreach (var menu in new Array[100])
            {
                var name = Guid.NewGuid().ToString().Substring(0,8);

                var price = new Random();

                var cID = new Random();

                context.Menus.Add(
                    new Menu
                    {
                        Acronym = name.Substring(0,3),
                        Availability = true,
                        CategoryId = cID.Next(1,10),
                        Flag = true,
                        Name = name,
                        Price = price.Next(50,100)
                    }
                 );
            }
        }


        private static void SeedMenuCategories(AmigooDbContext context)
        {
            for (int i = 1; i < 10; i++)
            {
                context.MenuCategories.Add(
                    new MenuCategory
                    {
                        Name = "Menu" + i
                    }
                );
            }
        }

        private static void SeedAccounts(AmigooDbContext context)
        {
            context.Accounts.Add(
                new Account
                {
                    FirstName = "kitchan",
                    LastName = "betsayda",
                    UserName = "chan",
                    UserLevel = UserType.Administrator,
                    UserPass = "123",
                    Flag = true,
                    CreationDate = DateTime.Now,
                    Rfid = "565657"
                }
            );
        }
    }
}

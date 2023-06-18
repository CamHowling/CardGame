using Microsoft.EntityFrameworkCore;
using System;

namespace CardGame.Database
{
    public static class DatabaseConfig
    {
        public static void Initialize(WebApplication application)
        {
            using (var serviceScope = application.Services.CreateScope())
            {
                Migrate(serviceScope.ServiceProvider.GetService<DatabaseContext>());
                InitializeData(serviceScope.ServiceProvider.GetService<DatabaseContext>());
            }
        }

        private static void Migrate(DatabaseContext context)
        {
            context.Database.Migrate();
        }

        private static void InitializeData(DatabaseContext context) 
        { 
            if (!context.Cards.Any())
            {
                //Populate the card list
            }

            context.SaveChanges();
        }
    }
}

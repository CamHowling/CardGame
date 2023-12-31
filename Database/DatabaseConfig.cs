﻿using Microsoft.EntityFrameworkCore;

namespace CardGame.Database
{
    public static class DatabaseConfig
    {
        public static void Initialize(WebApplication application)
        {
            using (var serviceScope = application.Services.CreateScope())
            {
                Migrate(serviceScope.ServiceProvider.GetService<DatabaseContext>());
            }
        }

        private static void Migrate(DatabaseContext context)
        {
            context.Database.Migrate();
        }
    }
}

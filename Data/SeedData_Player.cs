using RESTwithVue.Models;

namespace RESTwithVue.Data
{
    public class SeedData_Player
    {
        public static void Initialize(AppDbContext context)
        {
            if(!context.Players.Any())
            {
                context.Players.AddRange(
                    new Player
                    {
                        Id = 1,
                        Name = "Player",
                        Number = 50
                    },
                    new Player
                    {
                        Id = 2,
                        Name = "Computer",
                        Number = 30
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

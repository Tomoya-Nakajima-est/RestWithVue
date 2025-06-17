using RESTwithVue.Models;

namespace RESTwithVue.Data
{
    public class SeedData_Player
    {
        public static void Initialize(AppDbContext context)
        {
            if(!context.Players.Any())
            {
                context.Players.Add(new Player
                {
                    Id = 1,
                    Name = "Player",
                    Number = 50
                });
                context.SaveChanges();
            }
        }
    }
}

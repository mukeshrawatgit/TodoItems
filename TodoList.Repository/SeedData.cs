using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using TodoList.Model;

namespace TodoList.Data
{
    public class SeedData
    {
        public static async Task InitializeAsync(
          IServiceProvider services)
        {

            var userManager = services
                 .GetRequiredService<UserManager<User>>();
            await AddUser(userManager);
        }

        private static async Task AddUser(UserManager<User> userManager)
        {

            var testUser1 = new TodoList.Model.User
            {
                Email = "test",
                UserName = "test",

            };

            var testUser2 = new TodoList.Model.User
            {
                Email = "test1",
                UserName = "test1",

            };



            await userManager.CreateAsync(testUser1, "pwd123");
            await userManager.CreateAsync(testUser2, "pwd1231");

        }
    }
}


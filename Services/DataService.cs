using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TheBlogProject.Data;
using TheBlogProject.Enums;
using TheBlogProject.Models;

namespace TheBlogProject.Solution
{
    public class DataService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<BlogUser> _userManager;

       

        public DataService(ApplicationDbContext dbContext,
                            RoleManager<IdentityRole> roleManager,
                            UserManager<BlogUser> userManager)
        {
            _dbContext = dbContext;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task ManageDataAsync()
        {
            //task: create the Db from the Migrations 
            await _dbContext.Database.MigrateAsync();

            //task 1: seed a few roles into the system
            await SeedRolesAsync();

            //task 2: seed a few users into the system 
            await SeedUsersAsync();
        }

        private async Task SeedRolesAsync()
        {
            //if there are already Roles in the system, do nothing.
            if (_dbContext.Roles.Any())
            {
                return;
            }

            //otherwise we want to create a few roles 
            foreach (var role in Enum.GetNames(typeof(BlogRole)))
            {
                //I need to use the Role manager to create roles 
                await _roleManager.CreateAsync(new IdentityRole(role));

            }

        }

        private async Task SeedUsersAsync()
        {
            //if there are already users in the system, do nothing.
            if (_dbContext.Users.Any())
            {
                return;
            }


            //step 1: creates a new instance of BlogUser
            var adminUser = new BlogUser()
            {
                Email = "hagbeko89@gmail.com",
                UserName = "hagbeko89@gmail.com",
                FirstName = "Henry",
                LastName = "Agbeko",
                DisplayName = "TheGaffa",
                PhoneNumber = "0248110635",
                EmailConfirmed = true,
            };

            //step 2: use the UserManager to create a new user that is defined by the adminUser variable 
             await _userManager.CreateAsync(adminUser, "Abc12345@");
            
            //step 3: add this new user to the Administrator role 
            await _userManager.AddToRoleAsync(adminUser, BlogRole.Administrator.ToString());

            //an advanced way to do this will be to insert this in the appsettings.json file and then use an injected instance of configuration to pull the values out of our configuration file 
            //step 1 repeat: create the moderator user 
            var modUser = new BlogUser()
            {
                Email = "mandy89@gmail.com",
                UserName = "mandy89@gmail.com",
                FirstName = "Amanda",
                LastName = "Agbeko",
                DisplayName = "Bawse",
                PhoneNumber = "0242361050",
                EmailConfirmed = true,
            };

            await _userManager.CreateAsync(modUser, "Abc12345@");
            await _userManager.AddToRoleAsync(modUser, BlogRole.Administrator.ToString());
        }
    }
}



﻿namespace PersonalInformationSystem.Common.ConstantsModels
{
    public static  class SeedData
    {
        public static void Seed(UserManager<Personal> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        public static void SeedUsers(UserManager<Personal> userManager)
        {
            if (userManager.FindByNameAsync(ResultConstant.Admin_Email).Result == null)
            {
                var user = new Personal
                {
                    UserName = ResultConstant.Admin_Email,
                    Email = ResultConstant.Admin_Email
                };
                var result = userManager.CreateAsync(user, ResultConstant.Admin_Password).Result;
                if (result.Succeeded)
                    userManager.AddToRoleAsync(user, ResultConstant.Admin_Role);
            }
        }


        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync(ResultConstant.Admin_Role).Result)
            {
                var role = new IdentityRole
                {
                    Name = ResultConstant.Admin_Role
                };
                var result = roleManager.CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync(ResultConstant.Personal_Role).Result)
            {
                var role = new IdentityRole
                {
                    Name = ResultConstant.Personal_Role
                };
                var result = roleManager.CreateAsync(role).Result;
            }
        }
    }
}

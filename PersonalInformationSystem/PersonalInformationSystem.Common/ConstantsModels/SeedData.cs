namespace PersonalInformationSystem.Common.ConstantsModels
{
    public static class SeedData
    {
        public static void Seed(UserManager<Personal> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        public static void SeedUsers(UserManager<Personal> userManager)
        {/*
            if (userManager.FindByNameAsync(ResultConstant.Personal_Email).Result == null)
            {
                Personal user = new Personal();
                user.UserName = ResultConstant.Personal_Email;
                user.Email = ResultConstant.Personal_Email;
                IdentityResult result = userManager.CreateAsync(user, ResultConstant.Personal_Password).Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, ResultConstant.Personal_Email).Wait();
                }
            }*/

            if (userManager.FindByNameAsync(ResultConstant.Admin_Email).Result == null)
            {
                var user = new Personal
                {
                    UserName = ResultConstant.Admin_Email,
                    Email = ResultConstant.Admin_Email
                };

                IdentityResult result = userManager.CreateAsync(user, ResultConstant.Admin_Password).Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, ResultConstant.Admin_Role).Wait();
                }
            }
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync(ResultConstant.Admin_Role).Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = ResultConstant.Admin_Role;
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync(ResultConstant.Personal_Role).Result)
            {
                var role = new IdentityRole();
                role.Name = ResultConstant.Personal_Role;
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }
    }
}
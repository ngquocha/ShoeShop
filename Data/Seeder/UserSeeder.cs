using Microsoft.AspNetCore.Identity;
using ShoeShop.Models;

namespace ShoeShop.Data.Seeder
{
    public class UserSeeder
    {
        public UserSeeder(IApplicationBuilder applicationBuilder) {
            UsersAsync(applicationBuilder).Wait();
        }
        public async Task UsersAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                var adminUser = await userManager.FindByEmailAsync("nqha20902@gmail.com");
                if (adminUser == null)
                {
                    var address = new List<Address>
                    {
                        new Address
                        {
                            FullName = "Nguyen Quoc Ha",
                            Phone = "01234554321",
                            Email = "nqha20902@gmail.com",
                            SpecificAddress = "210 vo chi cong",
                            IsDefault = true
                        },
                        new Address
                        {
                            FullName = "Nguyen Van B",
                            Phone = "0369765342",
                            Email = "transinh342@gmail.com",
                            SpecificAddress = "An Duc, Hoai An, Binh Dinh"
                        }
                    };
                    var newAdminUser = new AppUser()
                    {
                        FullName = "Nguyễn Quốc Hà",
                        UserName = "hadim209",
                        Email = "nqha20902@gmail.com",
                        EmailConfirmed = true,
                        PhoneNumber = "0123456789",
                        ProfileImageUrl = "https://avatars.githubusercontent.com/u/45101901?v=4",
                        Status = true,
                        Gender = 0,
                        BirthDay = DateTime.Now,
                        Addresses = address,
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                var appUser = await userManager.FindByEmailAsync("musicanime2501@gmail.com");
                if (appUser == null)
                {
					var address = new List<Address>
					{
						new Address
						{
							FullName = "Nguyen Van A",
							Phone = "0387913347",
							Email = "hgba@gmail.com",
							SpecificAddress = "Tan Binh",
							IsDefault = true
						},
						new Address
						{
							FullName = "Nguyen Van B",
							Phone = "0369765342",
							Email = "hga@gmail.com",
							SpecificAddress = "An Duc, Hoai An, Binh Dinh"
						}
					};
					var newAppUser = new AppUser()
                    {
                        FullName = "Hoàng Gia Bảo",
                        UserName = "hgbaodev",
                        Email = "musicanime2501@gmail.com",
                        EmailConfirmed = true,
                        PhoneNumber = "0123456789",
                        ProfileImageUrl = "https://avatars.githubusercontent.com/u/120194990?v=4",
                        Status = true,
                        Gender = 0,
                        BirthDay = DateTime.Now,
						Addresses = address,
					};
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.Admin);
                }

                var appUser1 = await userManager.FindByEmailAsync("andinh1443@gmail.com");
                if (appUser == null)
                {
                    var newAppUser = new AppUser()
                    {
                        FullName = "Đinh Ngọc Ân",
                        UserName = "andinh1443",
                        Email = "andinh1443@gmail.com",
                        EmailConfirmed = true,
                        PhoneNumber = "0123456789",
                        ProfileImageUrl = "https://avatars.githubusercontent.com/u/120194990?v=4",
                        Status = true,
                        Gender = 0,
                        BirthDay = DateTime.Now,
					};
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.Admin);
                }
            }
        }
    }
}

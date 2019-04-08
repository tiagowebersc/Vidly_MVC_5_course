namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'278bb994-5203-4b80-b80a-fd56bc5511c1', N'admin@vidly.com', 0, N'AM5T4LzwHdUx+k3/Q8DnhU0+NuBKdq2XfNwQmQS3Qn7QH9Dh/vxMbvAhstLyBq3u0Q==', N'1f5d2a82-357e-43f3-985c-3570fcd7e7a4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'72ee7939-ea5e-46b4-9509-165c9c2698b6', N'guest@vidly.com', 0, N'AC0KSW9OVPN359r5GDEEhdN/FhEbLFOUcE/9dznoJqfJuqwv9Le3K17oQ5CYYTv6Eg==', N'8cd7a1f9-5dae-415b-85af-e02ff074f5f0', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3bae5556-4f70-4217-a62b-fcde31330bb7', N'CanManagerMovies')
                INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'278bb994-5203-4b80-b80a-fd56bc5511c1', N'3bae5556-4f70-4217-a62b-fcde31330bb7')"
                );
        }
        
        public override void Down()
        {
        }
    }
}

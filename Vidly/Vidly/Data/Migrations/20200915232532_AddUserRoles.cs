using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Data.Migrations
{
    public partial class AddUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //AspNetRoles
            migrationBuilder.Sql("INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8c60512e-a7c7-4231-8739-51b6a319d202', N'User', N'USER', N'908849ec-0eb7-495f-8fb4-a0b2eacf4675')");
            migrationBuilder.Sql("INSERT INTO[dbo].[AspNetRoles]([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES(N'9bb79076-25a4-47b8-a16a-bfd4a0a49981', N'SuperAdmin', N'SUPERADMIN', N'01a1ffe0-d214-47e0-a929-6938571da82a')");
            migrationBuilder.Sql("INSERT INTO[dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES(N'bd278c96-ee7a-4a52-8cdb-5251a1746197', N'Admin', N'ADMIN', N'89567ef2-a26f-4643-9c22-ed89b1815850')");


            //AspNetUser
            migrationBuilder.Sql("INSERT INTO[dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [DriverLicense]) VALUES(N'2851238d-131b-479f-b677-5113f1031ed2', N'SuperAdmin@gmail.com', N'SUPERADMIN@GMAIL.COM', N'SuperAdmin@gmail.com', N'SUPERADMIN@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEKk+a2/OVc4zif0M0dMk8ol/LHHO6X+28LaLYZPL2/88TNoF/w10UGC1XmAjt9qjAg==', N'QAMQX6Q7NTHP4FRH4RV2NCRAQBP7CV2X', N'2f955d78-5749-4b72-9c99-12e7905d1b1d', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', 2342342)");
            migrationBuilder.Sql("INSERT INTO[dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [DriverLicense]) VALUES(N'e654370e-9d75-4b67-aa8d-8bd0fe73587d', N'User@gmail.com', N'USER@GMAIL.COM', N'User@gmail.com', N'USER@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEFDIn3GB9ZRvYVwIVAMG0Le2XvsIEhqmeXjrW02uD5TnesMkohQOnCYc+YIQfOzT2w==', N'Q5DOGQBHAN5CL2QPPWKN5T5TRV3NCSXX', N'984969ca-0b70-4ccb-a73c-c6cc6e298453', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', 234231)");
            migrationBuilder.Sql("INSERT INTO[dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [DriverLicense]) VALUES(N'f1f73d60-7f22-461b-9525-4617c01b2a09', N'Admin@gmail.com', N'ADMIN@GMAIL.COM', N'Admin@gmail.com', N'ADMIN@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEJMi+lS/t8HDvrshteJCb/ZNafSL1TXjrmsFD3UupPq8UvRpwnaaT4fsu9gg03fUZA==', N'EGPBX546STHFNIX3FS63263Y3B2LUDDI', N'4c765ee5-0b43-4f13-91ac-7bf66fe399a2', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', 123423)");

            //AspNetUserRoles
            migrationBuilder.Sql("INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'e654370e-9d75-4b67-aa8d-8bd0fe73587d', N'8c60512e-a7c7-4231-8739-51b6a319d202')");
            migrationBuilder.Sql("INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'2851238d-131b-479f-b677-5113f1031ed2', N'9bb79076-25a4-47b8-a16a-bfd4a0a49981')");
            migrationBuilder.Sql("INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'f1f73d60-7f22-461b-9525-4617c01b2a09', N'bd278c96-ee7a-4a52-8cdb-5251a1746197')");

            


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

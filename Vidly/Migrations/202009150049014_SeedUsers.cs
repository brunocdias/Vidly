namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'356c8af3-d115-4ed3-8c6b-5e9e193f79d4', N'guest@vidly.com', 0, N'AJ+K3g7713lBEzEci4LvXzMJDnvvuVasukUyoPd+4XiS575yt/Vy0ZXo0KH+paf+AA==', N'b1a5f5ce-f948-4ebd-ab1d-b30eda37ffd9', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e9640202-f7df-49da-afc5-03e6607e2ed4', N'admin@vidly.com', 0, N'AKb5n6axaMrA6c1ly/Ikgja4lXzInMo8d6XJUXn57Xv4HTFEz/9B0u2UZU46OxlGGg==', N'70f11173-9a90-4c14-8f8f-3773d9e4b038', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9e11bd65-2cda-4f8d-819a-40244757e2fd', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e9640202-f7df-49da-afc5-03e6607e2ed4', N'9e11bd65-2cda-4f8d-819a-40244757e2fd')

");
        }

        public override void Down()
        {
        }
    }
}

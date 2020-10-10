using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCore_WebAPI.Migrations
{
    public partial class FinalSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { 1, new byte[] { 65, 110, 228, 72, 53, 243, 47, 62, 127, 218, 41, 226, 218, 175, 213, 118, 119, 228, 204, 196, 143, 75, 189, 131, 36, 92, 191, 73, 148, 14, 35, 146, 71, 62, 191, 170, 33, 162, 228, 1, 112, 93, 255, 99, 26, 51, 24, 156, 47, 74, 67, 129, 158, 68, 149, 214, 214, 224, 157, 94, 34, 80, 206, 164 }, new byte[] { 112, 123, 167, 68, 209, 25, 90, 110, 76, 189, 30, 91, 11, 226, 204, 222, 17, 1, 251, 82, 250, 194, 141, 221, 165, 214, 187, 246, 86, 105, 229, 252, 68, 153, 57, 136, 73, 65, 241, 25, 95, 141, 9, 45, 247, 8, 113, 103, 183, 18, 105, 195, 61, 96, 188, 111, 102, 203, 9, 46, 99, 127, 220, 15, 32, 95, 67, 117, 177, 70, 62, 64, 244, 9, 147, 194, 116, 47, 207, 75, 234, 236, 59, 119, 53, 94, 93, 49, 2, 75, 121, 189, 57, 120, 201, 185, 23, 163, 191, 248, 63, 214, 164, 121, 105, 6, 241, 177, 226, 233, 125, 63, 246, 58, 167, 19, 155, 123, 81, 136, 205, 54, 141, 152, 183, 110, 74, 25 }, "User1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { 2, new byte[] { 65, 110, 228, 72, 53, 243, 47, 62, 127, 218, 41, 226, 218, 175, 213, 118, 119, 228, 204, 196, 143, 75, 189, 131, 36, 92, 191, 73, 148, 14, 35, 146, 71, 62, 191, 170, 33, 162, 228, 1, 112, 93, 255, 99, 26, 51, 24, 156, 47, 74, 67, 129, 158, 68, 149, 214, 214, 224, 157, 94, 34, 80, 206, 164 }, new byte[] { 112, 123, 167, 68, 209, 25, 90, 110, 76, 189, 30, 91, 11, 226, 204, 222, 17, 1, 251, 82, 250, 194, 141, 221, 165, 214, 187, 246, 86, 105, 229, 252, 68, 153, 57, 136, 73, 65, 241, 25, 95, 141, 9, 45, 247, 8, 113, 103, 183, 18, 105, 195, 61, 96, 188, 111, 102, 203, 9, 46, 99, 127, 220, 15, 32, 95, 67, 117, 177, 70, 62, 64, 244, 9, 147, 194, 116, 47, 207, 75, 234, 236, 59, 119, 53, 94, 93, 49, 2, 75, 121, 189, 57, 120, 201, 185, 23, 163, 191, 248, 63, 214, 164, 121, 105, 6, 241, 177, 226, 233, 125, 63, 246, 58, 167, 19, 155, 123, 81, 136, 205, 54, 141, 152, 183, 110, 74, 25 }, "User2" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 1, 1, 0, 10, 0, 100, 10, "Frodo", 15, 1, 0 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 2, 2, 0, 5, 0, 100, 20, "Raistlin", 5, 2, 0 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 1, 1, 20, "The Master Sword" });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 2, 2, 5, "Crystal Wand" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

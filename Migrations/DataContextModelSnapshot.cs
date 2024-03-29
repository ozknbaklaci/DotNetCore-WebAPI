﻿// <auto-generated />
using System;
using DotNetCore_WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetCore_WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("DotNetCore_WebAPI.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Class")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defeats")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fights")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HitPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Intelligence")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Strength")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Victories")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Class = 1,
                            Defeats = 0,
                            Defense = 10,
                            Fights = 0,
                            HitPoints = 100,
                            Intelligence = 10,
                            Name = "Frodo",
                            Strength = 15,
                            UserId = 1,
                            Victories = 0
                        },
                        new
                        {
                            Id = 2,
                            Class = 2,
                            Defeats = 0,
                            Defense = 5,
                            Fights = 0,
                            HitPoints = 100,
                            Intelligence = 20,
                            Name = "Raistlin",
                            Strength = 5,
                            UserId = 2,
                            Victories = 0
                        });
                });

            modelBuilder.Entity("DotNetCore_WebAPI.Models.CharacterSkill", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkillId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharacterId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("CharacterSkills");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            SkillId = 2
                        },
                        new
                        {
                            CharacterId = 2,
                            SkillId = 1
                        },
                        new
                        {
                            CharacterId = 2,
                            SkillId = 3
                        });
                });

            modelBuilder.Entity("DotNetCore_WebAPI.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Damage = 30,
                            Name = "Fireball"
                        },
                        new
                        {
                            Id = 2,
                            Damage = 20,
                            Name = "Frenzy"
                        },
                        new
                        {
                            Id = 3,
                            Damage = 50,
                            Name = "Blizzard"
                        });
                });

            modelBuilder.Entity("DotNetCore_WebAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("Player");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = new byte[] { 65, 110, 228, 72, 53, 243, 47, 62, 127, 218, 41, 226, 218, 175, 213, 118, 119, 228, 204, 196, 143, 75, 189, 131, 36, 92, 191, 73, 148, 14, 35, 146, 71, 62, 191, 170, 33, 162, 228, 1, 112, 93, 255, 99, 26, 51, 24, 156, 47, 74, 67, 129, 158, 68, 149, 214, 214, 224, 157, 94, 34, 80, 206, 164 },
                            PasswordSalt = new byte[] { 112, 123, 167, 68, 209, 25, 90, 110, 76, 189, 30, 91, 11, 226, 204, 222, 17, 1, 251, 82, 250, 194, 141, 221, 165, 214, 187, 246, 86, 105, 229, 252, 68, 153, 57, 136, 73, 65, 241, 25, 95, 141, 9, 45, 247, 8, 113, 103, 183, 18, 105, 195, 61, 96, 188, 111, 102, 203, 9, 46, 99, 127, 220, 15, 32, 95, 67, 117, 177, 70, 62, 64, 244, 9, 147, 194, 116, 47, 207, 75, 234, 236, 59, 119, 53, 94, 93, 49, 2, 75, 121, 189, 57, 120, 201, 185, 23, 163, 191, 248, 63, 214, 164, 121, 105, 6, 241, 177, 226, 233, 125, 63, 246, 58, 167, 19, 155, 123, 81, 136, 205, 54, 141, 152, 183, 110, 74, 25 },
                            UserName = "User1"
                        },
                        new
                        {
                            Id = 2,
                            PasswordHash = new byte[] { 65, 110, 228, 72, 53, 243, 47, 62, 127, 218, 41, 226, 218, 175, 213, 118, 119, 228, 204, 196, 143, 75, 189, 131, 36, 92, 191, 73, 148, 14, 35, 146, 71, 62, 191, 170, 33, 162, 228, 1, 112, 93, 255, 99, 26, 51, 24, 156, 47, 74, 67, 129, 158, 68, 149, 214, 214, 224, 157, 94, 34, 80, 206, 164 },
                            PasswordSalt = new byte[] { 112, 123, 167, 68, 209, 25, 90, 110, 76, 189, 30, 91, 11, 226, 204, 222, 17, 1, 251, 82, 250, 194, 141, 221, 165, 214, 187, 246, 86, 105, 229, 252, 68, 153, 57, 136, 73, 65, 241, 25, 95, 141, 9, 45, 247, 8, 113, 103, 183, 18, 105, 195, 61, 96, 188, 111, 102, 203, 9, 46, 99, 127, 220, 15, 32, 95, 67, 117, 177, 70, 62, 64, 244, 9, 147, 194, 116, 47, 207, 75, 234, 236, 59, 119, 53, 94, 93, 49, 2, 75, 121, 189, 57, 120, 201, 185, 23, 163, 191, 248, 63, 214, 164, 121, 105, 6, 241, 177, 226, 233, 125, 63, 246, 58, 167, 19, 155, 123, 81, 136, 205, 54, 141, 152, 183, 110, 74, 25 },
                            UserName = "User2"
                        });
                });

            modelBuilder.Entity("DotNetCore_WebAPI.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Weapons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CharacterId = 1,
                            Damage = 20,
                            Name = "The Master Sword"
                        },
                        new
                        {
                            Id = 2,
                            CharacterId = 2,
                            Damage = 5,
                            Name = "Crystal Wand"
                        });
                });

            modelBuilder.Entity("DotNetCore_WebAPI.Models.Character", b =>
                {
                    b.HasOne("DotNetCore_WebAPI.Models.User", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DotNetCore_WebAPI.Models.CharacterSkill", b =>
                {
                    b.HasOne("DotNetCore_WebAPI.Models.Character", "Character")
                        .WithMany("CharacterSkill")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DotNetCore_WebAPI.Models.Skill", "Skill")
                        .WithMany("CharacterSkill")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DotNetCore_WebAPI.Models.Weapon", b =>
                {
                    b.HasOne("DotNetCore_WebAPI.Models.Character", "Character")
                        .WithOne("Weapon")
                        .HasForeignKey("DotNetCore_WebAPI.Models.Weapon", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _02_DAL.Context;

#nullable disable

namespace _02_DAL.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_01_Entity.Concrete.Food", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<double>("Calory")
                        .HasColumnType("float")
                        .HasColumnOrder(3);

                    b.Property<int>("FoodCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)")
                        .HasColumnOrder(2);

                    b.Property<double>("Portion")
                        .HasColumnType("float")
                        .HasColumnOrder(5);

                    b.HasKey("ID");

                    b.HasIndex("FoodCategoryID");

                    b.ToTable("Food", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Calory = 250.0,
                            FoodCategoryID = 1,
                            Name = "Ribeye",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 2,
                            Calory = 223.0,
                            FoodCategoryID = 1,
                            Name = "Tendeloin",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 3,
                            Calory = 252.0,
                            FoodCategoryID = 1,
                            Name = "Chicken",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 4,
                            Calory = 170.0,
                            FoodCategoryID = 2,
                            Name = "Trout",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 5,
                            Calory = 150.0,
                            FoodCategoryID = 2,
                            Name = "Anchovy",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 6,
                            Calory = 400.0,
                            FoodCategoryID = 3,
                            Name = "Cheddar Cheese ",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 7,
                            Calory = 360.0,
                            FoodCategoryID = 3,
                            Name = "Hellim Cheese",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 8,
                            Calory = 42.0,
                            FoodCategoryID = 5,
                            Name = "Tomatoes",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 9,
                            Calory = 42.0,
                            FoodCategoryID = 5,
                            Name = "Carrot",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 10,
                            Calory = 58.0,
                            FoodCategoryID = 4,
                            Name = "Apple",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 11,
                            Calory = 75.0,
                            FoodCategoryID = 4,
                            Name = "Plum",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 12,
                            Calory = 83.0,
                            FoodCategoryID = 9,
                            Name = "Mashed Potatoes",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 13,
                            Calory = 185.0,
                            FoodCategoryID = 9,
                            Name = "Rice Pilaf",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 14,
                            Calory = 69.0,
                            FoodCategoryID = 6,
                            Name = "White Bread",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 15,
                            Calory = 63.0,
                            FoodCategoryID = 6,
                            Name = "Brown Bread",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 16,
                            Calory = 225.0,
                            FoodCategoryID = 6,
                            Name = "Pogaca",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 17,
                            Calory = 167.0,
                            FoodCategoryID = 5,
                            Name = "Avacado",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 18,
                            Calory = 307.0,
                            FoodCategoryID = 6,
                            Name = "Pasta",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 19,
                            Calory = 193.0,
                            FoodCategoryID = 7,
                            Name = "Ice Cream",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 20,
                            Calory = 431.0,
                            FoodCategoryID = 7,
                            Name = "Chocolate Cake",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 21,
                            Calory = 0.0,
                            FoodCategoryID = 8,
                            Name = "Water",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 22,
                            Calory = 122.0,
                            FoodCategoryID = 8,
                            Name = "Cola",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 23,
                            Calory = 84.0,
                            FoodCategoryID = 8,
                            Name = "Milk",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 24,
                            Calory = 115.0,
                            FoodCategoryID = 4,
                            Name = "Olive",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 25,
                            Calory = 545.0,
                            FoodCategoryID = 10,
                            Name = "Milk Chocolate",
                            Portion = 1.0
                        },
                        new
                        {
                            ID = 26,
                            Calory = 536.0,
                            FoodCategoryID = 10,
                            Name = "Cips",
                            Portion = 1.0
                        });
                });

            modelBuilder.Entity("_01_Entity.Concrete.FoodCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)")
                        .HasColumnOrder(2);

                    b.HasKey("ID");

                    b.ToTable("FoodCategory", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Meat Product"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Sea Product"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Milk Product"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Fruit"
                        },
                        new
                        {
                            ID = 5,
                            Name = "VegeTable"
                        },
                        new
                        {
                            ID = 6,
                            Name = "Pastry"
                        },
                        new
                        {
                            ID = 7,
                            Name = "Dessert"
                        },
                        new
                        {
                            ID = 8,
                            Name = "Drink"
                        },
                        new
                        {
                            ID = 9,
                            Name = "Homemade Food"
                        },
                        new
                        {
                            ID = 10,
                            Name = "Snack"
                        });
                });

            modelBuilder.Entity("_01_Entity.Concrete.Meal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.HasKey("ID");

                    b.ToTable("Meal", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Breakfast"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Lunch"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Dinner"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Snack"
                        });
                });

            modelBuilder.Entity("_01_Entity.Concrete.SelectedFoodTransfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<double>("Calory")
                        .HasColumnType("float");

                    b.Property<DateTime>("DailyCalory")
                        .HasColumnType("datetime2");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SelectedFoodTransfers");
                });

            modelBuilder.Entity("_01_Entity.Concrete.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("_01_Entity.Concrete.UserMealFood", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int>("FoodID")
                        .HasColumnType("int");

                    b.Property<int>("MealID")
                        .HasColumnType("int");

                    b.Property<double>("Portion")
                        .HasColumnType("float");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FoodID");

                    b.HasIndex("MealID");

                    b.HasIndex("UserID");

                    b.ToTable("UserMealFood", (string)null);
                });

            modelBuilder.Entity("_01_Entity.Concrete.Food", b =>
                {
                    b.HasOne("_01_Entity.Concrete.FoodCategory", "FoodCategory")
                        .WithMany("Foods")
                        .HasForeignKey("FoodCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodCategory");
                });

            modelBuilder.Entity("_01_Entity.Concrete.UserMealFood", b =>
                {
                    b.HasOne("_01_Entity.Concrete.Food", "Food")
                        .WithMany("UserMealFoods")
                        .HasForeignKey("FoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_01_Entity.Concrete.Meal", "Meal")
                        .WithMany("UserMealFoods")
                        .HasForeignKey("MealID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_01_Entity.Concrete.User", "User")
                        .WithMany("UserMealFoods")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Meal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("_01_Entity.Concrete.Food", b =>
                {
                    b.Navigation("UserMealFoods");
                });

            modelBuilder.Entity("_01_Entity.Concrete.FoodCategory", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("_01_Entity.Concrete.Meal", b =>
                {
                    b.Navigation("UserMealFoods");
                });

            modelBuilder.Entity("_01_Entity.Concrete.User", b =>
                {
                    b.Navigation("UserMealFoods");
                });
#pragma warning restore 612, 618
        }
    }
}

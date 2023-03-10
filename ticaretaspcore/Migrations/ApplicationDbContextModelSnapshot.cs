// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ticaretaspcore.Models;

namespace ticaretaspcore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ticaretaspcore.Models.Admin", b =>
                {
                    b.Property<int>("admin_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Auth")
                        .HasColumnType("int");

                    b.Property<string>("pass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("users")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("admin_Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("ticaretaspcore.Models.Categories", b =>
                {
                    b.Property<int>("category_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("category_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("category_Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ticaretaspcore.Models.Products", b =>
                {
                    b.Property<int>("product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Categoriescategory_Id")
                        .HasColumnType("int");

                    b.Property<int>("category_Id")
                        .HasColumnType("int");

                    b.Property<string>("product_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product_Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("product_Price")
                        .HasColumnType("int");

                    b.Property<int>("product_Stock")
                        .HasColumnType("int");

                    b.HasKey("product_Id");

                    b.HasIndex("Categoriescategory_Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ticaretaspcore.Models.Products", b =>
                {
                    b.HasOne("ticaretaspcore.Models.Categories", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("Categoriescategory_Id");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("ticaretaspcore.Models.Categories", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

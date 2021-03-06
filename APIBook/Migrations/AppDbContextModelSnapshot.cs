// <auto-generated />
using System;
using APIBook.Date;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIBook.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APIBook.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateRead")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "JK Rowling",
                            DateRead = new DateTime(2021, 6, 24, 10, 51, 18, 392, DateTimeKind.Local).AddTicks(529),
                            Description = "Fun book to read",
                            Genre = "Fantasy",
                            Rate = 7,
                            Title = "Harry Potter"
                        },
                        new
                        {
                            Id = 2,
                            Author = "John Doe",
                            DateRead = new DateTime(2021, 6, 24, 10, 51, 18, 398, DateTimeKind.Local).AddTicks(1478),
                            Description = "Learning .net development",
                            Genre = "ICT",
                            Rate = 6,
                            Title = ".Net Core"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Stephen King",
                            DateRead = new DateTime(2021, 6, 24, 10, 51, 18, 398, DateTimeKind.Local).AddTicks(1519),
                            Description = "Shit your pants reading",
                            Genre = "Horror",
                            Rate = 9,
                            Title = "IT"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

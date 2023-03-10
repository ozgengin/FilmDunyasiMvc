// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcFilmDunyasi.Data;

#nullable disable

namespace MvcFilmDunyasi.Data.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    [Migration("20230206092258_TurEklendi")]
    partial class TurEklendi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FilmTur", b =>
                {
                    b.Property<int>("FilmlerId")
                        .HasColumnType("int");

                    b.Property<int>("TurlerId")
                        .HasColumnType("int");

                    b.HasKey("FilmlerId", "TurlerId");

                    b.HasIndex("TurlerId");

                    b.ToTable("FilmTur");
                });

            modelBuilder.Entity("MvcFilmDunyasi.Data.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<decimal>("Puan")
                        .HasPrecision(3, 1)
                        .HasColumnType("decimal(3,1)");

                    b.Property<int>("Yil")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Filmler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Fight Club",
                            Puan = 8.7m,
                            Yil = 1999
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Inception",
                            Puan = 8.7m,
                            Yil = 2010
                        },
                        new
                        {
                            Id = 3,
                            Ad = "The Maxtrix",
                            Puan = 8.7m,
                            Yil = 1999
                        },
                        new
                        {
                            Id = 4,
                            Ad = "Joker",
                            Puan = 8.3m,
                            Yil = 2019
                        },
                        new
                        {
                            Id = 5,
                            Ad = "Die Hard",
                            Puan = 8.2m,
                            Yil = 1988
                        },
                        new
                        {
                            Id = 6,
                            Ad = "Green Book",
                            Puan = 8.2m,
                            Yil = 2018
                        });
                });

            modelBuilder.Entity("MvcFilmDunyasi.Data.Tur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Turler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Aksiyon"
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Macera"
                        },
                        new
                        {
                            Id = 3,
                            Ad = "Animasyon"
                        },
                        new
                        {
                            Id = 4,
                            Ad = "Biyografi"
                        },
                        new
                        {
                            Id = 5,
                            Ad = "Komedi"
                        },
                        new
                        {
                            Id = 6,
                            Ad = "Suç"
                        },
                        new
                        {
                            Id = 7,
                            Ad = "Drama"
                        },
                        new
                        {
                            Id = 8,
                            Ad = "Aile"
                        },
                        new
                        {
                            Id = 9,
                            Ad = "Fantastik"
                        },
                        new
                        {
                            Id = 10,
                            Ad = "Siyah Beyaz"
                        },
                        new
                        {
                            Id = 11,
                            Ad = "Tarih"
                        },
                        new
                        {
                            Id = 12,
                            Ad = "Korku"
                        },
                        new
                        {
                            Id = 13,
                            Ad = "Müzik"
                        },
                        new
                        {
                            Id = 14,
                            Ad = "Müzikal"
                        },
                        new
                        {
                            Id = 15,
                            Ad = "Gizem"
                        },
                        new
                        {
                            Id = 16,
                            Ad = "Romantik"
                        },
                        new
                        {
                            Id = 17,
                            Ad = "Bilim Kurgu"
                        },
                        new
                        {
                            Id = 18,
                            Ad = "Gerilim"
                        },
                        new
                        {
                            Id = 19,
                            Ad = "Savaş"
                        },
                        new
                        {
                            Id = 20,
                            Ad = "Batı"
                        });
                });

            modelBuilder.Entity("FilmTur", b =>
                {
                    b.HasOne("MvcFilmDunyasi.Data.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcFilmDunyasi.Data.Tur", null)
                        .WithMany()
                        .HasForeignKey("TurlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

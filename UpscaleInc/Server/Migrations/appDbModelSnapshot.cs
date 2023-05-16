﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using upscaleInc.Server.Data;

#nullable disable

namespace UpscaleInc.Server.Migrations
{
    [DbContext(typeof(appDb))]
    partial class appDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UpscaleInc.Shared.login", b =>
                {
                    b.Property<string>("email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("email");

                    b.ToTable("logins");
                });

            modelBuilder.Entity("upscaleInc.Shared.customer_reviews", b =>
                {
                    b.Property<string>("email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("email");

                    b.ToTable("customer_Reviews");
                });

            modelBuilder.Entity("upscalrForeverInc.Shared.user", b =>
                {
                    b.Property<string>("email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("email");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}

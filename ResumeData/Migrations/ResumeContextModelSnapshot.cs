﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResumeData;

namespace ResumeData.Migrations
{
    [DbContext(typeof(ResumeContext))]
    partial class ResumeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ResumeData.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .IsRequired();

                    b.Property<int?>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("ResumeData.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectDescription");

                    b.Property<string>("ProjectGitHubLink");

                    b.Property<string>("ProjectName")
                        .IsRequired();

                    b.Property<int?>("ProjectVideoId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectVideoId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ResumeData.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProjectId");

                    b.Property<string>("TagName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("ResumeData.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<byte>("Role");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ResumeData.Models.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("YoutubeLink")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("ResumeData.Models.Picture", b =>
                {
                    b.HasOne("ResumeData.Models.Project")
                        .WithMany("Pictures")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("ResumeData.Models.Project", b =>
                {
                    b.HasOne("ResumeData.Models.Video", "ProjectVideo")
                        .WithMany()
                        .HasForeignKey("ProjectVideoId");
                });

            modelBuilder.Entity("ResumeData.Models.Tag", b =>
                {
                    b.HasOne("ResumeData.Models.Project")
                        .WithMany("Tags")
                        .HasForeignKey("ProjectId");
                });
#pragma warning restore 612, 618
        }
    }
}

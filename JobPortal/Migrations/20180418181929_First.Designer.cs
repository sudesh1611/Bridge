﻿// <auto-generated />
using JobPortal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace JobPortal.Migrations
{
    [DbContext(typeof(JobDbContext))]
    [Migration("20180418181929_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("JobPortal.Models.JobModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName");

                    b.Property<string>("JobDescription")
                        .IsRequired();

                    b.Property<string>("JobLocation")
                        .IsRequired();

                    b.Property<string>("JobSeekersID");

                    b.Property<string>("JobTitle")
                        .IsRequired();

                    b.Property<double>("MaxuimumAnnualSalaryInRupees");

                    b.Property<double>("MinimumAnnualSalaryInRupees");

                    b.Property<string>("PrimaryRole")
                        .IsRequired();

                    b.Property<int>("RecruiterID");

                    b.Property<string>("Skills")
                        .IsRequired();

                    b.Property<string>("WorkExperience")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Jobs");
                });
#pragma warning restore 612, 618
        }
    }
}

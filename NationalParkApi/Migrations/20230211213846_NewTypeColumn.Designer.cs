﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NationalParkApi.Models;

#nullable disable

namespace NationalParkApi.Migrations
{
    [DbContext(typeof(NationalParkApiContext))]
    [Migration("20230211213846_NewTypeColumn")]
    partial class NewTypeColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NationalParkApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DateEst")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            DateEst = "March 1, 1872",
                            Description = "Expansive park with large networks of geothermal areas including boiling mud pots, vividly colored hot springs such as Grand Prismatic Spring, geysers, yellow hued grand canyon of the Yellowstone river, mountians, and bounties of wildlife.",
                            Name = "Yellowstone",
                            State = "Wyoming",
                            Type = "national"
                        },
                        new
                        {
                            ParkId = 2,
                            DateEst = "September 25, 1890",
                            Description = "Home to the giant Sequoia forest, known for being the largest trees found in the world.",
                            Name = "Sequoia",
                            State = "California",
                            Type = "national"
                        },
                        new
                        {
                            ParkId = 3,
                            DateEst = "October 1, 1890",
                            Description = "Known for giant shear granit cliffs and exceptionally tall water falls, old growth forests, Noteable landmarks include: El Capitan, Half Dome, and the glacier carved Yosemite Valley",
                            Name = "Yosemite",
                            State = "California",
                            Type = "national"
                        },
                        new
                        {
                            ParkId = 4,
                            DateEst = "March 2, 1899",
                            Description = "Home to an active stratovolcano of the parks namesake. This park is also home to the contigous states longest and largest glacier. Popular for climbing, backpacking, hiking in its subalpine and alpine forests.",
                            Name = "Mount Rainer",
                            State = "Washington",
                            Type = "national"
                        },
                        new
                        {
                            ParkId = 5,
                            DateEst = "May 22, 1902",
                            Description = "Crater Lake lies in a caldera of an ancient volcano called Mount Mazama that collapsed 7,700 years ago. The lake is the deepest in the United States and is noted for its vivid blue water color and water clarity.",
                            Name = "Crater Lake",
                            State = "Oregon",
                            Type = "national"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
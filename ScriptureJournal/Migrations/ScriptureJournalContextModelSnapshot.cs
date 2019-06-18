﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScriptureJournal.Models;

namespace ScriptureJournal.Migrations
{
    [DbContext(typeof(ScriptureJournalContext))]
    partial class ScriptureJournalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ScriptureJournal.Models.Journal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                       b.Property<string>("Book")
                           .IsRequired()
                            .HasMaxLength(25);

                       b.Property<int>("Chapter");

                        b.Property<DateTime>("DateAdded");

                         b.Property<string>("Note")
                            .IsRequired()
                             .HasMaxLength(254);

                        b.Property<int>("Verse");

                        b.HasKey("ID");

                        b.ToTable("Journal");

                    /*
                    b.Property<string>("Book");

                    b.Property<int>("Chapter");

                    b.Property<int>("Verse");

                    b.Property<string>("Note");

                    b.Property<DateTime>("DateAdded");

                    b.HasKey("ID");

                    b.ToTable("Book");
                    */
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortalWeb.Data;

#nullable disable

namespace PortalWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230420075224_allowdub")]
    partial class allowdub
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PortalWeb.Models.App", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LogoUrl")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("RedirectUrl")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Secret")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasDefaultValueSql("(CONVERT([varchar](255),lower(newid())))");

                    b.Property<string>("TagLine")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__App__3214EC07333458BE");

                    b.HasIndex("UserId");

                    b.HasIndex(new[] { "Secret" }, "UQ__App__8F8373A15F0C10A3")
                        .IsUnique();

                    b.ToTable("App", (string)null);
                });

            modelBuilder.Entity("PortalWeb.Models.AuthServer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppId")
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte>("RouterId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Secret")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id")
                        .HasName("PK__AuthServ__3214EC07BE84E2DD");

                    b.HasIndex("AppId");

                    b.HasIndex("RouterId");

                    b.ToTable("AuthServer", (string)null);
                });

            modelBuilder.Entity("PortalWeb.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Country__3214EC074B60A19C");

                    b.HasIndex(new[] { "Code" }, "UQ__Country__A25C5AA777A1FCFD")
                        .IsUnique();

                    b.ToTable("Country", (string)null);
                });

            modelBuilder.Entity("PortalWeb.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Customer__3214EC07A2DEC2A0");

                    b.HasIndex("CountryId");

                    b.HasIndex("StateId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.HasIndex(new[] { "UserId" }, "UQ__Customer__1788CC4D9A0572E5");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("PortalWeb.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("InnerName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id")
                        .HasName("PK__Roles__3214EC076B821EC5");

                    b.HasIndex("AppId");

                    b.HasIndex(new[] { "Description" }, "UQ__Roles__4EBBBAC948F24140")
                        .IsUnique();

                    b.HasIndex(new[] { "Name" }, "UQ__Roles__737584F66775D866")
                        .IsUnique();

                    b.HasIndex(new[] { "InnerName" }, "UQ__Roles__73DA93DA7467410B")
                        .IsUnique();

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("PortalWeb.Models.Router", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id")
                        .HasName("PK__OAuthRou__3214EC07C90747E9");

                    b.ToTable("Router", (string)null);
                });

            modelBuilder.Entity("PortalWeb.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__States__3214EC07186FF386");

                    b.HasIndex("CountryId");

                    b.HasIndex(new[] { "StateId" }, "UQ__States__C3BA3B3B10ED8377")
                        .IsUnique();

                    b.ToTable("States");
                });

            modelBuilder.Entity("PortalWeb.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<byte>("LoginAttempt")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("OauthRouter")
                        .HasColumnType("tinyint")
                        .HasColumnName("OAuthRouter");

                    b.Property<string>("Password")
                        .HasMaxLength(8000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8000)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("WebGuid")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasDefaultValueSql("(CONVERT([varchar](255),lower(newid())))");

                    b.HasKey("Id")
                        .HasName("PK__Users__3214EC071AFDC7D1");

                    b.HasIndex("OauthRouter");

                    b.HasIndex(new[] { "WebGuid" }, "UQ__Users__C790C838BC861566")
                        .IsUnique();

                    b.HasIndex(new[] { "UserName" }, "UQ__Users__C9F28456C2BF0E2C")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PortalWeb.Models.UserInApp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__UserInAp__3214EC07FAD6493A");

                    b.HasIndex("AppId");

                    b.HasIndex("UserId");

                    b.ToTable("UserInApp", (string)null);
                });

            modelBuilder.Entity("PortalWeb.Models.UserInRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__UserInRo__3214EC0727C60F9D");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserInRoles");
                });

            modelBuilder.Entity("PortalWeb.Models.App", b =>
                {
                    b.HasOne("PortalWeb.Models.User", "User")
                        .WithMany("Apps")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__App__UserId__52593CB8");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortalWeb.Models.AuthServer", b =>
                {
                    b.HasOne("PortalWeb.Models.App", "App")
                        .WithMany("AuthServers")
                        .HasForeignKey("AppId")
                        .IsRequired()
                        .HasConstraintName("FK__AuthServe__AppId__6EF57B66");

                    b.HasOne("PortalWeb.Models.Router", "Router")
                        .WithMany("AuthServers")
                        .HasForeignKey("RouterId")
                        .IsRequired()
                        .HasConstraintName("FK__AuthServe__Route__6FE99F9F");

                    b.Navigation("App");

                    b.Navigation("Router");
                });

            modelBuilder.Entity("PortalWeb.Models.Customer", b =>
                {
                    b.HasOne("PortalWeb.Models.Country", "Country")
                        .WithMany("Customers")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK__Customer__Countr__36B12243");

                    b.HasOne("PortalWeb.Models.State", "State")
                        .WithMany("Customers")
                        .HasForeignKey("StateId")
                        .HasConstraintName("FK__Customer__StateI__37A5467C");

                    b.HasOne("PortalWeb.Models.User", "User")
                        .WithOne("Customer")
                        .HasForeignKey("PortalWeb.Models.Customer", "UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Customer__UserId__38996AB5");

                    b.Navigation("Country");

                    b.Navigation("State");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortalWeb.Models.Role", b =>
                {
                    b.HasOne("PortalWeb.Models.App", "App")
                        .WithMany("Roles")
                        .HasForeignKey("AppId")
                        .IsRequired()
                        .HasConstraintName("FK__Roles__AppId__5EBF139D");

                    b.Navigation("App");
                });

            modelBuilder.Entity("PortalWeb.Models.State", b =>
                {
                    b.HasOne("PortalWeb.Models.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .IsRequired()
                        .HasConstraintName("FK__States__CountryI__32E0915F");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("PortalWeb.Models.User", b =>
                {
                    b.HasOne("PortalWeb.Models.Router", "OauthRouterNavigation")
                        .WithMany("Users")
                        .HasForeignKey("OauthRouter")
                        .HasConstraintName("FK__Users__OAuthRout__2C3393D0");

                    b.Navigation("OauthRouterNavigation");
                });

            modelBuilder.Entity("PortalWeb.Models.UserInApp", b =>
                {
                    b.HasOne("PortalWeb.Models.App", "App")
                        .WithMany("UserInApps")
                        .HasForeignKey("AppId")
                        .IsRequired()
                        .HasConstraintName("FK__UserInApp__AppId__6C190EBB");

                    b.HasOne("PortalWeb.Models.User", "User")
                        .WithMany("UserInApps")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__UserInApp__UserI__6B24EA82");

                    b.Navigation("App");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortalWeb.Models.UserInRole", b =>
                {
                    b.HasOne("PortalWeb.Models.Role", "Role")
                        .WithMany("UserInRoles")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK__UserInRol__RoleI__68487DD7");

                    b.HasOne("PortalWeb.Models.User", "User")
                        .WithMany("UserInRoles")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__UserInRol__UserI__6754599E");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortalWeb.Models.App", b =>
                {
                    b.Navigation("AuthServers");

                    b.Navigation("Roles");

                    b.Navigation("UserInApps");
                });

            modelBuilder.Entity("PortalWeb.Models.Country", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("States");
                });

            modelBuilder.Entity("PortalWeb.Models.Role", b =>
                {
                    b.Navigation("UserInRoles");
                });

            modelBuilder.Entity("PortalWeb.Models.Router", b =>
                {
                    b.Navigation("AuthServers");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("PortalWeb.Models.State", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("PortalWeb.Models.User", b =>
                {
                    b.Navigation("Apps");

                    b.Navigation("Customer");

                    b.Navigation("UserInApps");

                    b.Navigation("UserInRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
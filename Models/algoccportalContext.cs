using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ContactList.Models
{
    public partial class algoccportalContext : DbContext
    {
        public algoccportalContext()
        {
        }

        public algoccportalContext(DbContextOptions<algoccportalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BlwlContactList> BlwlContactList { get; set; }
        public virtual DbSet<BlwlContactListGroup> BlwlContactListGroup { get; set; }
        public virtual DbSet<BlwlListType> BlwlListType { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=space\\sqlexpress;Initial Catalog=algoccportal;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<BlwlContactList>(entity =>
            {
                entity.HasKey(e => e.Pkey);

                entity.ToTable("blwl_contact_list");

                entity.Property(e => e.Pkey).HasColumnName("pkey");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(500);

                entity.Property(e => e.ContactListGroupPkey).HasColumnName("contact_list_group_pkey");

                entity.Property(e => e.From)
                    .HasColumnName("from")
                    .HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("phone_number")
                    .HasMaxLength(20);

                entity.Property(e => e.To)
                    .HasColumnName("to")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.ContactListGroupPkeyNavigation)
                    .WithMany(p => p.BlwlContactList)
                    .HasForeignKey(d => d.ContactListGroupPkey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__blwl_cont__conta__3B75D760");
            });

            modelBuilder.Entity<BlwlContactListGroup>(entity =>
            {
                entity.HasKey(e => e.Pkey)
                    .HasName("PK_blwl_ontact_list_group");

                entity.ToTable("blwl_contact_list_group");

                entity.Property(e => e.Pkey).HasColumnName("pkey");

                entity.Property(e => e.ListTypePkey).HasColumnName("list_type_pkey");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.ListTypePkeyNavigation)
                    .WithMany(p => p.BlwlContactListGroup)
                    .HasForeignKey(d => d.ListTypePkey)
                    .HasConstraintName("FK__blwl_cont__list___3C69FB99");
            });

            modelBuilder.Entity<BlwlListType>(entity =>
            {
                entity.HasKey(e => e.Pkey);

                entity.ToTable("blwl_list_type");

                entity.Property(e => e.Pkey).HasColumnName("pkey");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.Pkey);

                entity.ToTable("roles");

                entity.Property(e => e.Pkey).HasColumnName("pkey");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Pkey);

                entity.ToTable("users");

                entity.Property(e => e.Pkey).HasColumnName("pkey");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.RolesPkey).HasColumnName("roles_pkey");

                entity.HasOne(d => d.RolesPkeyNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RolesPkey)
                    .HasConstraintName("FK_users_roles");
            });
        }
    }
}

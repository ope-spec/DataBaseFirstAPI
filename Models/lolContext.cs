using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DbFirst.Models
{
    public partial class lolContext : DbContext
    {
        public lolContext()
        {
        }

        public lolContext(DbContextOptions<lolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Crm04> Crm04 { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) { }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Crm04>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("crm_04");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(1);

                entity.Property(e => e.Business)
                    .HasColumnName("business")
                    .HasMaxLength(1);

                entity.Property(e => e.BusinessType)
                    .IsRequired()
                    .HasColumnName("business_type")
                    .HasMaxLength(1);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(1);

                entity.Property(e => e.CompCode).HasColumnName("comp_code");

                entity.Property(e => e.Crncy).HasColumnName("crncy");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasMaxLength(1);

                entity.Property(e => e.CustomerType)
                    .IsRequired()
                    .HasColumnName("customer_type")
                    .HasMaxLength(1);

                entity.Property(e => e.DateRenewal)
                    .HasColumnName("date_renewal")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTermination)
                    .HasColumnName("date_termination")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1);

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(1);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(1);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InceptionDate)
                    .HasColumnName("inception_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotNum).HasColumnName("LOT_NUM");

                entity.Property(e => e.MaaturityDate)
                    .HasColumnName("maaturity_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaritalStatus)
                    .HasColumnName("marital_status")
                    .HasMaxLength(1);

                entity.Property(e => e.Marketer)
                    .HasColumnName("marketer")
                    .HasMaxLength(1);

                entity.Property(e => e.MarketerCode)
                    .HasColumnName("marketer_code")
                    .HasMaxLength(1);

                entity.Property(e => e.Occupation)
                    .HasColumnName("occupation")
                    .HasMaxLength(1);

                entity.Property(e => e.PartnerPartnerId).HasColumnName("partner_partner_id");

                entity.Property(e => e.PaymentFrequency)
                    .HasColumnName("payment_frequency")
                    .HasMaxLength(1);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(1);

                entity.Property(e => e.PolicyNo).HasColumnName("policy_no");

                entity.Property(e => e.PolicyNumber)
                    .HasColumnName("policy_number")
                    .HasMaxLength(1);

                entity.Property(e => e.Policyholder)
                    .HasColumnName("policyholder")
                    .HasMaxLength(1);

                entity.Property(e => e.PremiumAmount)
                    .HasColumnName("premium_amount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(1);

                entity.Property(e => e.ProductName)
                    .HasColumnName("product_name")
                    .HasMaxLength(1);

                entity.Property(e => e.ProposalNumber)
                    .HasColumnName("proposal_number")
                    .HasMaxLength(1);

                entity.Property(e => e.RefreshDate)
                    .HasColumnName("refresh_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SumInsured)
                    .HasColumnName("sum_insured")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnitName)
                    .HasColumnName("unit_name")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Sales>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sales");

                entity.Property(e => e.Demographic).HasMaxLength(50);

                entity.Property(e => e.ItemGroup).HasMaxLength(50);

                entity.Property(e => e.KitType).HasMaxLength(50);

                entity.Property(e => e.ProductCategory).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

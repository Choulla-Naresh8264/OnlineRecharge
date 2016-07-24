﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using OnlineRecharge.Models.Core.Data;

namespace OnlineRecharge.Models.Core.Mapping
{
    public class NationalRechargePaymentDetailMap : EntityTypeConfiguration<NationalRechargePaymentDetails>
    {
        public NationalRechargePaymentDetailMap()
        {
            //key  
            HasKey(t => t.ID);

            //fieds  
            Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.PaymentID).IsRequired().HasMaxLength(20).HasColumnType("nvarchar");
            Property(t => t.TrackID).IsRequired().HasMaxLength(20).HasColumnType("nvarchar");
            Property(t => t.TransID).IsRequired().HasMaxLength(20).HasColumnType("nvarchar");
            Property(t => t.Result).IsRequired().HasMaxLength(20).HasColumnType("nvarchar");
            Property(t => t.Ref).IsRequired().HasMaxLength(20).HasColumnType("nvarchar");
            //table  
            ToTable("NationalRechargePaymentDetails");

            //relationship  
            HasRequired(t => t.NationalRecharge).WithRequiredDependent(u => u.NationalRechargePaymentDetail);
          
        }
    }
}
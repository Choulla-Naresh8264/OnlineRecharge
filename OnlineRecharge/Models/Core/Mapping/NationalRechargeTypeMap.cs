﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using OnlineRecharge.Models.Core.Data;
namespace OnlineRecharge.Models.Core.Mapping
{
    public class NationalRechargeTypeMap : EntityTypeConfiguration<NationalRechargeTypes>
    {
        public NationalRechargeTypeMap()
        {
            //Key  
            HasKey(t => t.ID);

            //Fields  
            Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).IsRequired().HasMaxLength(20).HasColumnType("nvarchar");
            //table  
            ToTable("NationalRechargeTypes");
        }
    }
}
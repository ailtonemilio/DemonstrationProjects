﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class UnitStatusEntityConfiguration : EntityTypeConfiguration<UnitStatus>
    {
        public UnitStatusEntityConfiguration()
        {
            this.Property(e => e.StatusName)
            .IsUnicode(false);

            this.HasMany(e => e.UnitSource)
            .WithRequired(e => e.UnitStatus)
            .WillCascadeOnDelete(false);
        }
    }
}
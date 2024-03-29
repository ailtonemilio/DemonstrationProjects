﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class RelDistChangeReqScheduleDeclinedQtyEntityConfiguration : EntityTypeConfiguration<RelDistChangeReqScheduleDeclinedQty>
    {
        public RelDistChangeReqScheduleDeclinedQtyEntityConfiguration()
        {
            this.Property(e => e.DeclineStatus)
            .IsUnicode(false);

            this.Property(e => e.Notes)
             .IsUnicode(false);
        }
    }
}
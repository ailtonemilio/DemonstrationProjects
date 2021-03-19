using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class MinibookingEntityConfiguration : EntityTypeConfiguration<Minibooking>
    {
        public MinibookingEntityConfiguration()
        {
            this.Property(e => e.FreeTime)
            .IsUnicode(false);

            this.Property(e => e.BagProvider)
            .IsUnicode(false);

            this.Property(e => e.Tagging)
            .IsUnicode(false);

            this.Property(e => e.Bagtype)
            .IsUnicode(false);

            this.Property(e => e.AmountRequested)
            .IsUnicode(false);

            this.Property(e => e.SpecialMax)
            .IsUnicode(false);

            this.Property(e => e.BagWeight)
            .IsUnicode(false);

            this.Property(e => e.BagWeightUnit)
            .IsUnicode(false);

            this.Property(e => e.LotNumber)
            .IsUnicode(false);

            this.Property(e => e.SpecialInstrux)
            .IsUnicode(false);

            this.Property(e => e.SpecialInstruxNote)
            .IsUnicode(false);

            this.Property(e => e.GradeBy)
            .IsUnicode(false);

            this.Property(e => e.PhytosanitaryBy)
            .IsUnicode(false);

            this.Property(e => e.InspectionBy)
            .IsUnicode(false);

            this.Property(e => e.FumigationBy)
            .IsUnicode(false);

            this.Property(e => e.Other)
            .IsUnicode(false);

            this.Property(e => e.TerminalEffcFee)
            .IsUnicode(false);

            this.Property(e => e.CustomerReference)
            .IsUnicode(false);

            this.HasMany(e => e.GrainInvMinibookingAssignment)
            .WithRequired(e => e.Minibooking)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.GrainInvMinibookingTransaction)
            .WithRequired(e => e.Minibooking)
            .WillCascadeOnDelete(false);
        }
    }
}
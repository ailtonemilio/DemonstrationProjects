using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class FTPAccountEntityConfiguration : EntityTypeConfiguration<FTPAccount>
    {
        public FTPAccountEntityConfiguration()
        {
            this.Property(e => e.FTPHost)
            .IsUnicode(false);

            this.Property(e => e.FTPUser)
            .IsUnicode(false);

            this.Property(e => e.FTPUserId)
            .IsUnicode(false);

            this.Property(e => e.FTPPassword)
            .IsUnicode(false);

            this.Property(e => e.CertificateFingerPrint)
            .IsUnicode(false);
        }
    }
}
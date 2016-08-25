using NFine.Domain._03_Entity.SR;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Mapping.SR
{
    public class T_SR_SRINFOMap:EntityTypeConfiguration<T_SR_SRINFOEntity>
    {
        public T_SR_SRINFOMap()
        {
            this.ToTable("T_SR_SRINFO");
            this.HasKey(t => t.OID);
        }
    }
}

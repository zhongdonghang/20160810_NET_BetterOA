using NFine.Domain._03_Entity.SR;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Mapping.SR
{
    public class T_SR_ITEMINFOMap : EntityTypeConfiguration<T_SR_ITEMINFOEntity>
    {
        public T_SR_ITEMINFOMap()
        {
            this.ToTable("T_SR_ITEMINFO");
            this.HasKey(t => t.OID);
        }
    }
}

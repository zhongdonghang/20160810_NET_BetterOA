using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain._03_Entity.SR
{
    public class T_SR_FILESEntity
    {
        public int OID { get; set; }
        public string OLD_NAME { get; set; }
        public string NEW_NAME { get; set; }
        public string FILE_PATH { get; set; }
        public DateTime CRD_TIME { get; set; }
        public string CRD_BY { get; set; }
        public int SR_OID { get; set; }
        public int ITEM_OID { get; set; }
        public string ITEM_NAME { get; set; }
        public string STATUS { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain._03_Entity.SR
{
    public class T_SR_ITEMINFOEntity
    {
        public int OID { get; set; }
        public string ITEM_NAME { get; set; }
        public string ITEM_MANAGER { get; set; }
        public DateTime ITEM_CRDTIME { get; set; }
        public string ITEM_LINKER { get; set; }
        public string ITEM_LINK_PHONE { get; set; }
        public string ITEM_MEMO { get; set; }
        public string LOGIN_NAME { get; set; }
    }
}

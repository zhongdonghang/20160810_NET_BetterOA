using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain._03_Entity.SR
{
    public class T_SR_SRINFOEntity
    {
        public int OID { get; set; }
        public DateTime CRD_TIME { get; set; }
        public string LINK_MAN { get; set; }
        public string LINK_PHONE { get; set; }
        public string ITEM_NAME { get; set; }
        public int ITEMOID { get; set; }
        public string TITLE { get; set; }
        public string SR_DESC { get; set; }
    //    public string SR_FILE { get; set; }
        public string LOGIN_NAME { get; set; }
    }
}

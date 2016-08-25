using NFine.Code;
using NFine.Domain._03_Entity.SR;
using NFine.Domain._04_IRepository.SR;
using NFine.Repository.SR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Application.SR
{
    public class T_SR_ITEMINFOApp
    {
        private IT_SR_ITEMINFORepository service = new T_SR_ITEMINFORepository();

        public List<T_SR_ITEMINFOEntity> GetList( string loginName,string keyword = "")
        {
            var expression = ExtLinq.True<T_SR_ITEMINFOEntity>();
            expression = expression.And(t => t.LOGIN_NAME.Equals(loginName));
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.ITEM_NAME.Contains(keyword));
            }
          //  expression = expression.And(t => t.F_Category == 1);
            return service.IQueryable(expression).OrderBy(t => t.OID).ToList();
        }
    }
}

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
    public class T_SR_SRINFOApp
    {
        private IT_SR_SRINFORepository service = new T_SR_SRINFORepository();

        public void SubmitForm(T_SR_SRINFOEntity objT_SR_SRINFO, string keyValue)
        {
            service.Insert(objT_SR_SRINFO);
        }

        public T_SR_SRINFOEntity GetForm(string keyValue)
        {
            return service.FindEntity(int.Parse(keyValue));
        }

        /// <summary>
        /// 根据当前用户取出需求列表
        /// </summary>
        /// <param name="pagination"></param>
        /// <param name="keyword"></param>
        /// <param name="LOGIN_NAME"></param>
        /// <returns></returns>
        public List<T_SR_SRINFOEntity> GetList(Pagination pagination, string keyword,string LOGIN_NAME)
        {
            var expression = ExtLinq.True<T_SR_SRINFOEntity>();
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.TITLE.Contains(keyword));
            }
            expression = expression.And(t => t.LOGIN_NAME == LOGIN_NAME);
            return service.FindList(expression, pagination);
        }

        /// <summary>
        /// 获取当前所有已经提的需求
        /// </summary>
        /// <param name="pagination"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<T_SR_SRINFOEntity> GetList(Pagination pagination, string keyword)
        {
            var expression = ExtLinq.True<T_SR_SRINFOEntity>();
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.TITLE.Contains(keyword));
            }
          //  expression = expression.And(t => t.LOGIN_NAME == LOGIN_NAME);
            return service.FindList(expression, pagination);
        }

    }
}

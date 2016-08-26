using NFine.Application.SR;
using NFine.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.SR.Controllers
{
    public class SRAllListController : ControllerBase
    {
        private T_SR_ITEMINFOApp objT_SR_ITEMINFOApp = new T_SR_ITEMINFOApp();
        private T_SR_SRINFOApp objT_SR_SRINFOApp = new T_SR_SRINFOApp();
        //
        // GET: /SR/SRAllList/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取全部需求列表
        /// </summary>
        /// <param name="pagination"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJsonAll(Pagination pagination, string keyword)
        {
            var data = new
            {
                rows = objT_SR_SRINFOApp.GetList(pagination, keyword),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

    }
}

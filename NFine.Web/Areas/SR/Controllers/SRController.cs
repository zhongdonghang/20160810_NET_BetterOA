using NFine.Application.SR;
using NFine.Code;
using NFine.Domain._03_Entity.SR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.SR.Controllers
{
    public class SRController : ControllerBase
    {
        private T_SR_ITEMINFOApp objT_SR_ITEMINFOApp = new T_SR_ITEMINFOApp();
        private T_SR_SRINFOApp objT_SR_SRINFOApp = new T_SR_SRINFOApp();
        //
        // GET: /SR/SR/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetItemGridJson(string keyword)
        {
            OperatorModel currentOperater = OperatorProvider.Provider.GetCurrent();
            var data = objT_SR_ITEMINFOApp.GetList(currentOperater.UserName,keyword);
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string keyword)
        {
            OperatorModel currentOperater = OperatorProvider.Provider.GetCurrent();
            var data = new
            {
                rows = objT_SR_SRINFOApp.GetList(pagination, keyword, currentOperater.UserName),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

  

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = objT_SR_SRINFOApp.GetForm(keyValue);
            return Content(data.ToJson());
        }

        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(T_SR_SRINFOEntity objT_SR_SRINFOEntity, string keyValue)
        {
            //处理上传文件
           HttpPostedFileBase file = Request.Files["SR_FILE"];
            if (file != null)
            {
                    
            }

            OperatorModel currentOperater = OperatorProvider.Provider.GetCurrent();
            objT_SR_SRINFOEntity.LOGIN_NAME = currentOperater.UserName;
            objT_SR_SRINFOEntity.ITEMOID = int.Parse(objT_SR_SRINFOEntity.ITEM_NAME);

            objT_SR_SRINFOEntity.ITEM_NAME = objT_SR_ITEMINFOApp.Get(objT_SR_SRINFOEntity.ITEMOID).ITEM_NAME;

            objT_SR_SRINFOApp.SubmitForm(objT_SR_SRINFOEntity, "");
            return Success("操作成功。");
        }

    }
}

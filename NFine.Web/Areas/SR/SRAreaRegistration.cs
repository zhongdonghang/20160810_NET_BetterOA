using System.Web.Mvc;

namespace NFine.Web.Areas.SR
{
    public class SRAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "SR";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "SR_default",
                "SR/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

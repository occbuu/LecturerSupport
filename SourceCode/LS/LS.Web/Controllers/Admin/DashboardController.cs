using System.Web.Mvc;

namespace LS.Web.Controllers
{
    /// <summary>
    /// Dashboard controller
    /// </summary>
    public class DashboardController : BaseController
    {
        #region -- Views --

        public ActionResult Index()
        {
            return View();
        }

        #endregion

        #region -- Helper --

        #endregion
    }
}
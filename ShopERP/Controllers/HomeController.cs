namespace InitERP.Controllers
{
    using ShopERP.Models;
    using ShopERP.Models.Common;
    using System.Linq;
    using System.Web.Mvc;

    /// <summary>
    /// Defines the <see cref="HomeController" />.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// The Index.
        /// </summary>
        /// <returns>The <see cref="ActionResult"/>.</returns>
        public ActionResult Index()
        {
            using (ERPDBEntities db = new ERPDBEntities())
            {
                if (!db.Product.Any())
                {
                    InitDB.InitProduct();
                }

                if (!db.Staff.Any())
                {
                    InitDB.InitStaff();
                }

                if (!db.schedule.Any())
                {
                    InitDB.InitSchedule();
                }

                if (!db.WorkTime.Any())
                {
                    InitDB.InitWorkTime();
                }

                if (!db.Sell_Record.Any())
                {
                    InitDB.InitSellRecord();
                }

                if (!db.Inventory.Any())
                {
                    InitDB.InitInventory();
                }

                if (!db.Staff_Auth.Any())
                {
                    InitDB.InitStaffAuth();
                }
            }
            return View();
        }
    }
}

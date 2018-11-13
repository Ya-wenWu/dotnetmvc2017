using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspdotnetmvc.Controllers
{
    public class ComputerController : Controller
    {
        // GET: Computer
		/// <summary>
		/// 首頁－Socket
		/// </summary>
		/// <returns></returns>
        public ActionResult Index()
        {
            return View(new ComputerViewModels());
        }
		/// <summary>
		/// 登入頁面
		/// </summary>
		/// <param name="cv"></param>
		public ActionResult　Login(ComputerViewModels cv) {
			ComputerModel cm = new ComputerModel();
			cv.AGE = cm.GetAge(cv);
			return View(cv);
		}
    }
}
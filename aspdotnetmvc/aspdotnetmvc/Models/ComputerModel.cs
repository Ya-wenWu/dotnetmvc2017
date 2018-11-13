using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspdotnetmvc.Models
{
	public class ComputerModel
	{
		/// <summary>
		/// 計算年紀
		/// </summary>
		/// <param name="cv"></param>
		/// <returns></returns>
		public int GetAge(ComputerViewModels cv) {
			DateTime birthday = cv.BIRTHDAY;
			DateTime today = DateTime.Today;
			return today.Year - birthday.Year;
		}
	}
}
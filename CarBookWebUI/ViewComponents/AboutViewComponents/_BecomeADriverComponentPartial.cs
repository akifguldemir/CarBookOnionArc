﻿using Microsoft.AspNetCore.Mvc;

namespace CarBookWebUI.ViewComponents.AboutViewComponents
{
	public class _BecomeADriverComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View(); 
		}
	}
}

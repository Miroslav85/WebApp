using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleService;
using VehicleService.DBasa;

namespace VehicleMVC.Controllers
{
	public class VehicleMakeController : Controller
	{
		// GET: VehicleMake
		public ActionResult Index()
		{
			
			
			var vMake = ServiceMake.Instance().GetAllVMake();
			return View(vMake);


		}

		// GET: VehicleMake/Details/5
		public ActionResult Details(int id)
		{
			
			
			return View(ServiceMake.Instance().DetailsVMake(id));
		}

		// GET: VehicleMake/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: VehicleMake/Create
		[HttpPost]
		public ActionResult Create(VehicleMake vm)
		{
			ServiceMake.Instance().AddVehicleMake(vm);

			return View();
		}

		// GET: VehicleMake/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: VehicleMake/Edit/5
		[HttpPost]
		public ActionResult Edit( VehicleMake vm)
		{

			ServiceMake.Instance().EditVMake(vm);
			return View();
		}

		// GET: VehicleMake/Delete/5
		public ActionResult Delete()
		{
			return View();
		}

		// POST: VehicleMake/Delete/5
		[HttpPost]
		public ActionResult Delete(int id)
		{
			ServiceMake.Instance().DeleteVehicleMake(id);

			return View();
		}
	}
}

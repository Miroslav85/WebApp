using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

using VehicleService;
using VehicleService.DBasa;


namespace VehicleMVC.Controllers
{
	public class VehicleModelController : Controller
	{
		// GET: VehicleModel
		public ActionResult Index()
		{
			var vModel=ServiceModel.Instance().GetAllVModel();
			return View(vModel);
		}

		// GET: VehicleModel/Details/5
		
		public ActionResult Details(int id)
		{
			
			return View(ServiceModel.Instance().DetailsVModel(id));
		}

		// GET: VehicleModel/Create
		public ActionResult Create()
		{
			ViewBag.MakeId = new SelectList( ServiceModel.ListVMake, "Id", "Name");
			return View();
		}

		// POST: VehicleModel/Create
		
		
		[HttpPost]
		public ActionResult Create([Bind(Include = "Id,MakeId,Name")] VehicleModel vehicleModel)
		{
			ServiceModel.Instance().AddVehicleModel(vehicleModel);

			return View();

		}

		// GET: VehicleModel/Edit/5
		public ActionResult Edit(int id)
		{
			
			VehicleModel VModel = new VehicleModel();
			VModel= ServiceModel.Instance().FindByID(id);
			ViewBag.MakeId = new SelectList(ServiceModel.ListVMake, "Id", "Name");
			return View(VModel);
		}

	//	POST: VehicleModel/Edit/5
		[HttpPost]
		public ActionResult Edit([Bind(Include = "Id,MakeId,Name")]VehicleModel VModel)
		{
			if (ModelState.IsValid)
			{
				ServiceModel.Instance().EditVModel(VModel);
				return RedirectToAction("Index");
			}

			ViewBag.MakeId = new SelectList(ServiceModel.ListVMake, "Id", "Name", VModel.MakeId);
			

			return View(VModel);

		}

		// GET: VehicleModel/Delete/5
		public ActionResult Delete()
		{
			
			return View();

		}

		
		[HttpPost]

		public ActionResult Delete(int id)
		{

			ServiceModel.Instance().DeleteVehicleModel(id);

			return View();


		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleService.DBasa;

namespace VehicleService
{
 public	class ServiceModel
	{

		public static List<VehicleMake> ListVMake = new List<VehicleMake>();
		public static List<VehicleModel> ListVModel = new List<VehicleModel>();
		
		private static VehicleModel vehicleModel;
		private static ServiceModel instance=null;
		static vjezbaEntities db;


		private ServiceModel()
		{
		}




		public static ServiceModel Instance()
		{

			if (instance == null)
			{
				instance = new ServiceModel();
			}
			return instance;



		}


		public  List<VehicleModel> GetAllVModel()
		{

			using (db = new vjezbaEntities())
			{
				ListVModel = db.VehicleModel.ToList();
				ListVMake = db.VehicleMake.ToList();

			}

			return ListVModel;
		}

		public  VehicleModel DetailsVModel(int id)
		{

			using (db = new vjezbaEntities())
			{
				db.VehicleModel.ToList();
				db.VehicleMake.ToList();
				vehicleModel = new VehicleModel();
				vehicleModel = db.VehicleModel.Find(id);

				return vehicleModel;

			}
		}

		public  void AddVehicleModel(VehicleModel vehiceMod)
		{
			using (db = new vjezbaEntities())
			{


				db.VehicleModel.Add(vehiceMod);
				db.SaveChanges();

			}
		}

		public  void DeleteVehicleModel(int VModelId)
		{

			using (db = new vjezbaEntities())
			{
				vehicleModel = new VehicleModel();
				vehicleModel = db.VehicleModel.Find(VModelId);

				db.VehicleModel.Remove(vehicleModel);
				db.SaveChanges();
			}
		}

		public  VehicleModel FindByID(int id)
		{
			vehicleModel = new VehicleModel();
			using (db = new vjezbaEntities())
			{
				vehicleModel = db.VehicleModel.Find(id);
			}
			return vehicleModel;
		}
		public  void EditVModel(VehicleModel VModel)
		{

			using (db = new vjezbaEntities())
			{

				db.Entry(VModel).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();

			}
		}
	}
}

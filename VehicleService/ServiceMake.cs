using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleService.DBasa;

namespace VehicleService
{
	public class ServiceMake
	{
		public static List<VehicleMake> ListVMake = new List<VehicleMake>();
		public static List<VehicleModel> ListVModel = new List<VehicleModel>();
		private static VehicleMake vehicleMake ;
		private static VehicleModel vehicleModel;
		private static ServiceMake instance=null;
	 static vjezbaEntities db ;

		private ServiceMake()
		{
		}

		public static ServiceMake Instance()
		{

			if (instance == null)
			{
				instance = new ServiceMake();
			}
			return instance;



		}


		public  VehicleMake DetailsVMake(int id)
		{

			using (db=new vjezbaEntities())
			{
				vehicleMake = new VehicleMake();
				ListVMake = db.VehicleMake.ToList();
			vehicleMake=db.VehicleMake.Find(id);
				return vehicleMake;
				
			}
		}

		public   void AddVehicleMake(VehicleMake VehiceM)
		{
			using (db=new vjezbaEntities())
			{
				db.VehicleMake.Add(VehiceM);
				db.SaveChanges();
				ListVMake.Add(VehiceM);
			}
		}

		public  List< VehicleMake> GetAllVMake()
		{
			List<VehicleMake> Vm = new List<VehicleMake>();
			using (db=new vjezbaEntities())
			{
				Vm = db.VehicleMake.ToList();
			}
			return Vm;
		}
		public  void DeleteVehicleMake( int VMakeId)
		{
			
			using (db = new vjezbaEntities())
			{
				vehicleMake = new VehicleMake();
				vehicleMake= db.VehicleMake.Find(VMakeId);

				db.VehicleMake.Remove(vehicleMake);
				db.SaveChanges();
			}
		}

		public  void EditVMake(VehicleMake VMake)
		{
			

			using (db=new vjezbaEntities())
			{
				db.Entry(VMake).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}

		


	}
}

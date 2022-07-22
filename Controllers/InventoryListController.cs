using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebNDTIT01.Models;
using Microsoft.AspNetCore.Authorization;

namespace WebNDTIT01.Controllers
{
    public class InventoryListController :Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly ndt_dbContext db;
        public InventoryListController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /*public InventoryListController(ndt_dbContext context)
        {
            db = context;
        }*/

        [Authorize(Roles = "Administrator")]
        public IActionResult ComputerList()
        {
            var db = new ndt_dbContext();
            var rslt = (  from cl in db.TbComputerLists
                            join usr in db.TbUsers on cl.UserId equals usr.IdUser into usrs 
                            from rsusr in usrs.DefaultIfEmpty()
                            join mt in db.TbMonitorLists on cl.MonitorId equals mt.IdMonitorList into mts
                            from rsmt in mts.DefaultIfEmpty()
                            join cpasst in db.TbComputerAssetNos on cl.AssetNo equals cpasst.IdComputerAssetNo into cpassts
                            from rscpasst in cpassts.DefaultIfEmpty()
                            where cl.DataUpdate < DateTime.Now.AddDays(-5)
                            orderby cl.DataUpdate
                            select new GetAll
                            {
                               ComputerName = cl.ComputerName,
                               AssetNo = rscpasst.AssetNo,
                               Os = cl.Os,
                               Ostype = cl.Ostype,
                               ComManufacturer = cl.ComManufacturer,
                               ComModel = cl.ComModel,
                               ComSerialNo = cl.ComSerialNo,
                               CpuModel = cl.CpuModel,
                               Ramsize = cl.Ramsize,
                               Nictype = cl.Nictype,
                               Ipadds = cl.Ipadds,
                               MacAdds = cl.MacAdds,
                               Domain = cl.Domain,
                               UserName = rsusr.UserName,
                               UserLastname = rsusr.UserLastname,
                               MonitorManufacturer = rsmt.MonitorManufacturer,
                               MonitorModel = rsmt.MonitorModel,
                               MonitorSerialNo = rsmt.MonitorSerialNo,
                               MonitorAsset = rsmt.MonitorAsset,
                               DataUpdate = cl.DataUpdate,
                            }).ToList();
     
            return View(rslt);
        }
        
        /*Get (HttpGet Method) data all of Computer details on Database, Use to DataTable on Computer List page*/
        [HttpGet]
        public JsonResult GetAllCom()
        {
            var db = new ndt_dbContext();
            var rslt = (  from cl in db.TbComputerLists
                            join usr in db.TbUsers on cl.UserId equals usr.IdUser into usrs 
                            from rsusr in usrs.DefaultIfEmpty()
                            join mt in db.TbMonitorLists on cl.MonitorId equals mt.IdMonitorList into mts
                            from rsmt in mts.DefaultIfEmpty()
                            join cpasst in db.TbComputerAssetNos on cl.AssetNo equals cpasst.IdComputerAssetNo into cpassts
                            from rscpasst in cpassts.DefaultIfEmpty()
                            orderby cl.DataUpdate
                            select new GetAll
                            {
                               ComputerName = cl.ComputerName,
                               AssetNo = rscpasst.AssetNo,
                               Os = cl.Os,
                               Ostype = cl.Ostype,
                               ComManufacturer = cl.ComManufacturer,
                               ComModel = cl.ComModel,
                               ComSerialNo = cl.ComSerialNo,
                               CpuModel = cl.CpuModel,
                               Ramsize = cl.Ramsize,
                               Nictype = cl.Nictype,
                               Ipadds = cl.Ipadds,
                               MacAdds = cl.MacAdds,
                               Domain = cl.Domain,
                               UserName = rsusr.UserName,
                               UserLastname = rsusr.UserLastname,
                               MonitorManufacturer = rsmt.MonitorManufacturer,
                               MonitorModel = rsmt.MonitorModel,
                               MonitorSerialNo = rsmt.MonitorSerialNo,
                               MonitorAsset = rsmt.MonitorAsset,
                               DataUpdate = cl.DataUpdate,
                            }).ToList();
     
            return Json(rslt);
        }
        
        /*Get (HttpGet Method) data all of Computer do not update data on Database, Use Dashboard page*/
        [HttpGet]
        public JsonResult GetAllComNotUpdate()
        {
            var db = new ndt_dbContext();
            var rslt = (  from cl in db.TbComputerLists
                            join usr in db.TbUsers on cl.UserId equals usr.IdUser into usrs 
                            from rsusr in usrs.DefaultIfEmpty()
                            join mt in db.TbMonitorLists on cl.MonitorId equals mt.IdMonitorList into mts
                            from rsmt in mts.DefaultIfEmpty()
                            join cpasst in db.TbComputerAssetNos on cl.AssetNo equals cpasst.IdComputerAssetNo into cpassts
                            from rscpasst in cpassts.DefaultIfEmpty()
                            where cl.DataUpdate < DateTime.Now.AddDays(-7)
                            orderby cl.DataUpdate
                            select new GetAll
                            {
                               ComputerName = cl.ComputerName,
                               AssetNo = rscpasst.AssetNo,
                               Os = cl.Os,
                               Ostype = cl.Ostype,
                               ComManufacturer = cl.ComManufacturer,
                               ComModel = cl.ComModel,
                               ComSerialNo = cl.ComSerialNo,
                               CpuModel = cl.CpuModel,
                               Ramsize = cl.Ramsize,
                               Nictype = cl.Nictype,
                               Ipadds = cl.Ipadds,
                               MacAdds = cl.MacAdds,
                               Domain = cl.Domain,
                               UserName = rsusr.UserName,
                               UserLastname = rsusr.UserLastname,
                               MonitorManufacturer = rsmt.MonitorManufacturer,
                               MonitorModel = rsmt.MonitorModel,
                               MonitorSerialNo = rsmt.MonitorSerialNo,
                               MonitorAsset = rsmt.MonitorAsset,
                               DataUpdate = cl.DataUpdate,
                            }).ToList();
     
            return Json(rslt);
            
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
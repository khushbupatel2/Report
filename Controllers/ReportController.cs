using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RM_Reports.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MonthlyReport(int vendorId,string month,string issueYear,string vehicleType,bool isShowTotal,bool iswithEndDate) {
            ViewBag.vendorId = vendorId.ToString();
         ViewBag.month = month;
            ViewBag.issueYear = issueYear;
            ViewBag.vehicleType = vehicleType;
              ViewBag.isShowTotal = isShowTotal;
            ViewBag.iswithEndDate = iswithEndDate;
            return View();
        }
        public ActionResult WorkOrderReport(string Id)
        {
            ViewBag.Id = Id;
            return View();
        }
        public ActionResult UnitRepairHistoryReport(string UnitId)
        {
            ViewBag.unitno = UnitId;
            return View();
        }
        public ActionResult TruckReport(string unitId,string fromDate,string toDate,string division,string issueCategory, string isfixwithCategory, string rate,string activeInDispatch,string vendorType_Search)
        {
            ViewBag.unitId = unitId;
            ViewBag.FromDate = fromDate;
            ViewBag.ToDate = toDate;
            ViewBag.Division = division;
            ViewBag.issueCategory = issueCategory;
            ViewBag.rate = string.IsNullOrEmpty(rate) ? "0" : rate;
            ViewBag.isfixwithCategory = isfixwithCategory;
            ViewBag.activeInDispatch = activeInDispatch;
            ViewBag.vendorType_Search = vendorType_Search;
            return View();
        }
        public ActionResult TrailerReport(string unitId, string fromDate, string toDate, string issueCategory, string isfixwithCategory, string rate, string activeInDispatch,string vendorType_Search)
        {
            ViewBag.unitId = unitId;
            ViewBag.FromDate = fromDate;
            ViewBag.ToDate = toDate;
            ViewBag.issueCategory = issueCategory;
            ViewBag.rate = string.IsNullOrEmpty(rate)?"0":rate;
            ViewBag.isfixwithCategory = isfixwithCategory;
            ViewBag.activeInDispatch = activeInDispatch;
            ViewBag.vendorType_Search= vendorType_Search;
            return View();
        }
        public ActionResult MechanicReport(string mechanicId, string fromDate, string toDate)
        {
            if (mechanicId == "")
            {
                ViewBag.mechanicid = 0;
            }
            else
            {
                ViewBag.mechanicid = mechanicId;
            }
            ViewBag.FromDate = fromDate;
            ViewBag.ToDate = toDate;
            return View();
        }
        public ActionResult InventoryLabourCostReport(string vendorid, string fromDate, string toDate)
        {
            if (vendorid == "")
            {
                ViewBag.vendorid = 0;
            }
            else
            {
                ViewBag.vendorid = vendorid;
            }
            ViewBag.FromDate = fromDate;
            ViewBag.ToDate = toDate;
            return View();
        }
        public ActionResult TruckInspection(int id)
        {
           
            ViewBag.id = id;
            return View();
        }
        public ActionResult TrailerInspection(int id)
        {

            ViewBag.id = id;
            return View();
        }
        public ActionResult MissedSpecialEventReport(string fromDate,string toDate,string seCode,string UnitId,string terminal)
        {
            ViewBag.fromDate = fromDate;
            ViewBag.toDate = toDate;
            ViewBag.SeCode = seCode;
            ViewBag.UnitId = UnitId;
            ViewBag.Terminal = terminal;
            return View();
        }
        public ActionResult InventoryReport(string searchDate,string searchCriteria, string warehouseId)
        {
            ViewBag.searchDate = searchDate;
            ViewBag.searchCriteria= searchCriteria;
            ViewBag.warehouseId = warehouseId;
           
            return View();
        }

        public ActionResult TruckUSAInspection(int id)
        {

            ViewBag.id = id;
            return View();
        }
        public ActionResult TrailerUSAInspection(int id)
        {

            ViewBag.id = id;
            return View();
        }

		public ActionResult ZeroInventoryReport(string itemCode,string Warehouse)
		{
			ViewBag.itemCode = itemCode;
            ViewBag.Warehouse = Warehouse;
            return View();
		}

        public ActionResult OldTruckUSAInspection()
        {
            
            return View();
        }

        public ActionResult oilReport(string division,string dayCount,string miles)
        {
            ViewBag.division = division;
            ViewBag.dayCount = dayCount;
            ViewBag.miles = miles;
            return View();
        }
        public ActionResult oilChangedReport(string UnitId,string fromDate,string toDate)
        {
            ViewBag.unitId = UnitId;    
            ViewBag.fromDate = fromDate;
            ViewBag.toDate = toDate;
            return View();

        }
        public ActionResult OutsideInvoiceDetails(string vendorid,string unitId,string division,string locationId,string fromDate,string toDate,string searchWithoutTime, string conversionRate,string unitType)
        {
            ViewBag.vendorid= string.IsNullOrEmpty(vendorid)? "0" : vendorid;
            ViewBag.unitId= unitId;
            ViewBag.division=division;
            ViewBag.unitType= unitType;
            ViewBag.locationId= locationId;
            ViewBag.conversionRate= conversionRate;
            ViewBag.fromDate= fromDate;
            ViewBag.toDate= toDate;
            ViewBag.fromTime = searchWithoutTime;
          
            return View();
        }

        public ActionResult TireDetailsReport(string vendorid, string unitId, string tireno, string locationId, string fromDate, string toDate, string unitType)
        {
            if (unitType == "All")
            {
                unitType = "";
            }
            ViewBag.vendorid = vendorid;
            ViewBag.unitId = unitId;
            ViewBag.tireno = tireno;
            ViewBag.unitType = unitType;
            ViewBag.locationId = locationId;
            ViewBag.fromDate = fromDate;
            ViewBag.toDate = toDate;

            return View();
        }
    }
}
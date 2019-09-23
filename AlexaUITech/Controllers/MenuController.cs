using AlexaUITech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlexaUITech.Controllers
{
    public class MenuController : Controller
    {
        ApplicationDetailContext appDBContext = new ApplicationDetailContext();

        // GET: Menu
        public ActionResult Index()
        {
            if(Session["AppID"] != null)
            {
                string AppID = Session["AppID"].ToString();
                ApplicationDetail appdetails = (from m in appDBContext.ApplicationDetails
                                                where m.ApplicationId == AppID
                                                select m).FirstOrDefault();
                ModelState.Clear();


                return View(appdetails);
            }
            //var list = appDBContext.ApplicationDetails.ToList();
            //return View("~/Views/Menu/Index.cshtml", list[0]);
        return View();
        }

        [HttpPost]
        public ActionResult Index(ApplicationDetail model, string Search, string Update)
        {
            //var list = appDBContext.ApplicationDetails.ToList();
            Session["AppID"] = null;
            ApplicationDetail appdetails = (from m in appDBContext.ApplicationDetails
                             where m.ApplicationId == model.ApplicationId
                                     select m).FirstOrDefault();
            Session["AppID"] = model.ApplicationId;
            ModelState.Clear();

            if (Search == null)
            {
                appdetails.Channel = model.Channel;
                appdetails.LoanCurrency = model.LoanCurrency;
                appdetails.ApplicationDate = model.ApplicationDate;
                appdetails.Status = model.Status;
                appdetails.RequestedAmount = model.RequestedAmount;
                appdetails.Product = model.Product;
                appdetails.InterestRate = model.InterestRate;
                appdetails.Association = model.Association;
                appdetails.LoanOfficer = model.LoanOfficer;
                appdetails.Tenure = model.Tenure;
                appdetails.SalesAgent = model.SalesAgent;
                TempData["msg"] = "<script>alert('Collateral Details Updated Sucessfully');</script>";
                appDBContext.SaveChanges();
            }
            return View(appdetails);

          
        }

        public ActionResult ApplicanDetails()
        {
            if (Session["AppID"] != null)
            {
                string AppID = Session["AppID"].ToString();
                ApplicationDetail appdetails = (from m in appDBContext.ApplicationDetails
                                                where m.ApplicationId == AppID
                                                select m).FirstOrDefault();
                ModelState.Clear();


                return View(appdetails);
            }
            return View();
        }

        [HttpPost]
        public ActionResult ApplicanDetails(ApplicationDetail model)
        {
            string AppID = Session["AppID"].ToString();
            ApplicationDetail appdetails = (from m in appDBContext.ApplicationDetails
                                            where m.ApplicationId == AppID
                                            select m).FirstOrDefault();
            ModelState.Clear();

          
                appdetails.RelationshipType = model.RelationshipType;
                appdetails.SSN = model.SSN;
                appdetails.City = model.City;
                appdetails.State = model.State;
                appdetails.Suffix = model.Suffix;
                appdetails.FirstName = model.FirstName;
                appdetails.MiddleName = model.MiddleName;
                appdetails.LastName = model.LastName;
                appdetails.DOB = model.DOB;
                appdetails.Address1 = model.Address1;
                appdetails.Address2 = model.Address2;
                appdetails.PinCode = model.PinCode;
                appDBContext.SaveChanges();
            TempData["msg"] = "<script>alert('Collateral Details Updated Sucessfully');</script>";
            return View(appdetails);


        }


        public ActionResult RequestDetails()
        {
            if (Session["AppID"] != null)
            {
                string AppID = Session["AppID"].ToString();
                ApplicationDetail appdetails = (from m in appDBContext.ApplicationDetails
                                                where m.ApplicationId == AppID
                                                select m).FirstOrDefault();
                ModelState.Clear();


                return View(appdetails);
            }
            return View();
        }

        [HttpPost]
        public ActionResult RequestDetails(ApplicationDetail model)
        {
            string AppID = Session["AppID"].ToString();
            ApplicationDetail appdetails = (from m in appDBContext.ApplicationDetails
                                            where m.ApplicationId == AppID
                                            select m).FirstOrDefault();
            ModelState.Clear();


            appdetails.RequestedAmount = model.RequestedAmount;
            appdetails.InterestRate = model.InterestRate;
            appdetails.Tenure = model.Tenure;
            appdetails.Product = model.Product;
            appDBContext.SaveChanges();
            TempData["msg"] = "<script>alert('Collateral Details Updated Sucessfully');</script>";
            return View(appdetails);
        }

        public ActionResult CollateralDetails()
        {
            if (Session["AppID"] != null)
            {
                string AppID = Session["AppID"].ToString();
                ApplicationDetail appdetails = (from m in appDBContext.ApplicationDetails
                                                where m.ApplicationId == AppID
                                                select m).FirstOrDefault();
                ModelState.Clear();


                return View(appdetails);
            }
            return View();
        }

        [HttpPost]
        public ActionResult CollateralDetails(ApplicationDetail model)
        {
            string AppID = Session["AppID"].ToString();
            ApplicationDetail appdetails = (from m in appDBContext.ApplicationDetails
                                            where m.ApplicationId == AppID
                                            select m).FirstOrDefault();
            ModelState.Clear();


            appdetails.AssetType = model.AssetType;
            appdetails.AssetID = model.AssetID;
            appdetails.CollateralAddress = model.CollateralAddress;
            appdetails.Country = model.Country;
            appDBContext.SaveChanges();
            TempData["msg"] = "<script>alert('Collateral Details Updated Sucessfully');</script>";
            return View(appdetails);
        }

        public ActionResult CreditScoring()
        {
            if (Session["AppID"] != null)
            {
                string AppID = Session["AppID"].ToString();
                ApplicationDetail appdetails = (from m in appDBContext.ApplicationDetails
                                                where m.ApplicationId == AppID
                                                select m).FirstOrDefault();
                ModelState.Clear();


                return View(appdetails);
            }
            return View();
        }

        [HttpPost]
        public ActionResult CreditScoring(ApplicationDetail model)
        {
            string AppID = Session["AppID"].ToString();
            ApplicationDetail appdetails = (from m in appDBContext.ApplicationDetails
                                            where m.ApplicationId == AppID
                                            select m).FirstOrDefault();
            ModelState.Clear();


            appdetails.CreditScore = model.CreditScore;
            appdetails.AutoDecision = model.AutoDecision;
          
            appDBContext.SaveChanges();
            TempData["msg"] = "<script>alert('Credit Scoring Updated Sucessfully');</script>";
            return View(appdetails);

       
      
        }

        public ActionResult Documents()
        {
            
            return View();
        }
    }
}
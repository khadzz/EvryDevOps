using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlexaUITech.Models
{
    [Table("ApplicationDetail")]
    public class ApplicationDetail
    {
        [Key]
        public int ApplicationDetailId { get; set; }

        public string ApplicationId { get; set; }

        public string Channel { get; set; }

        public string LoanCurrency { get; set; }

        public string ApplicationDate { get; set; }

        public string Product { get; set; }

        public string LoanType { get; set; }

        public string InterestRate { get; set; }
        public string Status { get; set; }

        public string RequestedAmount { get; set; }

        public string Association { get; set; }

        public string LoanOfficer { get; set; }

        public string Tenure { get; set; }

        public string SalesAgent { get; set; }

        public string RelationshipType { get; set; }

        public string SSN { get; set; }

        public string City { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string DOB { get; set; }

        public string State { get; set; }

        public string PinCode { get; set; }

        public string Suffix { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Fee { get; set; }

        public string AssetType { get; set; }

        public string CollateralAddress { get; set; }

        public string AssetID { get; set; }

        public string Country { get; set; }

        public string CreditScore { get; set; }

        public string AutoDecision { get; set; }


    }
}
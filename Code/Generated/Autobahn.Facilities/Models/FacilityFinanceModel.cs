//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinanceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityFinance Model
     /// </summary>
    public partial class FacilityFinanceModel : AutobahnBase, Interfaces.IFacilityFinance
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? FacilityReplacementValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  IndebtednessAmountAllowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InsuranceDeductible { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PublicEducationMillRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}

//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityMortgage Model
     /// </summary>
    public partial class FacilityMortgageModel : AutobahnBase, Interfaces.IFacilityMortgage
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? FacilityMortgageInterestAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityTotalAssessedValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityMortgageInterestTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityMortgageTypeId { get; set; }

    }
}

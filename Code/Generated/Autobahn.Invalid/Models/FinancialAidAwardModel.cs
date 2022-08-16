//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAidAwardModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The FinancialAidAward Model
     /// </summary>
    public partial class FinancialAidAwardModel : AutobahnBase, Interfaces.IFinancialAidAward
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? FinancialAidAwardAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FinancialAidYearDesignator { get; set; }

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
        public  RefFinancialAidAwardTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFinancialAidStatusId { get; set; }

    }
}

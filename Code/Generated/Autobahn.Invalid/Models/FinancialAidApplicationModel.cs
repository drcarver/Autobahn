//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAidApplicationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The FinancialAidApplication Model
     /// </summary>
    public partial class FinancialAidApplicationModel : AutobahnBase, Interfaces.IFinancialAidApplication
    {
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
        public Guid? RefFinancialAidApplicationTypeId { get; set; }

    }
}

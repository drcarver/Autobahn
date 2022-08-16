//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAccountModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The FinancialAccount Model
     /// </summary>
    public partial class FinancialAccountModel : AutobahnBase, Interfaces.IFinancialAccount
    {
        /// <summary>
        /// 
        /// </summary>
        public  AccountNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FinancialAccountNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FinancialExpenditureProjectReportingCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Name { get; set; }

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
        public  RefFinancialAccountBalanceSheetCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefFinancialAccountCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFinancialAccountFundClassificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFinancialAccountProgramCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFinancialAccountRevenueCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFinancialExpenditureFunctionCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFinancialExpenditureLevelOfInstructionCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFinancialExpenditureObjectCodeId { get; set; }

    }
}

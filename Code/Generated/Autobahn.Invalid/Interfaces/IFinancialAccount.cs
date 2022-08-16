//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IFinancialAccount.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IFinancialAccount Interface
     /// </summary>
    public partial interface IFinancialAccount : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AccountNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FinancialAccountNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FinancialExpenditureProjectReportingCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFinancialAccountBalanceSheetCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefFinancialAccountCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFinancialAccountFundClassificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFinancialAccountProgramCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFinancialAccountRevenueCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFinancialExpenditureFunctionCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFinancialExpenditureLevelOfInstructionCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFinancialExpenditureObjectCodeId { get; set; }

    }
}

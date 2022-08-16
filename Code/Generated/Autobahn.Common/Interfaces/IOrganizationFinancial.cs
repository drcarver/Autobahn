//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationFinancial.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationFinancial Interface
     /// </summary>
    public partial interface IOrganizationFinancial : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? ActualValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BudgetedValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EncumberedValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FiscalPeriodBeginDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FiscalPeriodEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FiscalYear { get; set; }

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
         Value { get; set; }

    }
}

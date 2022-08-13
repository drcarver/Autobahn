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
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        System.Decimal? ActualValue { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        System.Decimal? BudgetedValue { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        System.DateTime? Date { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        System.Decimal? EncumberedValue { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        Guid FinancialAccountId { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        Guid? FinancialAccountProgramId { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        System.DateTime? FiscalPeriodBeginDate { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        System.DateTime? FiscalPeriodEndDate { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        System.String FiscalYear { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        Guid OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        System.Decimal? Value { get; set; }

    }
}

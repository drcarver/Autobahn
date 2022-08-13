//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFinancialModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationFinancial Model
     /// </summary>
    public partial class OrganizationFinancialModel : AutobahnBase, Interfaces.IOrganizationFinancial
    {
        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public System.Decimal? ActualValue { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public System.Decimal? BudgetedValue { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public System.Decimal? EncumberedValue { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public Guid FinancialAccountId { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public Guid? FinancialAccountProgramId { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public System.DateTime? FiscalPeriodBeginDate { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public System.DateTime? FiscalPeriodEndDate { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public System.String FiscalYear { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public Guid OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </summary>
        public System.Decimal? Value { get; set; }

    }
}

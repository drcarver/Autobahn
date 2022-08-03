//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationFinancial.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationFinancial
     /// </summary>
    public partial interface IOrganizationFinancial
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FinancialAccount"/> model
        /// </summary>
        Guid FinancialAccountId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        Guid OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.ActualValue nullable property
        /// </summary>
        System.Decimal? ActualValue { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.BudgetedValue nullable property
        /// </summary>
        System.Decimal? BudgetedValue { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.Date nullable property
        /// </summary>
        System.DateTime? Date { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.EncumberedValue nullable property
        /// </summary>
        System.Decimal? EncumberedValue { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.Value nullable property
        /// </summary>
        System.Decimal? Value { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.FiscalPeriodBeginDate nullable property
        /// </summary>
        System.DateTime? FiscalPeriodBeginDate { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.FiscalPeriodEndDate nullable property
        /// </summary>
        System.DateTime? FiscalPeriodEndDate { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.FiscalYear non nullable property
        /// </summary>
        System.String FiscalYear { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FinancialAccountProgram"/> model
        /// </summary>
        Guid? FinancialAccountProgramId { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}

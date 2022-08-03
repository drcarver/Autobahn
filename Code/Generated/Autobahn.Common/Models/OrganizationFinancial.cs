//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationFinancial.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationFinancial
     /// </summary>
    public partial class OrganizationFinancial : IOrganizationFinancial
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FinancialAccount"/> model
        /// </summary>
        public Guid FinancialAccountId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        public Guid OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.ActualValue nullable property
        /// </summary>
        public System.Decimal? ActualValue { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.BudgetedValue nullable property
        /// </summary>
        public System.Decimal? BudgetedValue { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.Date nullable property
        /// </summary>
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.EncumberedValue nullable property
        /// </summary>
        public System.Decimal? EncumberedValue { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.Value nullable property
        /// </summary>
        public System.Decimal? Value { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.FiscalPeriodBeginDate nullable property
        /// </summary>
        public System.DateTime? FiscalPeriodBeginDate { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.FiscalPeriodEndDate nullable property
        /// </summary>
        public System.DateTime? FiscalPeriodEndDate { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.FiscalYear non nullable property
        /// </summary>
        public System.String FiscalYear { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FinancialAccountProgram"/> model
        /// </summary>
        public Guid? FinancialAccountProgramId { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationFinancial.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}

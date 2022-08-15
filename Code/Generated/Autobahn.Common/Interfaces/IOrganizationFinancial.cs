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

    }
}

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

    }
}

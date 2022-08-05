//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IFinancialAidApplication.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IFinancialAidApplication
     /// </summary>
    public partial interface IFinancialAidApplication : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefFinancialAidApplicationType"/> model
        /// </summary>
        Guid RefFinancialAidApplicationTypeId { get; set; }

        /// <summary>
        /// Defines the FinancialAidApplication.FinancialAidYearDesignator non nullable property
        /// </summary>
        System.String FinancialAidYearDesignator { get; set; }

    }
}

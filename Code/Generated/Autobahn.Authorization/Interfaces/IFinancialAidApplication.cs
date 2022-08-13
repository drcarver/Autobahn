//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IFinancialAidApplication.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IFinancialAidApplication Interface
     /// </summary>
    public partial interface IFinancialAidApplication : IAutobahnBase
    {
        /// <summary>
        /// The type of financial application completed by an individual.
        /// </summary>
        System.String FinancialAidYearDesignator { get; set; }

        /// <summary>
        /// The type of financial application completed by an individual.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The type of financial application completed by an individual.
        /// </summary>
        Guid RefFinancialAidApplicationTypeId { get; set; }

    }
}

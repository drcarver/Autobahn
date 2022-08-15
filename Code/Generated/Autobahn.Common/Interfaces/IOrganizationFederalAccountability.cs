//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationFederalAccountability.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationFederalAccountability Interface
     /// </summary>
    public partial interface IOrganizationFederalAccountability : IAutobahnBase
    {
        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        System.String AccountabilityReportTitle { get; set; }

    }
}

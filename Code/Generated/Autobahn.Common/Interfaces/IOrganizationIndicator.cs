//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationIndicator.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationIndicator Interface
     /// </summary>
    public partial interface IOrganizationIndicator : IAutobahnBase
    {
        System.String IndicatorValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefOrganizationIndicator"/> model
        /// </summary>
        Guid RefOrganizationIndicatorId { get; set; }

    }
}

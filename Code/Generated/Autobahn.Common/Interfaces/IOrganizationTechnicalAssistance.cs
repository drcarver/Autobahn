//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationTechnicalAssistance.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationTechnicalAssistance Interface
     /// </summary>
    public partial interface IOrganizationTechnicalAssistance : IAutobahnBase
    {
        /// <summary>
        /// Indicates whether or not the technical assistance was approved.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Indicates whether or not the technical assistance was approved.
        /// </summary>
        Guid? RefTechnicalAssistanceDeliveryTypeId { get; set; }

        /// <summary>
        /// Indicates whether or not the technical assistance was approved.
        /// </summary>
        Guid? RefTechnicalAssistanceTypeId { get; set; }

        /// <summary>
        /// Indicates whether or not the technical assistance was approved.
        /// </summary>
        System.Boolean? TechnicalAssistanceApprovedInd { get; set; }

    }
}
//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationTechnicalAssistance.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationTechnicalAssistance
     /// </summary>
    public partial interface IOrganizationTechnicalAssistance : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceType"/> model
        /// </summary>
        Guid? RefTechnicalAssistanceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceDeliveryType"/> model
        /// </summary>
        Guid? RefTechnicalAssistanceDeliveryTypeId { get; set; }

        /// <summary>
        /// Defines the OrganizationTechnicalAssistance.TechnicalAssistanceApprovedInd nullable property
        /// </summary>
        System.Boolean? TechnicalAssistanceApprovedInd { get; set; }

    }
}

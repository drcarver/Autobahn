//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationTechnicalAssistance.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationTechnicalAssistance
     /// </summary>
    public partial interface IOrganizationTechnicalAssistance
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

        /// <summary>
        /// Defines the OrganizationTechnicalAssistance.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationTechnicalAssistance.RecordEndDateTime nullable property
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

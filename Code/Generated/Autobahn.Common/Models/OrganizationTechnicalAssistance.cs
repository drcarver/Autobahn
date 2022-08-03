//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationTechnicalAssistance.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationTechnicalAssistance
     /// </summary>
    public partial class OrganizationTechnicalAssistance : IOrganizationTechnicalAssistance
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceType"/> model
        /// </summary>
        public Guid? RefTechnicalAssistanceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceDeliveryType"/> model
        /// </summary>
        public Guid? RefTechnicalAssistanceDeliveryTypeId { get; set; }

        /// <summary>
        /// Defines the OrganizationTechnicalAssistance.TechnicalAssistanceApprovedInd nullable property
        /// </summary>
        public System.Boolean? TechnicalAssistanceApprovedInd { get; set; }

        /// <summary>
        /// Defines the OrganizationTechnicalAssistance.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationTechnicalAssistance.RecordEndDateTime nullable property
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

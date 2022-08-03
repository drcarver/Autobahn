//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IStaffTechnicalAssistance.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffTechnicalAssistance
     /// </summary>
    public partial interface IStaffTechnicalAssistance
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceType"/> model
        /// </summary>
        Guid? RefTechnicalAssistanceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceDeliveryType"/> model
        /// </summary>
        Guid? RefTechnicalAssistanceDeliveryTypeId { get; set; }

        /// <summary>
        /// Defines the StaffTechnicalAssistance.TechnicalAssistanceApprovedInd nullable property
        /// </summary>
        System.Boolean? TechnicalAssistanceApprovedInd { get; set; }

        /// <summary>
        /// Defines the StaffTechnicalAssistance.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the StaffTechnicalAssistance.RecordEndDateTime nullable property
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

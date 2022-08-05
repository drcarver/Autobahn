//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IStaffTechnicalAssistance.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffTechnicalAssistance
     /// </summary>
    public partial interface IStaffTechnicalAssistance : IAutobahnBase
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

    }
}

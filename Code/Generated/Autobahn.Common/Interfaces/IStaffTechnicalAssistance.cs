//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IStaffTechnicalAssistance.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffTechnicalAssistance Interface
     /// </summary>
    public partial interface IStaffTechnicalAssistance : IAutobahnBase
    {
        /// <summary>
        /// Indicates whether or not the technical assistance was approved.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

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

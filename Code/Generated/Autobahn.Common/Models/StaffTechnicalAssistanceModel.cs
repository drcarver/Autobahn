//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffTechnicalAssistanceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffTechnicalAssistance Model
     /// </summary>
    public partial class StaffTechnicalAssistanceModel : AutobahnBase, Interfaces.IStaffTechnicalAssistance
    {
        /// <summary>
        /// Indicates whether or not the technical assistance was approved.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Indicates whether or not the technical assistance was approved.
        /// </summary>
        public Guid? RefTechnicalAssistanceDeliveryTypeId { get; set; }

        /// <summary>
        /// Indicates whether or not the technical assistance was approved.
        /// </summary>
        public Guid? RefTechnicalAssistanceTypeId { get; set; }

        /// <summary>
        /// Indicates whether or not the technical assistance was approved.
        /// </summary>
        public System.Boolean? TechnicalAssistanceApprovedInd { get; set; }

    }
}

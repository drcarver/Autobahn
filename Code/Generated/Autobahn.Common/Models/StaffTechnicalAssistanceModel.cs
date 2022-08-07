//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffTechnicalAssistanceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffTechnicalAssistance Model
     /// </summary>
    public partial class StaffTechnicalAssistanceModel : AutobahnBase, Interfaces.IStaffTechnicalAssistanceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceType"/> model
        /// </summary>
        public Guid? RefTechnicalAssistanceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceDeliveryType"/> model
        /// </summary>
        public Guid? RefTechnicalAssistanceDeliveryTypeId { get; set; }

        /// <summary>
        /// Defines the StaffTechnicalAssistance.TechnicalAssistanceApprovedInd nullable property
        /// </summary>
        public System.Boolean? TechnicalAssistanceApprovedInd { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}

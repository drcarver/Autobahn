//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELStaff.cs
//**********************************************************

using Autobahn.EarlyLearning.Interfaces;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELStaff
     /// </summary>
    public partial class ELStaff : IELStaff
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ELStaff"/> model
        /// </summary>
        public Guid ELStaffId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefChildDevelopmentAssociateType"/> model
        /// </summary>
        public Guid? RefChildDevelopmentAssociateTypeId { get; set; }

        /// <summary>
        /// Defines the ELStaff.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ELStaff.RecordEndDateTime nullable property
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

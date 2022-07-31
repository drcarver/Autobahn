//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELStaff.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELStaff
     /// </summary>
    public partial Interface IELStaff
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ELStaff"/> model
        /// </summary>
        Guid ELStaffId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefChildDevelopmentAssociateType"/> model
        /// </summary>
        Guid? RefChildDevelopmentAssociateTypeId { get; set; }

        /// <summary>
        /// Defines the ELStaff.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ELStaff.RecordEndDateTime nullable property
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

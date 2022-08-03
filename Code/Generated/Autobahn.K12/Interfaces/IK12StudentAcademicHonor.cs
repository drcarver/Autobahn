//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentAcademicHonor.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentAcademicHonor
     /// </summary>
    public partial interface IK12StudentAcademicHonor
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicHonorType"/> model
        /// </summary>
        Guid? RefAcademicHonorTypeId { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicHonor.HonorDescription non nullable property
        /// </summary>
        System.String HonorDescription { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicHonor.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicHonor.RecordEndDateTime nullable property
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

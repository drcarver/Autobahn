//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentDemographic.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentDemographic
     /// </summary>
    public partial interface IPsStudentDemographic
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentDemographic.NumberOfDependents nullable property
        /// </summary>
        System.Int32? NumberOfDependents { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDependencyStatus"/> model
        /// </summary>
        Guid? RefDependencyStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTuitionResidencyType"/> model
        /// </summary>
        Guid? RefTuitionResidencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusResidencyType"/> model
        /// </summary>
        Guid? RefCampusResidencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsLepType"/> model
        /// </summary>
        Guid? RefPsLepTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPaternalEducationLevel"/> model
        /// </summary>
        Guid? RefPaternalEducationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMaternalEducationLevel"/> model
        /// </summary>
        Guid? RefMaternalEducationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCohortExclusion"/> model
        /// </summary>
        Guid? RefCohortExclusionId { get; set; }

        /// <summary>
        /// Defines the PsStudentDemographic.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentDemographic.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentDemographic.ChildrenOfFallenHeroesIndicator nullable property
        /// </summary>
        System.Boolean? ChildrenOfFallenHeroesIndicator { get; set; }

        /// <summary>
        /// Defines the PsStudentDemographic.EmancipatedMinor nullable property
        /// </summary>
        System.Boolean? EmancipatedMinor { get; set; }

        /// <summary>
        /// Defines the PsStudentDemographic.FirstGenerationCollegeStudent nullable property
        /// </summary>
        System.Boolean? FirstGenerationCollegeStudent { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNumberOfDependentsType"/> model
        /// </summary>
        Guid? RefNumberOfDependentsTypeId { get; set; }

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

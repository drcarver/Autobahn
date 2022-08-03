//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentDemographic.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentDemographic
     /// </summary>
    public partial class PsStudentDemographic : IPsStudentDemographic
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentDemographic.NumberOfDependents nullable property
        /// </summary>
        public System.Int32? NumberOfDependents { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDependencyStatus"/> model
        /// </summary>
        public Guid? RefDependencyStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTuitionResidencyType"/> model
        /// </summary>
        public Guid? RefTuitionResidencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusResidencyType"/> model
        /// </summary>
        public Guid? RefCampusResidencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsLepType"/> model
        /// </summary>
        public Guid? RefPsLepTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPaternalEducationLevel"/> model
        /// </summary>
        public Guid? RefPaternalEducationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMaternalEducationLevel"/> model
        /// </summary>
        public Guid? RefMaternalEducationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCohortExclusion"/> model
        /// </summary>
        public Guid? RefCohortExclusionId { get; set; }

        /// <summary>
        /// Defines the PsStudentDemographic.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentDemographic.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentDemographic.ChildrenOfFallenHeroesIndicator nullable property
        /// </summary>
        public System.Boolean? ChildrenOfFallenHeroesIndicator { get; set; }

        /// <summary>
        /// Defines the PsStudentDemographic.EmancipatedMinor nullable property
        /// </summary>
        public System.Boolean? EmancipatedMinor { get; set; }

        /// <summary>
        /// Defines the PsStudentDemographic.FirstGenerationCollegeStudent nullable property
        /// </summary>
        public System.Boolean? FirstGenerationCollegeStudent { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNumberOfDependentsType"/> model
        /// </summary>
        public Guid? RefNumberOfDependentsTypeId { get; set; }

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
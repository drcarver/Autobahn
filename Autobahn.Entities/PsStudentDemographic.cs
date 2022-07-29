using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PsStudentDemographic")]
    public partial class PsStudentDemographic
    {
        public int PsStudentDemographicId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int? NumberOfDependents { get; set; }

        public int? RefDependencyStatusId { get; set; }

        public int? RefTuitionResidencyTypeId { get; set; }

        public int? RefCampusResidencyTypeId { get; set; }

        public int? RefPsLepTypeId { get; set; }

        public int? RefPaternalEducationLevelId { get; set; }

        public int? RefMaternalEducationLevelId { get; set; }

        public int? RefCohortExclusionId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public bool? ChildrenOfFallenHeroesIndicator { get; set; }

        public bool? EmancipatedMinor { get; set; }

        public bool? FirstGenerationCollegeStudent { get; set; }

        public int? RefNumberOfDependentsTypeId { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCampusResidencyType RefCampusResidencyType { get; set; }

        public virtual RefCohortExclusion RefCohortExclusion { get; set; }

        public virtual RefDependencyStatu RefDependencyStatu { get; set; }

        public virtual RefEducationLevel RefEducationLevel { get; set; }

        public virtual RefEducationLevel RefEducationLevel1 { get; set; }

        public virtual RefNumberOfDependentsType RefNumberOfDependentsType { get; set; }

        public virtual RefPsLepType RefPsLepType { get; set; }

        public virtual RefTuitionResidencyType RefTuitionResidencyType { get; set; }
    }
}

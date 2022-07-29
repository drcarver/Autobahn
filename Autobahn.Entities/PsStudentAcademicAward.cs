using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PsStudentAcademicAward")]
    public partial class PsStudentAcademicAward
    {
        public int PsStudentAcademicAwardId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [StringLength(14)]
        public string AcademicAwardDate { get; set; }

        public int? RefAcademicAwardLevelId { get; set; }

        [StringLength(80)]
        public string AcademicAwardTitle { get; set; }

        [StringLength(512)]
        public string RequirementsURL { get; set; }

        public int? RefAcademicAwardPrerequisiteTypeId { get; set; }

        public int? RefPESCAwardLevelTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RefAcademicAwardLevel RefAcademicAwardLevel { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAcademicAwardPrerequisiteType RefAcademicAwardPrerequisiteType { get; set; }

        public virtual RefPESCAwardLevelType RefPESCAwardLevelType { get; set; }
    }
}

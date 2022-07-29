using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonFamily")]
    public partial class PersonFamily
    {
        public int PersonFamilyId { get; set; }

        public int PersonId { get; set; }

        [StringLength(40)]
        public string FamilyIdentifier { get; set; }

        public int? NumberOfPeopleInFamily { get; set; }

        public int? NumberOfPeopleInHousehold { get; set; }

        public decimal? FamilyIncome { get; set; }

        public int? RefFamilyIncomeSourceId { get; set; }

        public int? RefIncomeCalculationMethodId { get; set; }

        public int? RefProofOfResidencyTypeId { get; set; }

        public int? RefELProgramEligibilityId { get; set; }

        public int? RefHighestEducationLevelCompletedId { get; set; }

        public int? RefCommunicationMethodId { get; set; }

        public bool? IncludedInCountedFamilySize { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? NumberOfHouseholdCollegeStudents { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCommunicationMethod RefCommunicationMethod { get; set; }

        public virtual RefEducationLevel RefEducationLevel { get; set; }

        public virtual RefELProgramEligibility RefELProgramEligibility { get; set; }

        public virtual RefFamilyIncomeSource RefFamilyIncomeSource { get; set; }

        public virtual RefIncomeCalculationMethod RefIncomeCalculationMethod { get; set; }

        public virtual RefProofOfResidencyType RefProofOfResidencyType { get; set; }
    }
}

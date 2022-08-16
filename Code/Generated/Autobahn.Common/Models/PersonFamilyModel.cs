//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonFamilyModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonFamily Model
     /// </summary>
    public partial class PersonFamilyModel : AutobahnBase, Interfaces.IPersonFamily
    {
        /// <summary>
        /// 
        /// </summary>
        public  FamilyIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FamilyIncome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  IncludedInCountedFamilySize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfHouseholdCollegeStudents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfPeopleInFamily { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfPeopleInHousehold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCommunicationMethodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefELProgramEligibilityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFamilyIncomeSourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefHighestEducationLevelCompletedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIncomeCalculationMethodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProofOfResidencyTypeId { get; set; }

    }
}

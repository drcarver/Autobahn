//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonFamilyModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonFamily Model
     /// </summary>
    public partial class PersonFamilyModel : AutobahnBase, Interfaces.IPersonFamilyModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonFamily.FamilyIdentifier non nullable property
        /// </summary>
        public System.String FamilyIdentifier { get; set; }

        /// <summary>
        /// Defines the PersonFamily.NumberOfPeopleInFamily nullable property
        /// </summary>
        public System.Int32? NumberOfPeopleInFamily { get; set; }

        /// <summary>
        /// Defines the PersonFamily.NumberOfPeopleInHousehold nullable property
        /// </summary>
        public System.Int32? NumberOfPeopleInHousehold { get; set; }

        /// <summary>
        /// Defines the PersonFamily.FamilyIncome nullable property
        /// </summary>
        public System.Decimal? FamilyIncome { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFamilyIncomeSource"/> model
        /// </summary>
        public Guid? RefFamilyIncomeSourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncomeCalculationMethod"/> model
        /// </summary>
        public Guid? RefIncomeCalculationMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProofOfResidencyType"/> model
        /// </summary>
        public Guid? RefProofOfResidencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramEligibility"/> model
        /// </summary>
        public Guid? RefELProgramEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighestEducationLevelCompleted"/> model
        /// </summary>
        public Guid? RefHighestEducationLevelCompletedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCommunicationMethod"/> model
        /// </summary>
        public Guid? RefCommunicationMethodId { get; set; }

        /// <summary>
        /// Defines the PersonFamily.IncludedInCountedFamilySize nullable property
        /// </summary>
        public System.Boolean? IncludedInCountedFamilySize { get; set; }

        /// <summary>
        /// Defines the PersonFamily.NumberOfHouseholdCollegeStudents nullable property
        /// </summary>
        public System.Int32? NumberOfHouseholdCollegeStudents { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}

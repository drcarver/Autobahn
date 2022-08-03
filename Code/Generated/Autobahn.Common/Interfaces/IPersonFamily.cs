//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonFamily.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonFamily
     /// </summary>
    public partial interface IPersonFamily
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonFamily.FamilyIdentifier non nullable property
        /// </summary>
        System.String FamilyIdentifier { get; set; }

        /// <summary>
        /// Defines the PersonFamily.NumberOfPeopleInFamily nullable property
        /// </summary>
        System.Int32? NumberOfPeopleInFamily { get; set; }

        /// <summary>
        /// Defines the PersonFamily.NumberOfPeopleInHousehold nullable property
        /// </summary>
        System.Int32? NumberOfPeopleInHousehold { get; set; }

        /// <summary>
        /// Defines the PersonFamily.FamilyIncome nullable property
        /// </summary>
        System.Decimal? FamilyIncome { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFamilyIncomeSource"/> model
        /// </summary>
        Guid? RefFamilyIncomeSourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncomeCalculationMethod"/> model
        /// </summary>
        Guid? RefIncomeCalculationMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProofOfResidencyType"/> model
        /// </summary>
        Guid? RefProofOfResidencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramEligibility"/> model
        /// </summary>
        Guid? RefELProgramEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighestEducationLevelCompleted"/> model
        /// </summary>
        Guid? RefHighestEducationLevelCompletedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCommunicationMethod"/> model
        /// </summary>
        Guid? RefCommunicationMethodId { get; set; }

        /// <summary>
        /// Defines the PersonFamily.IncludedInCountedFamilySize nullable property
        /// </summary>
        System.Boolean? IncludedInCountedFamilySize { get; set; }

        /// <summary>
        /// Defines the PersonFamily.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonFamily.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the PersonFamily.NumberOfHouseholdCollegeStudents nullable property
        /// </summary>
        System.Int32? NumberOfHouseholdCollegeStudents { get; set; }

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
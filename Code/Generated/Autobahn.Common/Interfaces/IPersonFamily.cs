//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonFamily.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonFamily Interface
     /// </summary>
    public partial interface IPersonFamily : IAutobahnBase
    {
        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        System.String FamilyIdentifier { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        System.Decimal? FamilyIncome { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        System.Boolean? IncludedInCountedFamilySize { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        System.Int32? NumberOfHouseholdCollegeStudents { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        System.Int32? NumberOfPeopleInFamily { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        System.Int32? NumberOfPeopleInHousehold { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        Guid? RefCommunicationMethodId { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        Guid? RefELProgramEligibilityId { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        Guid? RefFamilyIncomeSourceId { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        Guid? RefHighestEducationLevelCompletedId { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        Guid? RefIncomeCalculationMethodId { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        Guid? RefProofOfResidencyTypeId { get; set; }

    }
}

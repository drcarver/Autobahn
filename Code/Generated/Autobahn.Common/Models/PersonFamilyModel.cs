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
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public System.String FamilyIdentifier { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public System.Decimal? FamilyIncome { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public System.Boolean? IncludedInCountedFamilySize { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public System.Int32? NumberOfHouseholdCollegeStudents { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public System.Int32? NumberOfPeopleInFamily { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public System.Int32? NumberOfPeopleInHousehold { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public Guid? RefCommunicationMethodId { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public Guid? RefELProgramEligibilityId { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public Guid? RefFamilyIncomeSourceId { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public Guid? RefHighestEducationLevelCompletedId { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public Guid? RefIncomeCalculationMethodId { get; set; }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public Guid? RefProofOfResidencyTypeId { get; set; }

    }
}

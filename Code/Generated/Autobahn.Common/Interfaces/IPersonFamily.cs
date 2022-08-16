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
        /// 
        /// </summary>
         FamilyIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FamilyIncome { get; set; }

        /// <summary>
        /// 
        /// </summary>
         IncludedInCountedFamilySize { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfHouseholdCollegeStudents { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfPeopleInFamily { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfPeopleInHousehold { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCommunicationMethodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefELProgramEligibilityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFamilyIncomeSourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefHighestEducationLevelCompletedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIncomeCalculationMethodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProofOfResidencyTypeId { get; set; }

    }
}

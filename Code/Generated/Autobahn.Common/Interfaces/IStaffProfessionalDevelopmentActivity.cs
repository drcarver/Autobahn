//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IStaffProfessionalDevelopmentActivity.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffProfessionalDevelopmentActivity Interface
     /// </summary>
    public partial interface IStaffProfessionalDevelopmentActivity : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ActivityCompletionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ActivityIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ActivityStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ActivityTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfCreditsEarned { get; set; }

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
        Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProfessionalDevelopmentFinancialSupportId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ScholarshipStatus { get; set; }

    }
}

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
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        System.DateTime? ActivityCompletionDate { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        System.String ActivityIdentifier { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        System.DateTime? ActivityStartDate { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        System.String ActivityTitle { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        System.Decimal? NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        Guid ProfessionalDevelopmentRequirementId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        Guid ProfessionalDevelopmentSessionId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        System.Boolean? ScholarshipStatus { get; set; }

    }
}

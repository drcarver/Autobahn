//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffProfessionalDevelopmentActivityModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffProfessionalDevelopmentActivity Model
     /// </summary>
    public partial class StaffProfessionalDevelopmentActivityModel : AutobahnBase, Interfaces.IStaffProfessionalDevelopmentActivity
    {
        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.DateTime? ActivityCompletionDate { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String ActivityIdentifier { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.DateTime? ActivityStartDate { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String ActivityTitle { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Decimal? NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid ProfessionalDevelopmentRequirementId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid ProfessionalDevelopmentSessionId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Boolean? ScholarshipStatus { get; set; }

    }
}

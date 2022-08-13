//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProfessionalDevelopmentActivityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The ProfessionalDevelopmentActivity Model
     /// </summary>
    public partial class ProfessionalDevelopmentActivityModel : AutobahnBase, Interfaces.IProfessionalDevelopmentActivity
    {
        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String ActivityCode { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String ActivityIdentifier { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String ApprovalCode { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Decimal? Cost { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid? CourseId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Decimal? Credits { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String Objective { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Boolean? ProfessionalDevelopmentActivityStateApprovedStatus { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid ProfessionalDevelopmentRequirementId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Boolean? PublishIndicator { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid? RefPDActivityApprovedPurposeId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid? RefPDActivityCreditTypeId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid? RefPDActivityLevelId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid? RefPDActivityTypeId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid? RefPDAudienceTypeId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Boolean? ScholarshipStatus { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String Title { get; set; }

    }
}

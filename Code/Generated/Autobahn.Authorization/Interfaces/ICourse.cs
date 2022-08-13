//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   ICourse.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The ICourse Interface
     /// </summary>
    public partial interface ICourse : IAutobahnBase
    {
        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        System.String CertificationDescription { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        System.Decimal? CreditValue { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        System.Int32? InstructionalMinutes { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        Guid? RefCourseApplicableEducationLevelId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        Guid? RefCourseLevelCharacteristicsId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        Guid? RefInstructionLanguageId { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        System.Int32? RepeatabilityMaximumNumber { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        System.String SCEDSequenceOfCourse { get; set; }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        System.String SubjectAbbreviation { get; set; }

    }
}

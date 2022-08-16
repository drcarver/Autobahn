//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   ICourse.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The ICourse Interface
     /// </summary>
    public partial interface ICourse : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         CertificationDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CreditValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InstructionalMinutes { get; set; }

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
         RefCourseApplicableEducationLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCourseLevelCharacteristicsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefInstructionLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RepeatabilityMaximumNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SCEDSequenceOfCourse { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SubjectAbbreviation { get; set; }

    }
}

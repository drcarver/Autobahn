//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessment Interface
     /// </summary>
    public partial interface IAssessment : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AssessmentFamilyShortName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentFamilyTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentRevisionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         GUID { get; set; }

        /// <summary>
        /// 
        /// </summary>
         IdentificationSystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Objective { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Provider { get; set; }

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
        Guid? RefAcademicSubjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ShortName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Title { get; set; }

    }
}

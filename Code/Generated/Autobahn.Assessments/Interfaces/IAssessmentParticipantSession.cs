//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentParticipantSession.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentParticipantSession Interface
     /// </summary>
    public partial interface IAssessmentParticipantSession : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ActualEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ActualStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentParticipantSessionDatabaseName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentParticipantSessionGUID { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DeliveryDeviceDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PlatformUserAgent { get; set; }

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
         RefAssessmentPlatformTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SecurityIssue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SpecialEventDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TimeAssessed { get; set; }

    }
}

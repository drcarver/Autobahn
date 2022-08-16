//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentParticipantSessionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentParticipantSession Model
     /// </summary>
    public partial class AssessmentParticipantSessionModel : AutobahnBase, Interfaces.IAssessmentParticipantSession
    {
        /// <summary>
        /// 
        /// </summary>
        public  ActualEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ActualStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentParticipantSessionDatabaseName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentParticipantSessionGUID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DeliveryDeviceDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PlatformUserAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentPlatformTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SecurityIssue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SpecialEventDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TimeAssessed { get; set; }

    }
}

//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipDisplayModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentNeedApipDisplay Model
     /// </summary>
    public partial class AssessmentNeedApipDisplayModel : AutobahnBase, Interfaces.IAssessmentNeedApipDisplay
    {
        /// <summary>
        /// 
        /// </summary>
        public  EncouragementActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? EncouragementAssignedSupportIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EncouragementSoundFileUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EncouragementTextMessagingString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MaskingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MaskingAssignedSupportIndicator { get; set; }

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
        public  RefAssessmentNeedMaskingTypeId { get; set; }

    }
}

//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedsProfile.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfile Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfile : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ActivateByDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentNeedType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? AssignedSupportFlag { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}

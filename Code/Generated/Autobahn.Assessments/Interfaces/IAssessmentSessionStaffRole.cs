//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentSessionStaffRole.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentSessionStaffRole Interface
     /// </summary>
    public partial interface IAssessmentSessionStaffRole : IAutobahnBase
    {
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
        Guid? RefAssessmentSessionStaffRoleTypeId { get; set; }

    }
}

//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentNeedApipDisplay.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedApipDisplay Interface
     /// </summary>
    public partial interface IAssessmentNeedApipDisplay : IAutobahnBase
    {
        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        System.Boolean? EncouragementAssignedSupportIndicator { get; set; }

    }
}

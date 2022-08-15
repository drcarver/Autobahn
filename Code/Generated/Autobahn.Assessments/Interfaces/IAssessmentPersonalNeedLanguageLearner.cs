//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedLanguageLearner.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedLanguageLearner Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedLanguageLearner : IAutobahnBase
    {
        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        System.Boolean? AssignedSupport { get; set; }

    }
}

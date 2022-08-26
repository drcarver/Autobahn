//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentFormAssessmentFormSection.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentFormAssessmentFormSection Interface
     /// </summary>
    public partial interface IAssessmentFormAssessmentFormSection : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
        /// </summary>
        Guid AssessmentFormId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
        /// </summary>
        Guid AssessmentFormSectionId { get; set; }

        Int32? SequenceNumber { get; set; }

    }
}

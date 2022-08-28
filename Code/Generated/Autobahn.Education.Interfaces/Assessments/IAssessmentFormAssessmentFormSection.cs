//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentFormAssessmentFormSection.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentFormAssessmentFormSection Interface
     /// </summary>
    public partial interface IAssessmentFormAssessmentFormSection : IAutobahnBase
    {
        #region IAssessmentFormAssessmentFormSection
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
        /// </summary>
        Guid AssessmentFormId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
        /// </summary>
        Guid AssessmentFormSectionId { get; set; }

        Int32? SequenceNumber { get; set; }

        #endregion
    }
}

//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentFormSectionAssessmentItem.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentFormSectionAssessmentItem Interface
     /// </summary>
    public partial interface IAssessmentFormSectionAssessmentItem : IAutobahnBase
    {
        #region IAssessmentFormSectionAssessmentItem
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
        /// </summary>
        Guid AssessmentFormSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentFormSectionItem"/> model
        /// </summary>
        Guid AssessmentFormSectionItemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
        /// </summary>
        Guid AssessmentItemId { get; set; }

        System.Int32 SequenceNumber { get; set; }

        #endregion
    }
}

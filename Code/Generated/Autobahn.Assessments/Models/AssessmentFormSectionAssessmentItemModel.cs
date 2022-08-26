//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionAssessmentItemModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentFormSectionAssessmentItem Model
     /// </summary>
    public partial class AssessmentFormSectionAssessmentItemModel : AutobahnBase, IAssessmentFormSectionAssessmentItem
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
        /// </summary>
        public Guid AssessmentFormSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentFormSectionItem"/> model
        /// </summary>
        public Guid AssessmentFormSectionItemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        public System.Int32 SequenceNumber { get; set; }

    }
}

//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentFormSectionModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentFormAssessmentFormSection Model
     /// </summary>
    public partial class AssessmentFormAssessmentFormSectionModel : AutobahnBase, IAssessmentFormAssessmentFormSection
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
        /// </summary>
        public Guid AssessmentFormId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
        /// </summary>
        public Guid AssessmentFormSectionId { get; set; }

        public Int32? SequenceNumber { get; set; }

    }
}

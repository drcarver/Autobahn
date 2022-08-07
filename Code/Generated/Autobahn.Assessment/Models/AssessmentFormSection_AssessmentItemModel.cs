//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentFormSection_AssessmentItemModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentFormSection_AssessmentItem Model
     /// </summary>
    public partial class AssessmentFormSection_AssessmentItemModel : AutobahnBase, Interfaces.IAssessmentFormSection_AssessmentItemModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSectionItem"/> model
        /// </summary>
        public Guid AssessmentFormSectionItemId { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection_AssessmentItem.SequenceNumber non nullable property
        /// </summary>
        public System.Int32 SequenceNumber { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSection"/> model
        /// </summary>
        public Guid AssessmentFormSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}

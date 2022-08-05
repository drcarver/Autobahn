//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentForm_AssessmentAsset.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentForm_AssessmentAsset
     /// </summary>
    public partial class AssessmentForm_AssessmentAsset : AutobahnBase, Interfaces.IAssessmentForm_AssessmentAsset
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentForm"/> model
        /// </summary>
        public Guid AssessmentFormId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAsset"/> model
        /// </summary>
        public Guid AssessmentAssetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}

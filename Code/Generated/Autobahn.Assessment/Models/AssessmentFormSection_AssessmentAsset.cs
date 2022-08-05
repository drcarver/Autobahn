//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentFormSection_AssessmentAsset.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentFormSection_AssessmentAsset
     /// </summary>
    public partial class AssessmentFormSection_AssessmentAsset : AutobahnBase, Interfaces.IAssessmentFormSection_AssessmentAsset
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSection"/> model
        /// </summary>
        public Guid AssessmentFormSectionId { get; set; }

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

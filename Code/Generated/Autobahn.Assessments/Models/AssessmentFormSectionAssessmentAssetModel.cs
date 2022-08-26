//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionAssessmentAssetModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentFormSectionAssessmentAsset Model
     /// </summary>
    public partial class AssessmentFormSectionAssessmentAssetModel : AutobahnBase, IAssessmentFormSectionAssessmentAsset
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAsset"/> model
        /// </summary>
        public Guid AssessmentAssetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
        /// </summary>
        public Guid AssessmentFormSectionId { get; set; }

    }
}

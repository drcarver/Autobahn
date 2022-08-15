//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentAsset Model
     /// </summary>
    public partial class AssessmentAssetModel : AutobahnBase, Interfaces.IAssessmentAsset
    {
        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public Guid? RefAssessmentLanguageId { get; set; }

    }
}

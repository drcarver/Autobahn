//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentFormSection_AssessmentAssetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentFormSection_AssessmentAsset Model
     /// </summary>
    public partial class AssessmentFormSection_AssessmentAssetModel : AutobahnBase, Interfaces.IAssessmentFormSection_AssessmentAsset
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentAssetId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentFormSectionId { get; set; }

    }
}

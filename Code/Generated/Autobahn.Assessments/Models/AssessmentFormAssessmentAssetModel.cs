//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentAssetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentFormAssessmentAsset Model
     /// </summary>
    public partial class AssessmentFormAssessmentAssetModel : AutobahnBase, Interfaces.IAssessmentFormAssessmentAsset
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}

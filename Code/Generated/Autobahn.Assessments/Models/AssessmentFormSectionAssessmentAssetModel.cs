//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionAssessmentAssetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentFormSectionAssessmentAsset Model
     /// </summary>
    public partial class AssessmentFormSectionAssessmentAssetModel : AutobahnBase, Interfaces.IAssessmentFormSectionAssessmentAsset
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

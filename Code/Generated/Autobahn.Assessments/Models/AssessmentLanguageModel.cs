//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentLanguageModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentLanguage Model
     /// </summary>
    public partial class AssessmentLanguageModel : AutobahnBase, Interfaces.IAssessmentLanguage
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

//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedBrailleModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentNeedBraille Model
     /// </summary>
    public partial class AssessmentNeedBrailleModel : AutobahnBase, Interfaces.IAssessmentNeedBraille
    {
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get; set; }

    }
}

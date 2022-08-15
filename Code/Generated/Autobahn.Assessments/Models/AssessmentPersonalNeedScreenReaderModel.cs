//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedScreenReaderModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedScreenReader Model
     /// </summary>
    public partial class AssessmentPersonalNeedScreenReaderModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedScreenReader
    {
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get; set; }

    }
}

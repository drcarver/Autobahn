//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentLanguageModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentLanguage Model
     /// </summary>
    public partial class AssessmentLanguageModel : AutobahnBase, IAssessmentLanguage
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessment"/> model
        /// </summary>
        public Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid RefLanguageId { get; set; }

    }
}

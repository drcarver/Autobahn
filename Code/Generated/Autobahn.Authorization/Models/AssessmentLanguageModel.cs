//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentLanguageModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentLanguage Model
     /// </summary>
    public partial class AssessmentLanguageModel : AutobahnBase, Interfaces.IAssessmentLanguage
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid RefLanguageId { get; set; }

    }
}

//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentLanguage.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentLanguage
     /// </summary>
    public partial interface IAssessmentLanguage : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Assessment"/> model
        /// </summary>
        Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLanguage"/> model
        /// </summary>
        Guid RefLanguageId { get; set; }

    }
}

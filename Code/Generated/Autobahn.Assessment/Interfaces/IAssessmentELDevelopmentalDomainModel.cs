//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentELDevelopmentalDomainModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentELDevelopmentalDomainModel Interface
     /// </summary>
    public partial interface IAssessmentELDevelopmentalDomainModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Assessment"/> model
        /// </summary>
        Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentELDevelopmentalDomain"/> model
        /// </summary>
        Guid RefAssessmentELDevelopmentalDomainId { get; set; }

    }
}

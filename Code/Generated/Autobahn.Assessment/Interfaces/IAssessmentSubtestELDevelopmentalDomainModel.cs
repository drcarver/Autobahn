//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentSubtestELDevelopmentalDomainModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentSubtestELDevelopmentalDomainModel Interface
     /// </summary>
    public partial interface IAssessmentSubtestELDevelopmentalDomainModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentELDevelopmentalDomain"/> model
        /// </summary>
        Guid RefAssessmentELDevelopmentalDomainId { get; set; }

    }
}

//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELChildDevelopmentalAssessmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildDevelopmentalAssessmentModel Interface
     /// </summary>
    public partial interface IELChildDevelopmentalAssessmentModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefChildDevelopmentalScreeningStatus"/> model
        /// </summary>
        Guid? RefChildDevelopmentalScreeningStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEvaluationFinding"/> model
        /// </summary>
        Guid? RefDevelopmentalEvaluationFindingId { get; set; }

    }
}

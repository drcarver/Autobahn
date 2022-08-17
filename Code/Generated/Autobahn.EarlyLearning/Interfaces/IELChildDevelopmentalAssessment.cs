//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildDevelopmentalAssessment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildDevelopmentalAssessment Interface
     /// </summary>
    public partial interface IELChildDevelopmentalAssessment : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefChildDevelopmentalScreeningStatus"/> model
        /// </summary>
        Guid? RefChildDevelopmentalScreeningStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefDevelopmentalEvaluationFinding"/> model
        /// </summary>
        Guid? RefDevelopmentalEvaluationFindingId { get; set; }

    }
}

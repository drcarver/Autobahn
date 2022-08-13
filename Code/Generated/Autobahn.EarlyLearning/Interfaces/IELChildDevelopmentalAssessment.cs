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
        /// The result of a brief standardized screening tool aiding in the identification of children at risk of a developmental delay/disorder.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// The result of a brief standardized screening tool aiding in the identification of children at risk of a developmental delay/disorder.
        /// </summary>
        Guid? RefChildDevelopmentalScreeningStatusId { get; set; }

        /// <summary>
        /// The result of a brief standardized screening tool aiding in the identification of children at risk of a developmental delay/disorder.
        /// </summary>
        Guid? RefDevelopmentalEvaluationFindingId { get; set; }

    }
}

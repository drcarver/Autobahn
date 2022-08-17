//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildDevelopmentalAssessmentModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The ELChildDevelopmentalAssessment Model
     /// </summary>
    public partial class ELChildDevelopmentalAssessmentModel : AutobahnBase, Interfaces.IELChildDevelopmentalAssessment
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefChildDevelopmentalScreeningStatus"/> model
        /// </summary>
        public Guid? RefChildDevelopmentalScreeningStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefDevelopmentalEvaluationFinding"/> model
        /// </summary>
        public Guid? RefDevelopmentalEvaluationFindingId { get; set; }

    }
}

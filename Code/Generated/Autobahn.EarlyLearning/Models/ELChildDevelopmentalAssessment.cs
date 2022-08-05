//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildDevelopmentalAssessment.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildDevelopmentalAssessment
     /// </summary>
    public partial class ELChildDevelopmentalAssessment : AutobahnBase, Interfaces.IELChildDevelopmentalAssessment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefChildDevelopmentalScreeningStatus"/> model
        /// </summary>
        public Guid? RefChildDevelopmentalScreeningStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEvaluationFinding"/> model
        /// </summary>
        public Guid? RefDevelopmentalEvaluationFindingId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}

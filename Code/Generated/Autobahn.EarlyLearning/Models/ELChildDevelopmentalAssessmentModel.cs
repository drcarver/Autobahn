//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildDevelopmentalAssessmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildDevelopmentalAssessment Model
     /// </summary>
    public partial class ELChildDevelopmentalAssessmentModel : AutobahnBase, Interfaces.IELChildDevelopmentalAssessment
    {
        /// <summary>
        /// The result of a brief standardized screening tool aiding in the identification of children at risk of a developmental delay/disorder.
        /// </summary>
        public Guid? RefChildDevelopmentalScreeningStatusId { get; set; }

    }
}

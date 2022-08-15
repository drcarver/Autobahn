//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELQualityRatingImprovementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELQualityRatingImprovement Model
     /// </summary>
    public partial class ELQualityRatingImprovementModel : AutobahnBase, Interfaces.IELQualityRatingImprovement
    {
        /// <summary>
        /// Program site participates in a Quality Rating and Improvement System (QRIS).
        /// </summary>
        public Guid? RefQrisParticipationId { get; set; }

    }
}

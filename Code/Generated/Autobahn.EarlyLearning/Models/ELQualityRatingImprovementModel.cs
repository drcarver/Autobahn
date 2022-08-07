//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELQualityRatingImprovementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELQualityRatingImprovement Model
     /// </summary>
    public partial class ELQualityRatingImprovementModel : AutobahnBase, Interfaces.IELQualityRatingImprovementModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the ELQualityRatingImprovement.NumberQrisLevels nullable property
        /// </summary>
        public System.Int32? NumberQrisLevels { get; set; }

        /// <summary>
        /// Defines the ELQualityRatingImprovement.QrisAwardDate nullable property
        /// </summary>
        public System.DateTime? QrisAwardDate { get; set; }

        /// <summary>
        /// Defines the ELQualityRatingImprovement.QRISExpirationDate nullable property
        /// </summary>
        public System.DateTime? QRISExpirationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQrisParticipation"/> model
        /// </summary>
        public Guid? RefQrisParticipationId { get; set; }

        /// <summary>
        /// Defines the ELQualityRatingImprovement.QrisScore non nullable property
        /// </summary>
        public System.String QrisScore { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}

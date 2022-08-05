//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELQualityRatingImprovement.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELQualityRatingImprovement
     /// </summary>
    public partial interface IELQualityRatingImprovement : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the ELQualityRatingImprovement.NumberQrisLevels nullable property
        /// </summary>
        System.Int32? NumberQrisLevels { get; set; }

        /// <summary>
        /// Defines the ELQualityRatingImprovement.QrisAwardDate nullable property
        /// </summary>
        System.DateTime? QrisAwardDate { get; set; }

        /// <summary>
        /// Defines the ELQualityRatingImprovement.QRISExpirationDate nullable property
        /// </summary>
        System.DateTime? QRISExpirationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQrisParticipation"/> model
        /// </summary>
        Guid? RefQrisParticipationId { get; set; }

        /// <summary>
        /// Defines the ELQualityRatingImprovement.QrisScore non nullable property
        /// </summary>
        System.String QrisScore { get; set; }

    }
}

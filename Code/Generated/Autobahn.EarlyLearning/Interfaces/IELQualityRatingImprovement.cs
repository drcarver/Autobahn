//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELQualityRatingImprovement.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELQualityRatingImprovement Interface
     /// </summary>
    public partial interface IELQualityRatingImprovement : IAutobahnBase
    {
        /// <summary>
        /// Program site participates in a Quality Rating and Improvement System (QRIS).
        /// </summary>
        System.Int32? NumberQrisLevels { get; set; }

        /// <summary>
        /// Program site participates in a Quality Rating and Improvement System (QRIS).
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Program site participates in a Quality Rating and Improvement System (QRIS).
        /// </summary>
        System.DateTime? QrisAwardDate { get; set; }

        /// <summary>
        /// Program site participates in a Quality Rating and Improvement System (QRIS).
        /// </summary>
        System.DateTime? QRISExpirationDate { get; set; }

        /// <summary>
        /// Program site participates in a Quality Rating and Improvement System (QRIS).
        /// </summary>
        System.String QrisScore { get; set; }

        /// <summary>
        /// Program site participates in a Quality Rating and Improvement System (QRIS).
        /// </summary>
        Guid? RefQrisParticipationId { get; set; }

    }
}

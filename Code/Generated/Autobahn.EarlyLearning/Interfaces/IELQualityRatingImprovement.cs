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
        /// Number of Quality Rating and Improvement System Levels
        /// <para>
        /// Number of quality levels in the Quality Rating and Improvement System (QRIS).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19843">Number of Quality Rating and Improvement System Levels</a>
        /// </para>
        /// </summary>
        System.Int32? NumberQrisLevels { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Quality Rating and Improvement System Award Date
        /// <para>
        /// Date Quality Rating and Improvement System score, level or rating was awarded.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19830">Quality Rating and Improvement System Award Date</a>
        /// </para>
        /// </summary>
        System.DateTime? QrisAwardDate { get; set; }

        /// <summary>
        /// Quality Rating and Improvement System Expiration Date
        /// <para>
        /// Date Quality Rating and Improvement System score, level or rating expires.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19831">Quality Rating and Improvement System Expiration Date</a>
        /// </para>
        /// </summary>
        System.DateTime? QRISExpirationDate { get; set; }

        /// <summary>
        /// Quality Rating and Improvement System Score
        /// <para>
        /// The score, rating or level received by a program for its Quality Rating and Improvement System (QRIS).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19357">Quality Rating and Improvement System Score</a>
        /// </para>
        /// </summary>
        System.String QrisScore { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQrisParticipation"/> model
        /// </summary>
        Guid? RefQrisParticipationId { get; set; }

    }
}
